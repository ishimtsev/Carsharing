using System;
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
using System.Globalization;

namespace carsharing_project
{
	public partial class AddRental : Form
	{
		public bool EditMode = false;
		public string carID = string.Empty;
		public string cliID = string.Empty;
		public string empID = string.Empty;
		public string rentID = string.Empty;
		int CarPrice = 0;
		int TotalPrice = 0;

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
			StartDateTimePicker1.Value = DateTime.ParseExact(start, "dd.MM.yyyy H:mm:ss", CultureInfo.InvariantCulture);
			EndDateTimePicker2.Value = DateTime.ParseExact(end, "dd.MM.yyyy H:mm:ss", CultureInfo.InvariantCulture);
        }

		private void AddRental_Load(object sender, EventArgs e)
		{
			dataGridView1.Columns.Add("Название", "Название");
			dataGridView1.Columns.Add("Описание", "Описание");
			dataGridView1.Columns.Add("Цена", "Цена");
			dataGridView1.Columns.Add("Количество", "Количество");
			dataGridView1.Columns.Add("Стоимость", "Стоимость");

			try
			{
				using (NpgsqlConnection cn = new NpgsqlConnection(Connection.str))
				{
					cn.Open();

					//получение списка клиентов
					NpgsqlCommand cmd1 = new NpgsqlCommand("select cli_id as cliID, fio|| ', ' ||passport as cli_name from client_table;", cn);
					NpgsqlDataReader reader1 = cmd1.ExecuteReader();
					DataTable dt1 = new DataTable();
					dt1.Load(reader1);
					ClientListBox2.DataSource = dt1;
					ClientListBox2.DisplayMember = "cli_name";
					ClientListBox2.ValueMember = "cliID";
					
    				//получение списка автомобилей
					NpgsqlCommand cmd2 = new NpgsqlCommand("select car_id as carID, \"name\"|| ', ' ||reg_num as car_name from car_table;", cn);
					NpgsqlDataReader reader2 = cmd2.ExecuteReader();
					DataTable dt2 = new DataTable();
					dt2.Load(reader2);

					CarListBox1.DataSource = dt2;
					CarListBox1.DisplayMember = "car_name";
					CarListBox1.ValueMember = "carID";

					//получение списка сотрудников
					NpgsqlCommand cmd3 = new NpgsqlCommand("select \"employee-position_table\".link_id as empID, fio|| ', ' ||passport as emp_name from \"employee-position_table\" join employee_table ON employee_table.emp_id=\"employee-position_table\".emp_id join position_table ON position_table.pos_id=\"employee-position_table\".pos_id WHERE position_table.\"name\"='Менеджер по работе с клиентами';", cn);
					NpgsqlDataReader reader3 = cmd3.ExecuteReader();
					DataTable dt3 = new DataTable();
					dt3.Load(reader3);

					EmployeesListBox1.DataSource = dt3;
					EmployeesListBox1.DisplayMember = "emp_name";
					EmployeesListBox1.ValueMember = "empID";

					if (EditMode)
					{
						//получение списка услуг
						NpgsqlCommand cmd4 = new NpgsqlCommand("select services from rental_table WHERE rent_id=" + rentID + ";", cn);
						string services = cmd4.ExecuteScalar().ToString();
						ServiceList list = JsonConvert.DeserializeObject<ServiceList>(services);
						if (list != null)
						{
							foreach (var service in list.services)
							{
								dataGridView1.Rows.Add(service.Name, service.Description, service.Price, service.Count, Convert.ToInt32(service.Price) * Convert.ToInt32(service.Count));
							}
						}

						for (int i = 0; i < dt1.Rows.Count; i++)
						{
							if (dt1.Rows[i][0].ToString() == cliID)
							{
								ClientListBox2.SelectedIndex = i;
								break;
							}
						}
						for (int i = 0; i < dt2.Rows.Count; i++)
						{
							if (dt2.Rows[i][0].ToString() == carID)
							{
								CarListBox1.SelectedIndex = i;
								break;
							}
						}
						for (int i = 0; i < dt3.Rows.Count; i++)
						{
							if (dt3.Rows[i][0].ToString() == empID)
							{
								EmployeesListBox1.SelectedIndex = i;
								break;
							}
						}
					}
					cn.Close();
				}
				RefreshPrice(false);
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
			RefreshPrice(false);
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
			RefreshPrice(false);
		}

		private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
			RefreshPrice(false);
		}

		public void RefreshPrice(bool carChanged)
		{
			try
			{
				if (carChanged && CarListBox1.SelectedValue.ToString() != "System.Data.DataRowView")
				{
					using (NpgsqlConnection cn = new NpgsqlConnection(Connection.str))
					{
						cn.Open();
						NpgsqlCommand cmd = new NpgsqlCommand("select round(day_price) from car_table where car_id = " + CarListBox1.SelectedValue.ToString() + ";", cn);
						CarPrice = Convert.ToInt32(cmd.ExecuteScalar());
						cn.Close();
					}
				}
			}
			catch (Exception er)
			{
				MessageBox.Show(er.Message);
			}

			TotalPrice = CarPrice * Convert.ToInt32(PeriodLabel.Text);
			if (dataGridView1.Rows.Count > 0)
			{
				foreach (DataGridViewRow row in dataGridView1.Rows)
				{
					TotalPrice += Convert.ToInt32(row.Cells[4].Value);
				}
			}
			PriceLabel.Text = TotalPrice.ToString();
		}

		private void OKbutton1_Click(object sender, EventArgs e)
		{
            try
            {
                if (CarListBox1.SelectedIndex == -1 || EmployeesListBox1.SelectedIndex == -1)
                    throw new Exception("Заполните все пункты.");
                if (dataGridView1.Rows.Count == 0)
                    throw new Exception("Добавьте и выберите услугу.");

                if (!EditMode) //добавление
                {
                    if (ClientListBox2.SelectedIndex == -1)
                        throw new Exception("Заполните все пункты.");

                    using (NpgsqlConnection cn = new NpgsqlConnection(Connection.str))
                    {
                        cn.Open();
                        string totalprice = TotalPrice.ToString();
                        string services = SerializeServices();

                        NpgsqlCommand cmd1 = new NpgsqlCommand("insert into rental_table (start_date, return_date, car_id, client_id, rental_price, is_paid, employee_id, services) " +
                            "VALUES ('" + StartDateTimePicker1.Value.ToString("yyyy-MM-dd") + "', '" + EndDateTimePicker2.Value.ToString("yyyy-MM-dd") + "', " + CarListBox1.SelectedValue.ToString() + ", " + ClientListBox2.SelectedValue.ToString() + ", " + totalprice + ", " + (IsPaidCheckBox1.Checked ? "true" : "false") + ", " + EmployeesListBox1.SelectedValue.ToString() + ", '" + services + "');", cn);
                        cmd1.ExecuteNonQuery();
                        cn.Close();
                    }
					Close();
                }
                else //обновление
                {
                    using (NpgsqlConnection cn = new NpgsqlConnection(Connection.str))
                    {
                        cn.Open();
                        string totalprice = TotalPrice.ToString();
                        string services = SerializeServices();

						NpgsqlCommand cmd1 = new NpgsqlCommand("update rental_table SET start_date='" + StartDateTimePicker1.Value.ToString("yyyy-MM-dd") +
							"', return_date='" + EndDateTimePicker2.Value.ToString("yyyy-MM-dd") + "', car_id='" + CarListBox1.SelectedValue.ToString() +
							"', rental_price=" + totalprice + ", is_paid=" + (IsPaidCheckBox1.Checked ? "true" : "false") +
							", employee_id=" + EmployeesListBox1.SelectedValue.ToString() + ", services='" + services + "' WHERE rental_table.rent_id=" + rentID + ";", cn);
                        cmd1.ExecuteNonQuery();
                        cn.Close();
                    }
					Close();
				}
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
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

			TimeSpan period = EndDateTimePicker2.Value.Date.AddDays(1) - StartDateTimePicker1.Value.Date;
			PeriodLabel.Text = period.Days.ToString();

			RefreshPrice(false);
		}

        private void CarListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
			RefreshPrice(true);
		}
	}
}
