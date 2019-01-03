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
	public partial class Form1 : Form
	{
        public static String connectionString = "Server=localhost;Port=5432;User=postgres;Password=240398;Database=SUBD;";
        public static NpgsqlConnection connection = new NpgsqlConnection(connectionString);

        public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			String connectionString = "Server=localhost;Port=5432;User=postgres;Password=240398;Database=SUBD;";
			NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
			npgSqlConnection.Open();
			Console.WriteLine("Соединение с БД открыто");
			NpgsqlCommand npgSqlCommand = new NpgsqlCommand("SELECT * FROM example", npgSqlConnection);
			NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();
			npgSqlConnection.Close();
		}

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Clients clients = new Clients();
            clients.FormClosed += (s, args) => Show();
            clients.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Workers workers = new Workers();
            workers.FormClosed += (s, args) => Show();
            workers.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Doljnost doljnost = new Doljnost();
            doljnost.FormClosed += (s, args) => Show();
            doljnost.Show();
        }
    }
}
