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
	public partial class MenuForm : Form
	{
		//public static string str = "Server=localhost;Port=5432;User Id=postgres;Password=qwe123;Database=carsharing;";
		//public static NpgsqlConnection con = new NpgsqlConnection(str);

		public MenuForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//проверка соединения
			try
			{
				using (NpgsqlConnection cn = new NpgsqlConnection(Connection.str))
				{
					cn.Open();
					cn.Close();
				}
			}
			catch (Exception er)
			{
				MessageBox.Show("Нет соединения с базой данных.");
				Close();
				//Application.Exit();
			}
		}

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Clients form = new Clients();
			form.FormClosed += (s, args) => Show();
			form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
			Employees form = new Employees();
            form.FormClosed += (s, args) => Show();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Hide();
            //Doljnost doljnost = new Doljnost();
            //doljnost.FormClosed += (s, args) => Show();
            //doljnost.Show();
        }

		private void CarsButton3_Click(object sender, EventArgs e)
		{
			Hide();
			Cars form = new Cars();
			form.FormClosed += (s, args) => Show();
			form.Show();
		}

		private void RentalButton3_Click(object sender, EventArgs e)
		{
			Hide();
			Rental form = new Rental();
			form.FormClosed += (s, args) => Show();
			form.Show();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
