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
	public partial class Positions : Form
	{
		public Positions()
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
            using (NpgsqlConnection cn = new NpgsqlConnection(Connection.str))
            {
                string searchString = textBox1.Text;
                cn.Open();
                string parameters = string.Empty;
                if (searchString != string.Empty)
                {
                    parameters = " WHERE \"name\" LIKE '%" + searchString + "%' OR oklad LIKE '%" + searchString + "%' OR duty LIKE '%" + searchString + "%' OR requirements LIKE '%" + searchString + "%'";
                }

                NpgsqlCommand cmd = new NpgsqlCommand("select \"pos_id\" as ID, name as \"Название\", round(oklad) as \"Оклад (руб)\", Duty as \"Обязанности\", requirements as \"Требования\" from \"position_table\"" + parameters, cn);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Visible = false;
                cn.Close();
            }
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Hide();
            AddPosition form = new AddPosition();
            form.NameTB.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            form.zpTB.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            form.obyazTB.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            form.reqTB.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            form.EditMode = true;
            form.id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            form.FormClosed += (s, args) => BindData();
            form.Show();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection cn = new NpgsqlConnection(Connection.str))
                {
                    using (NpgsqlCommand command = new NpgsqlCommand("DELETE FROM position_table WHERE (pos_id = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "')", cn))
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
                    MessageBox.Show("Нельзя удалить должность, если на ней имеются работники.");
                else
                    MessageBox.Show(ex.Message);
            }
            BindData();
        }

        private void AddClientButton1_Click(object sender, EventArgs e)
        {
            //Hide();
            AddPosition form = new AddPosition();
            form.FormClosed += (s, args) => BindData();
            form.Show();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Positions_Load(object sender, EventArgs e)
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
			}
		}
	}
}
