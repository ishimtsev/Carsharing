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
	public partial class Employees : Form
	{
		public Employees()
		{
			InitializeComponent();
		}

		private void AddEmployeeButton_Click(object sender, EventArgs e)
		{
			AddEmployee form = new AddEmployee();
			form.FormClosed += (s, args) => BindData();
			form.Show();
		}

		private void PositionsButton_Click(object sender, EventArgs e)
		{
			Positions form = new Positions();
			form.FormClosed += (s, args) => BindData();
			form.Show();
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
			AddEmployee form = new AddEmployee(dataGridView1.CurrentRow.Cells[0].Value.ToString(), dataGridView1.CurrentRow.Cells[1].Value.ToString(),
				dataGridView1.CurrentRow.Cells[2].Value.ToString(), dataGridView1.CurrentRow.Cells[3].Value.ToString(), dataGridView1.CurrentRow.Cells[4].Value.ToString(),
				dataGridView1.CurrentRow.Cells[5].Value.ToString(), dataGridView1.CurrentRow.Cells[6].Value.ToString(), dataGridView1.CurrentRow.Cells[7].Value.ToString(),
				dataGridView1.CurrentRow.Cells[8].Value.ToString());
			form.FormClosed += (s, args) => BindData();
			form.Show();
		}
		private void BindData()
		{
			dataGridView1.ClearSelection();
			using (NpgsqlConnection cn = new NpgsqlConnection(Connection.str))
			{
				string searchString = SearchTextBox.Text;
				cn.Open();
				string parameters = string.Empty;
				if (searchString != string.Empty)
				{
					parameters = " WHERE fio LIKE '%" + searchString + "%' OR sex LIKE '%" + searchString + "%' OR birth LIKE '%" + searchString + "%' OR address LIKE '%" + searchString + "%' OR phone LIKE '%" + searchString + "%' OR passport LIKE '%" + searchString + "%'";
				}

				NpgsqlCommand cmd = new NpgsqlCommand("select link_id, \"employee-position_table\".emp_id, \"employee-position_table\".pos_id, fio as ФИО, address as Адрес, (case when sex IS false then 'Мужской' else 'Женский' end) as Пол, age as Возраст, passport as \"Паспортные данные\", phone as Телефон, "+"\"name\" as Должность, oklad as Оклад FROM \"employee-position_table\" " +
					"JOIN employee_table ON employee_table.emp_id = \"employee-position_table\".emp_id JOIN position_table ON position_table.pos_id = \"employee-position_table\".pos_id" + parameters, cn);
				NpgsqlDataReader reader = cmd.ExecuteReader();
				DataTable dt = new DataTable();
				dt.Load(reader);
				dataGridView1.DataSource = dt;
				dataGridView1.Columns[0].Visible = false;
				dataGridView1.Columns[1].Visible = false;
				dataGridView1.Columns[2].Visible = false;
				cn.Close();
			}
		}

		private void SearchButton_Click(object sender, EventArgs e)
		{
			BindData();
		}

		private void Employees_Load(object sender, EventArgs e)
		{
			BindData();
		}
	}
}
