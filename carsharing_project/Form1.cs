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
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			String connectionString = "Server=localhost;Port=5432;User=postgres;Password=1;Database=cyberforum;";
			NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
			npgSqlConnection.Open();
			Console.WriteLine("Соединение с БД открыто");
			NpgsqlCommand npgSqlCommand = new NpgsqlCommand("SELECT * FROM example", npgSqlConnection);
			NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();
			npgSqlConnection.Close();
		}
	}
}
