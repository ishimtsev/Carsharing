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
	public partial class MostPopularRegion : Form
	{
		public MostPopularRegion()
		{
			InitializeComponent();
		}

		private void MostPopularRegion_Load(object sender, EventArgs e)
		{
			try
			{
				using (NpgsqlConnection cn = new NpgsqlConnection(Connection.str))
				{
					cn.Open();
					NpgsqlCommand cmd1 = new NpgsqlCommand("select tmp.name as Область, count(tmp.track_id) as \"Количество точек\" from (select * from rental_table JOIN region_table ON region_table.reg_id=rental_table.region JOIN track_table ON track_table.rent_id=rental_table.rent_id where ST_Contains(region_table.region, track_table.point)=true) as tmp GROUP BY tmp.reg_id, tmp.name ORDER BY \"Количество точек\" DESC", cn);
					NpgsqlDataReader reader1 = cmd1.ExecuteReader();
					DataTable dt1 = new DataTable();
					dt1.Load(reader1);
					dataGridView1.DataSource = dt1;
					cn.Close();
				}
			}
			catch (Exception er)
			{
				MessageBox.Show(er.Message);
			}
		}
	}
}
