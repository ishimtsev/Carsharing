﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Newtonsoft.Json;

namespace carsharing_project
{
	public partial class AddRental : Form
	{
		public bool EditMode = false;
		public string carID = string.Empty;
		public string cliID = string.Empty;
		public string empID = string.Empty;
		public string rentID = string.Empty;

		public AddRental()
		{
			InitializeComponent();
		}

		public AddRental(string rentid, string carid, string empid, string cliid, string start, string end, string ispaid)
		{
			InitializeComponent();

			EditMode = true;
			ClientListBox2.Enabled = false;
			carID = carid;
			cliID = cliid;
			empID = empid;
			rentID = rentid;
			if (ispaid == "Да")
				IsPaidCheckBox1.Checked = true;
			else
				IsPaidCheckBox1.Checked = false;
			//
			//выбор на datetimepicker начала и окончания проката
			//
		}

		private void AddRental_Load(object sender, EventArgs e)
		{
			dataGridView1.Columns.Add("Название", "Название");
			dataGridView1.Columns.Add("Описание", "Описание");
			dataGridView1.Columns.Add("Цена", "Цена");
			dataGridView1.Columns.Add("Количество", "Количество");
			dataGridView1.Columns.Add("Стоимость", "Стоимость");

			///////////////////////////////////////////////////////////////////////////////////////
			PriceLabel.Text = "5555";
			///////////////////////////////////////////////////////////////////////////////////////


			try
			{
				using (NpgsqlConnection cn = new NpgsqlConnection(Connection.str))
				{
					cn.Open();

					if (!EditMode)
					{
						//получение списка клиентов
						NpgsqlCommand cmd1 = new NpgsqlCommand("select cli_id as cliID, fio|| ', ' ||passport as cli_name from client_table;", cn);
						NpgsqlDataReader reader1 = cmd1.ExecuteReader();
						DataTable dt1 = new DataTable();
						dt1.Load(reader1);
						ClientListBox2.DataSource = dt1;
						ClientListBox2.DisplayMember = "cli_name";
						ClientListBox2.ValueMember = "cliID";
					}
					else
					{
						//получение списка услуг
						NpgsqlCommand cmd4 = new NpgsqlCommand("select services from rental_table WHERE rent_id=" + rentID + ";", cn);
						string services = cmd4.ExecuteScalar().ToString();
						ServiceList list = JsonConvert.DeserializeObject<ServiceList>(services);
						foreach (var service in list.services)
						{
							dataGridView1.Rows.Add(service.Name, service.Description, service.Price, service.Count, Convert.ToInt32(service.Price) * Convert.ToInt32(service.Count));
						}
					}

					//получение списка автомобилей
					NpgsqlCommand cmd2 = new NpgsqlCommand("select car_id as carID, \"name\"|| ', ' ||reg_num as car_name from car_table;", cn);
					NpgsqlDataReader reader2 = cmd2.ExecuteReader();
					DataTable dt2 = new DataTable();
					dt2.Load(reader2);

					CarListBox1.DataSource = dt2;
					CarListBox1.DisplayMember = "car_name";
					CarListBox1.ValueMember = "carID";

					//получение списка сотрудников
					NpgsqlCommand cmd3 = new NpgsqlCommand("select employee_table.emp_id as empID, fio|| ', ' ||passport as emp_name from \"employee-position_table\" join employee_table ON employee_table.emp_id=\"employee-position_table\".emp_id join position_table ON position_table.pos_id=\"employee-position_table\".pos_id WHERE position_table.\"name\"='Менеджер по работе с клиентами';", cn);
					NpgsqlDataReader reader3 = cmd3.ExecuteReader();
					DataTable dt3 = new DataTable();
					dt3.Load(reader3);

					EmployeesListBox1.DataSource = dt3;
					EmployeesListBox1.DisplayMember = "emp_name";
					EmployeesListBox1.ValueMember = "empID";

					cn.Close();
				}
				RefreshPrice();
			}
			catch (Exception er)
			{
				MessageBox.Show(er.Message);
			}
		}

		private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
			{
				dataGridView1.ClearSelection();
				dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
				dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
				contextMenuStrip1.Show(MousePosition);

				if (dataGridView1.Columns.Count == 0)
				{
					EditToolStripMenuItem.Enabled = false;
					DeleteToolStripMenuItem.Enabled = false;
				}
				else
				{
					EditToolStripMenuItem.Enabled = true;
					DeleteToolStripMenuItem.Enabled = true;
				}
			}
		}

		private void AddToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AddService form = new AddService();
			if (form.ShowDialog() == DialogResult.OK)
			{
				dataGridView1.Rows.Add(form.NameTextBox1.Text, form.DescrTextBox2.Text, form.PriceTextBox3.Text, form.CountNumericUpDown1.Value, (Convert.ToInt32(form.PriceTextBox3.Text) * form.CountNumericUpDown1.Value));
			}
			RefreshPrice();
		}

		private void EditToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AddService form = new AddService(dataGridView1.CurrentRow.Cells[0].Value.ToString(), dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString(), dataGridView1.CurrentRow.Cells[3].Value.ToString());
			if (form.ShowDialog() == DialogResult.OK)
			{
				dataGridView1.CurrentRow.Cells[0].Value = form.NameTextBox1.Text;
				dataGridView1.CurrentRow.Cells[1].Value = form.DescrTextBox2.Text;
				dataGridView1.CurrentRow.Cells[2].Value = form.PriceTextBox3.Text;
				dataGridView1.CurrentRow.Cells[3].Value = form.CountNumericUpDown1.Value;
				dataGridView1.CurrentRow.Cells[4].Value = Convert.ToInt32(form.PriceTextBox3.Text) * form.CountNumericUpDown1.Value;
			}
			RefreshPrice();
		}

		private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
			RefreshPrice();
		}

		public void RefreshPrice()
		{
			
		}

		private void OKbutton1_Click(object sender, EventArgs e)
		{
			if (CarListBox1.SelectedIndex == -1 || EmployeesListBox1.SelectedIndex == -1)
				throw new Exception("Заполните все пункты.");

			if (!EditMode) //добавление
			{
				if (ClientListBox2.SelectedIndex == -1)
					throw new Exception("Заполните все пункты.");

				using (NpgsqlConnection cn = new NpgsqlConnection(Connection.str))
				{
					cn.Open();
					string totalprice = PriceLabel.Text;
					string services = SerializeServices();

					NpgsqlCommand cmd1 = new NpgsqlCommand("insert into rental_table (start_date, return_date, car_id, client_id, rental_price, is_paid, employee_id, services) " +
						"VALUES ('" + StartDateTimePicker1.Value.ToString("yyyy-MM-dd") + "', '" + EndDateTimePicker2.Value.ToString("yyyy-MM-dd") + "', " + CarListBox1.SelectedValue.ToString() + ", " + ClientListBox2.SelectedValue.ToString() + ", " + totalprice + ", " + (IsPaidCheckBox1.Checked ? "true" : "false") + ", " + EmployeesListBox1.SelectedValue.ToString() + ", '" + services + "');", cn);
					cmd1.ExecuteNonQuery();
					cn.Close();
				}
			}
			else //обновление
			{
				using (NpgsqlConnection cn = new NpgsqlConnection(Connection.str))
				{
					cn.Open();
					string totalprice = PriceLabel.Text;
					string services = SerializeServices();

					NpgsqlCommand cmd1 = new NpgsqlCommand("update rental_table SET start_date='" + StartDateTimePicker1.Value.ToString("yyyy-MM-dd") +
						"', return_date='" + EndDateTimePicker2.Value.ToString("yyyy-MM-dd") + "', car_id='" + CarListBox1.SelectedValue.ToString() +
						"', rental_price=" + totalprice + ", is_paid=" + (IsPaidCheckBox1.Checked ? "true" : "false") +
						", employee_id=" + EmployeesListBox1.SelectedValue.ToString() + ", services='" + services + "');", cn);
					cmd1.ExecuteNonQuery();
					cn.Close();
				}
			}
		}

		public string SerializeServices()
		{
			if (dataGridView1.Rows.Count == 0)
				return "NULL";
			else
			{
				ServiceList list = new ServiceList();
				list.services = new List<Service>();
				foreach (DataGridViewRow row in dataGridView1.Rows)
				{
					list.services.Add(new Service(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString()));
				}
				return JsonConvert.SerializeObject(list);
			}
			
		}

		private void StartDateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			if (StartDateTimePicker1.Value.Date > EndDateTimePicker2.Value.Date)
				EndDateTimePicker2.Value = EndDateTimePicker2.Value.Date.AddDays(1);
			RefreshPrice();
		}
	}
}
