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
	public partial class AddEmployee : Form
	{
		public AddEmployee()
		{
			InitializeComponent();
		}

		private void AddEmployee_Load(object sender, EventArgs e)
		{
			SexComboBox1.SelectedIndex = 0;

			using (NpgsqlConnection cn = new NpgsqlConnection(Connection.str))
			{
				cn.Open();
				//получение списка сотрудников
				NpgsqlCommand cmd1 = new NpgsqlCommand("select employee_table.emp_id as ID, fio|| ', ' ||passport as emp_name from \"employee-position_table\" join employee_table ON employee_table.emp_id=\"employee-position_table\".emp_id;", cn);
				NpgsqlDataReader reader1 = cmd1.ExecuteReader();
				DataTable dt1 = new DataTable();
				dt1.Load(reader1);

				//получение списка должностей
				NpgsqlCommand cmd2 = new NpgsqlCommand("select pos_id as ID, \"name\"|| ', ' ||oklad as pos_name from position_table;", cn);
				NpgsqlDataReader reader2 = cmd2.ExecuteReader();
				DataTable dt2 = new DataTable();
				dt2.Load(reader2);
				cn.Close();

				EmployeesListBox2.DataSource = dt1;
				EmployeesListBox2.DisplayMember = "emp_name";
				EmployeesListBox2.ValueMember = "ID";
				PositionsListBox1.DataSource = dt2;
				PositionsListBox1.DisplayMember = "pos_name";
				PositionsListBox1.ValueMember = "ID";
			}

		}

		private void OKbutton1_Click(object sender, EventArgs e)
		{
			try
			{
				if (AddRadioButton2.Checked) //если добавляем сотрудника
				{

				}
				//добавление связи сотрудник-должность
			}
			catch (Exception er)
			{
				MessageBox.Show(er.Message);
			}
		}

		private void AddRadioButton2_CheckedChanged(object sender, EventArgs e)
		{
			if (AddRadioButton2.Checked)
			{
				groupBox2.Enabled = true;
				EmployeesListBox2.Enabled = false;
			}
			else
			{
				groupBox2.Enabled = false;
				EmployeesListBox2.Enabled = true;
			}
		}
	}
}
