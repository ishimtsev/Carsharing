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
            BindData(string.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            NewClient newclient = new NewClient();
            newclient.FormClosed += (s, args) => Show();
            newclient.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                dataGridView1.ClearSelection();
                BindData(textBox1.Text);
            }
            else
                BindData(string.Empty);
        }

        private void BindData(string searchString)
        {
            using (NpgsqlConnection cn = carsharing_project.Form1.connection)
            {
                cn.Open();
                string parameters = string.Empty;
                if (searchString != string.Empty)
                {
                    parameters = " WHERE fio LIKE '%" + searchString + "%' OR sex LIKE '%" + searchString + "%' OR birth LIKE '%" + searchString + "%' OR address LIKE '%" + searchString + "%' OR phone LIKE '%" + searchString + "%' OR passport LIKE '%" + searchString + "%'";
                }

                NpgsqlCommand cmd = new NpgsqlCommand("select cli_id as 'ID', fio as 'ФИО', sex as 'Пол', birth as 'Дата рождения', address as 'Адрес', phone as 'Телефон', passport as 'Паспортные данные' from client_table" + parameters, cn);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Visible = false;
                cn.Close();
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
            }
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewClient form = new NewClient();
            //заполнение формы данными
            form.fioTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            form.addressTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            form.phoneTextBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            form.EditMode = true;
            form.id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            form.FormClosed += (s, args) => BindData(string.Empty);
            form.Show();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection cn = carsharing_project.Form1.connection)
                {
                    using (NpgsqlCommand command = new NpgsqlCommand($"DELETE FROM `client_table` WHERE (`cli_id` = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "')", cn))
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
                    MessageBox.Show("Нельзя удалить клиента, если у него имеются зафиксированные прокаты.");
                else
                    MessageBox.Show(ex.Message);
            }
            BindData(string.Empty);
        }
    }
}
