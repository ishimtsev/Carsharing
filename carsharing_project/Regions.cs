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

namespace carsharing_project
{
	public partial class Regions : Form
	{
		public Regions()
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

		private void Regions_Load(object sender, EventArgs e)
		{

		}

		private void BindData()
		{
			dataGridView1.ClearSelection();
			try
			{
				using (NpgsqlConnection cn = new NpgsqlConnection(Connection.str))
				{
					string searchString = SearchTextBox.Text;
					cn.Open();
					string parameters = string.Empty;
					if (searchString != string.Empty)
					{
						parameters = " WHERE \"name\" LIKE '%" + searchString + "%'";
					}

					NpgsqlCommand cmd = new NpgsqlCommand("select reg_id AS regID, \"name\" as Название, region as Область FROM region_table" + parameters, cn);
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

		private void EditToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AddRegion form = new AddRegion(dataGridView1.CurrentRow.Cells[0].Value.ToString(), dataGridView1.CurrentRow.Cells[1].Value.ToString(),
				dataGridView1.CurrentRow.Cells[2].Value.ToString());
			form.FormClosed += (s, args) => BindData();
			form.Show();
		}

		private void AddEmployeeButton_Click(object sender, EventArgs e)
		{
			AddRegion form = new AddRegion();
			form.FormClosed += (s, args) => BindData();
			form.Show();
		}

		private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				using (NpgsqlConnection cn = new NpgsqlConnection(Connection.str))
				{
					NpgsqlCommand cmd = new NpgsqlCommand("delete from region_table WHERE reg_id=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + ";", cn);
					cn.Open();
					cmd.ExecuteNonQuery();
					cn.Close();
				}
			}
			catch (Exception er)
			{
				MessageBox.Show(er.Message);
			}
			BindData();
		}
	}
}