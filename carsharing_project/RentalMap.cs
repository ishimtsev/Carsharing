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
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;

namespace carsharing_project
{
	public partial class RentalMap : Form
	{
		public string rentID = string.Empty;
		public string regID = string.Empty;
		GMap.NET.WindowsForms.GMapOverlay overlay;

		public RentalMap(string rentid)
		{
			InitializeComponent();
			rentID = rentid;
		}

		private void RentalMap_Load(object sender, EventArgs e)
		{
			gmap.MapProvider = GMap.NET.MapProviders.YandexMapProvider.Instance;
			GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
			gmap.DragButton = MouseButtons.Left;
			gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
			gmap.ShowCenter = false;
			gmap.Zoom = 12;
			//gmap.SetPositionByKeywords("Tyumen, Russia");
			//57.142766, 65.542615
			gmap.Position = new GMap.NET.PointLatLng(57.142766, 65.542615);

			overlay = new GMap.NET.WindowsForms.GMapOverlay("overlay");
			gmap.Overlays.Add(overlay);
		}

		public void ClearMap()
		{
			overlay.Markers.Clear();
			overlay.Polygons.Clear();
			overlay.Routes.Clear();

			label1.Visible = false;
			DistanceLabel.Visible = false;
		}

		private void IsInRegionutton3_Click(object sender, EventArgs e)
		{
			try
			{
				using (NpgsqlConnection cn = new NpgsqlConnection(Connection.str))
				{
					cn.Open();
					NpgsqlCommand cmd = new NpgsqlCommand("select ST_Contains((select region_table.region from region_table where region_table.reg_id=(select rental_table.region from rental_table where rental_table.rent_id=" + rentID + ")), (select point from track_table where rent_id=" + rentID + " ORDER BY track_time DESC LIMIT 1))", cn);
					string distance = cmd.ExecuteScalar().ToString();
					if (distance == "True")
						MessageBox.Show("Автомобиль находится внутри своей области.");
					else
						MessageBox.Show("Автомобиль находится за границей своей области.");
					cn.Close();

				}
			}
			catch (Exception er)
			{
				MessageBox.Show(er.Message);
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			MostPopularRegion form = new MostPopularRegion();
			form.Show();
		}

		public double[] GetPoints(string input)
		{
			input= input.Remove(input.Length - 1).Replace("POINT(", "").Replace(",", "").Replace(".", ",");
			string[] points = input.Split(' ');
			double[] result = { Convert.ToDouble(points[1]), Convert.ToDouble(points[0]) };
			return result;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			try
			{
				using (NpgsqlConnection cn = new NpgsqlConnection(Connection.str))
				{
					cn.Open();

					//получение области
					NpgsqlCommand cmd2 = new NpgsqlCommand("select ST_AsText((points).geom) from (select ST_DumpPoints(region_table.region) as points from region_table where region_table.reg_id=(select rental_table.region from rental_table where rental_table.rent_id=" + rentID + ")) as tmp", cn);
					NpgsqlDataReader reader2 = cmd2.ExecuteReader();
					DataTable dt2 = new DataTable();
					dt2.Load(reader2);

					List<PointLatLng> polyPoints = new List<PointLatLng>();
					for (int i = 0; i < dt2.Rows.Count; i++)
					{
						double[] tempPoints2 = GetPoints(dt2.Rows[i][0].ToString());
						polyPoints.Add(new PointLatLng(tempPoints2[0], tempPoints2[1]));
					}
					GMapPolygon polygon = new GMapPolygon(polyPoints, "polygon");
					polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
					polygon.Stroke = new Pen(Color.Red, 1);
					overlay.Polygons.Add(polygon);

					//получение текущего положения автомобиля
					NpgsqlCommand cmd1 = new NpgsqlCommand("select ST_AsText(point) from track_table where rent_id=" + rentID + " ORDER BY track_time DESC LIMIT 1", cn);
					var temp = cmd1.ExecuteScalar();
					if (temp == null)
						throw new Exception("У этого автомобиля ещё нет трека.");

					double[] points1 = GetPoints(temp.ToString());
					GMapMarker location = new GMarkerGoogle(new PointLatLng(points1[0], points1[1]), GMarkerGoogleType.red);
					location.ToolTipText = "Автомобиль здесь";
					overlay.Markers.Add(location);

					//получение трека
					NpgsqlCommand cmd3 = new NpgsqlCommand("select ST_AsText(point) from track_table where rent_id=" + rentID, cn);
					NpgsqlDataReader reader3 = cmd3.ExecuteReader();
					DataTable dt3 = new DataTable();
					dt3.Load(reader3);

					List<PointLatLng> trackPoints = new List<PointLatLng>();
					for (int i = 0; i < dt3.Rows.Count; i++)
					{
						double[] tempPoints3 = GetPoints(dt3.Rows[i][0].ToString());
						trackPoints.Add(new PointLatLng(tempPoints3[0], tempPoints3[1]));
					}
					GMapRoute route = new GMapRoute(trackPoints, "route");
					route.Stroke = new Pen(Color.Red, 3);
					overlay.Routes.Add(route);

					//получение длины трека
					NpgsqlCommand cmd4 = new NpgsqlCommand("select ST_Length(ST_MakeLine(tmp.point ORDER BY tmp.track_time)) from (select * from track_table where rent_id=" + rentID + ") as tmp", cn);
					string len = cmd4.ExecuteScalar().ToString();
					len = len.Replace(".", ",");
					DistanceLabel.Text = len + " км";
					label1.Visible = true;
					DistanceLabel.Visible = true;

					cn.Close();

				}
			}
			catch (Exception er)
			{
				MessageBox.Show(er.Message);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			ClearMap();
		}
	}
}
