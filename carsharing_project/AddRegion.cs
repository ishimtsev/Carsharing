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
	public partial class AddRegion : Form
	{
		public bool EditMode;
		public string id;

		public AddRegion()
		{
			InitializeComponent();
			EditMode = false;
		}

		public AddRegion(string regID, string name, string points)
		{
			InitializeComponent();
			EditMode = true;
			id = regID;
			NametextBox1.Text = name;
			PointstextBox2.Text = points;
		}

		private void OKbutton1_Click(object sender, EventArgs e)
		{
			try
			{
				if (NametextBox1.Text == string.Empty)
					throw new Exception("Не задано название.");
				if (PointstextBox2.Text == string.Empty)
					throw new Exception("Не заданы точки.");

				///////////////////////////////////////////////////////////////////////////////////////
				//преобразование точек
				string points = string.Empty;

				using (NpgsqlConnection cn = new NpgsqlConnection(Connection.str))
				{
					cn.Open();
					if (EditMode)
					{
						using (NpgsqlCommand command = new NpgsqlCommand($"UPDATE region_table SET name = '" +
						 NametextBox1.Text + "', region = '" + points + "' WHERE (reg_id = '" + id + "')", cn))
						{
							command.ExecuteNonQuery();
							cn.Close();
							Close();
						}
					}
					else
					{
						using (NpgsqlCommand command = new NpgsqlCommand($"INSERT INTO region_table (\"name\", region) " +
						"VALUES ('" + NametextBox1.Text + "', '" + points + "')", cn))
						{
							command.ExecuteNonQuery();
							cn.Close();
							Close();
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
