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

namespace carsharing_project
{
	public partial class Rental : Form
	{
		public Rental()
		{
			InitializeComponent();
		}

		private void AddRentalButton_Click(object sender, EventArgs e)
		{
			AddRental form = new AddRental();
			form.FormClosed += (s, args) => BindData();
			form.Show();
		}

		private void EditToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AddRental form = new AddRental(dataGridView1.CurrentRow.Cells[0].Value.ToString(), dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString(), dataGridView1.CurrentRow.Cells[3].Value.ToString(), dataGridView1.CurrentRow.Cells[6].Value.ToString(), dataGridView1.CurrentRow.Cells[7].Value.ToString(), dataGridView1.CurrentRow.Cells[11].Value.ToString());
			form.FormClosed += (s, args) => BindData();
			form.Show();
		}

		private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
            using (NpgsqlConnection cn = new NpgsqlConnection(Connection.str))
            {
                cn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM rental_table WHERE rent_id = " + dataGridView1.CurrentRow.Cells[0].Value.ToString() + ";");
                NpgsqlDataReader reader = cmd.ExecuteReader();

                cn.Close();
            }
            BindData();
        }

		private void Rental_Load(object sender, EventArgs e)
		{
			BindData();
		}

		private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
			{
				dataGridView1.ClearSelection();
				dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
				dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
				contextMenuStrip1.Show(MousePosition);
				if (dataGridView1.CurrentRow.Cells[11].Value.ToString() == "Нет")
					PaidToolStripMenuItem.Enabled = true;
				else
					PaidToolStripMenuItem.Enabled = false;
			}
		}

		private void BindData()
		{
			dataGridView1.ClearSelection();
			try
			{
				using (NpgsqlConnection cn = new NpgsqlConnection(Connection.str))
				{
					cn.Open();
					string searchString = SearchTextBox.Text;
					string parameters = string.Empty;
                    if (searchString != string.Empty)
                    {
                        parameters = " WHERE (car_table.name LIKE '%" + searchString + "%' OR client_table.fio LIKE '%" + searchString + "%' OR employee_table.fio LIKE '%" + searchString + "%') ";
                        if (FromPeriodCheckBox1.Checked) parameters += " AND ";
                    }
                    string sql = "SELECT rental_table.rent_id AS rentID, rental_table.car_id AS carID, rental_table.employee_id AS empID, rental_table.client_id AS cliID, car_table.name AS Автомобиль, " +
                        "client_table.fio AS Клиент, rental_table.start_date AS \"Начало проката\", rental_table.return_date AS \"Окончание проката\", rental_table.return_date-rental_table.start_date+1 AS \"Период (дней)\", " +
                        "round(rental_table.rental_price) AS \"Цена (руб)\", employee_table.fio AS Менеджер, (case when rental_table.is_paid IS true then 'Да' else 'Нет' end) as Оплачен FROM rental_table JOIN client_table ON client_table.cli_id=rental_table.client_id " +
                        "JOIN car_table ON car_table.car_id=rental_table.car_id LEFT JOIN \"employee-position_table\" ON \"employee-position_table\".link_id=rental_table.employee_id " +
                        "JOIN employee_table ON employee_table.emp_id=\"employee-position_table\".emp_id" + parameters;
                    if (searchString == string.Empty && FromPeriodCheckBox1.Checked) sql += " WHERE ";
                    if (FromPeriodCheckBox1.Checked)
                    {
                        sql += " start_date >= '" + StartDateTimePicker1.Value.Year + "-" + StartDateTimePicker1.Value.Month + "-" + StartDateTimePicker1.Value.Day + "'";
                        sql += " AND (return_date <= '" + EndDateTimePicker2.Value.Year + "-" + EndDateTimePicker2.Value.Month + "-" + EndDateTimePicker2.Value.Day + "')";
                    }

                    NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
					NpgsqlDataReader reader = cmd.ExecuteReader();
					DataTable dt = new DataTable();
					dt.Load(reader);
					dataGridView1.DataSource = dt;
					dataGridView1.Columns[0].Visible = false;
					dataGridView1.Columns[1].Visible = false;
					dataGridView1.Columns[2].Visible = false;
					dataGridView1.Columns[3].Visible = false;
					cn.Close();
				}
			}
			catch (Exception er)
			{
				MessageBox.Show(er.Message);
			}
		}

		private void PaidToolStripMenuItem_Click(object sender, EventArgs e)
		{
            try
			{
				using (NpgsqlConnection cn = new NpgsqlConnection(Connection.str))
				{
					cn.Open();

					using (NpgsqlCommand command = new NpgsqlCommand("UPDATE rental_table SET is_paid = true WHERE (rent_id = " + dataGridView1.CurrentRow.Cells[0].Value.ToString() + ");", cn))
					{
						command.ExecuteNonQuery();
					}
					cn.Close();
				}
			}
			catch (Exception er)
			{
				MessageBox.Show(er.Message);
			}
			BindData();
        }

		private void StartDateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			if (StartDateTimePicker1.Value.Date > EndDateTimePicker2.Value.Date)
				EndDateTimePicker2.Value = EndDateTimePicker2.Value.Date.AddDays(1);
		}

		private void FromPeriodCheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (FromPeriodCheckBox1.Checked)
			{
				StartDateTimePicker1.Enabled = true;
				EndDateTimePicker2.Enabled = true;
			}
			else
			{
				StartDateTimePicker1.Enabled = false;
				EndDateTimePicker2.Enabled = false;
			}
		}

        private void SearchButton_Click(object sender, EventArgs e)
        {
            BindData();
        }
    }
}
