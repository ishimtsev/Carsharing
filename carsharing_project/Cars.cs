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
    public partial class Cars : Form
    {
        public Cars()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
				dataGridView1.ClearSelection();
				dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
				dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
				contextMenuStrip1.Show(MousePosition);
			}
        }

        private void BindData()
        {
            dataGridView1.ClearSelection();
            try
			{
				using (NpgsqlConnection cn = new NpgsqlConnection(Connection.str))
				{
					string searchString = searchTextBox.Text;
					cn.Open();
					string parameters = string.Empty;
					if (searchString != string.Empty)
					{
						parameters = " WHERE \"name\" LIKE '%" + searchString + "%' OR \"reg_num\" LIKE '%" + searchString + "%' OR \"engine_num\" LIKE '%" + searchString + "%'";
					}
					NpgsqlCommand cmd = new NpgsqlCommand("select car_id as carID, \"name\" as Название, reg_num as \"Рег. номер\", \"engine_num\" as \"Номер двигателя\", EXTRACT(year from prod_year) as \"Год произодства\", mileage as Пробег, round(car_price) as \"Стоимость (руб)\", round(day_price) as \"Цена дня проката (руб)\", maintenance as \"Последнее ТО\", specials as Примечания, (select COUNT(*) from \"rental_table\" where rental_table.car_id = car_table.car_id) as \"Количество прокатов\", (select MAX(return_date) from \"rental_table\" where rental_table.car_id = car_table.car_id) as \"Последний прокат\" from car_table" + parameters, cn);
					NpgsqlDataReader reader = cmd.ExecuteReader();
					DataTable dt = new DataTable();
					dt.Load(reader);
					dataGridView1.DataSource = dt;
					dataGridView1.Columns[0].Visible = false;
					cn.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

        private void Employees_Search(object sender, EventArgs e)
        {
            BindData();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            BindData();
        }

		private void EditToolStripMenuItem_Click(object sender, EventArgs e)
		{
            AddCar form = new AddCar(dataGridView1.CurrentRow.Cells[0].Value.ToString(), dataGridView1.CurrentRow.Cells[1].Value.ToString(),
               dataGridView1.CurrentRow.Cells[2].Value.ToString(), dataGridView1.CurrentRow.Cells[3].Value.ToString(), dataGridView1.CurrentRow.Cells[4].Value.ToString(),
               dataGridView1.CurrentRow.Cells[5].Value.ToString(), dataGridView1.CurrentRow.Cells[6].Value.ToString(), dataGridView1.CurrentRow.Cells[7].Value.ToString(),
               dataGridView1.CurrentRow.Cells[8].Value.ToString(), dataGridView1.CurrentRow.Cells[9].Value.ToString());
            form.FormClosed += (s, args) => BindData();
            form.Show();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection cn = new NpgsqlConnection(Connection.str))
                {
                    using (NpgsqlCommand command = new NpgsqlCommand("DELETE FROM \"car_table\" WHERE (\"car_id\" = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "')", cn))
                    {
                        cn.Open();
                        command.ExecuteNonQuery();
                        cn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.StartsWith("Cannot delete or update a parent row: a foreign key constraint fails"))
                    MessageBox.Show("Нельзя удалить автомобиль, если у него имеются прокаты.");
                else
                    MessageBox.Show(ex.Message);
            }
            BindData();
        }

        private void addButton_Click(object sender, EventArgs e)
		{
			AddCar form = new AddCar();
			form.FormClosed += (s, args) => BindData();
			form.Show();
		}

		private void Cars_Load(object sender, EventArgs e)
		{
			BindData();
		}

        private void searchButton_Click(object sender, EventArgs e)
        {
            BindData();
        }
    }
}