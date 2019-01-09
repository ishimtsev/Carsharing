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
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                BindData();
        }

        private void BindData()
        {
			dataGridView1.ClearSelection();
			try
			{
				using (NpgsqlConnection cn = new NpgsqlConnection(Connection.str))
				{
					string searchString = textBox1.Text;
					cn.Open();
					string parameters = string.Empty;
					if (searchString != string.Empty)
					{
						parameters = " WHERE fio LIKE '%" + searchString + "%' OR address LIKE '%" + searchString + "%' OR phone LIKE '%" + searchString + "%' OR passport LIKE '%" + searchString + "%'";
					}

					NpgsqlCommand cmd = new NpgsqlCommand("select \"cli_id\" as ID, fio as ФИО, (case when sex IS false then 'Мужской' else 'Женский' end) as Пол, birth as \"Дата рождения\", address as Адрес, phone as Телефон, passport as \"Паспортные данные\" from client_table" + parameters, cn);
					NpgsqlDataReader reader = cmd.ExecuteReader();
					DataTable dt = new DataTable();
					dt.Load(reader);
					dataGridView1.DataSource = dt;
					dataGridView1.Columns[0].Visible = false;
					cn.Close();
				}
			}
			catch (Exception er)
			{
				MessageBox.Show(er.Message);
			}
		}

		private void EditToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
            Hide();
            AddClient form = new AddClient();
            form.fioTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            form.sexBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            form.birthPicker.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            form.addressTextBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            form.phoneTextBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            form.passTextBox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();


            form.EditMode = true;
            form.id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            form.FormClosed += (s, args) => BindData();
			form.Show();
		}

		private void DeleteToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			try
			{
                using (NpgsqlConnection cn = new NpgsqlConnection(Connection.str))
                {
					using (NpgsqlCommand command = new NpgsqlCommand("DELETE FROM client_table WHERE (cli_id = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "')", cn))
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
					MessageBox.Show("Нельзя удалить клиента, если у него имеются прокаты.");
				else
					MessageBox.Show(ex.Message);
			}
			BindData();
		}

		private void dataGridView1_CellMouseDown_1(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
			{
				dataGridView1.ClearSelection();
				dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
				dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
				contextMenuStrip1.Show(MousePosition);
			}
		}

		private void AddClientButton1_Click(object sender, EventArgs e)
		{
			//Hide();
			AddClient form = new AddClient();
			form.FormClosed += (s, args) => BindData();
			form.Show();
		}
	}
}
