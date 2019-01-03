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
		public bool EditMode = false;
		public string empID = string.Empty;
		public string posID = string.Empty;

		public AddEmployee()
		{
			InitializeComponent();
			SexComboBox1.SelectedIndex = 0;
		}

		public AddEmployee(string emp_id, string pos_id, string fio, string address, string sex, string age, string passport, string phone)
		{
			InitializeComponent();
			EditMode = true;
			empID = emp_id;
			posID = pos_id;
			fiotextBox1.Text = fio;
			addresstextBox2.Text = address;
			if (sex == "Мужской")
				SexComboBox1.SelectedIndex = 0;
			else
				SexComboBox1.SelectedIndex = 1;
			agetextBox3.Text = age;
			passporttextBox4.Text = passport;
			phonetextBox5.Text = phone;

			AddRadioButton2.Checked = true;
			AddRadioButton2.Enabled = false;
			ChooseRadioButton1.Enabled = false;
			EmployeesListBox2.Enabled = false;
		}

		private void AddEmployee_Load(object sender, EventArgs e)
		{
			using (NpgsqlConnection cn = new NpgsqlConnection(Connection.str))
			{
				cn.Open();

				if (!EditMode)
				{
					//получение списка сотрудников
					NpgsqlCommand cmd1 = new NpgsqlCommand("select employee_table.emp_id as ID, fio|| ', ' ||passport as emp_name from \"employee-position_table\" join employee_table ON employee_table.emp_id=\"employee-position_table\".emp_id;", cn);
					NpgsqlDataReader reader1 = cmd1.ExecuteReader();
					DataTable dt1 = new DataTable();
					dt1.Load(reader1);
					EmployeesListBox2.DataSource = dt1;
					EmployeesListBox2.DisplayMember = "emp_name";
					EmployeesListBox2.ValueMember = "ID";
				}

				//получение списка должностей
				NpgsqlCommand cmd2 = new NpgsqlCommand("select pos_id as ID, \"name\"|| ', ' ||oklad as pos_name from position_table;", cn);
				NpgsqlDataReader reader2 = cmd2.ExecuteReader();
				DataTable dt2 = new DataTable();
				dt2.Load(reader2);

				PositionsListBox1.DataSource = dt2;
				PositionsListBox1.DisplayMember = "pos_name";
				PositionsListBox1.ValueMember = "ID";

				cn.Close();
			}
		}

		private void OKbutton1_Click(object sender, EventArgs e)
		{
			try
			{
				if (!EditMode)
				{
					if (PositionsListBox1.SelectedIndex == -1)
						throw new Exception("Не выбрана должность.");

					if (AddRadioButton2.Checked) //если добавляем нового сотрудника
					{
						if (fiotextBox1.Text == "" || addresstextBox2.Text == "" || agetextBox3.Text == "" || passporttextBox4.Text == "" || phonetextBox5.Text == "")
							throw new Exception("Заполните все поля.");
						if (!int.TryParse(agetextBox3.Text, out int age) || (age < 18) || (age > 100))
							throw new Exception("Введён некорректный возраст.");

						using (NpgsqlConnection cn = new NpgsqlConnection(Connection.str))
						{
							cn.Open();
							NpgsqlCommand cmd1 = new NpgsqlCommand("insert into employee_table (fio, address, sex, age, passport, phone) " +
								"VALUES ('" + fiotextBox1.Text + "', '" + addresstextBox2.Text + "', '" + (SexComboBox1.SelectedIndex == 0 ? "false" : "true") + "', '" + agetextBox3.Text + "', '" + passporttextBox4.Text + "', '" + phonetextBox5.Text + "');", cn);
							cmd1.ExecuteNonQuery();

							NpgsqlCommand cmd2 = new NpgsqlCommand("select max(emp_id) from employee_table", cn);
							empID = cmd2.ExecuteScalar().ToString();

							cn.Close();
						}
					}
					else //если выбираем существующего сотрудника
					{
						if (EmployeesListBox2.SelectedIndex == -1)
							throw new Exception("Не выбран сотрудник.");
						empID = EmployeesListBox2.SelectedValue.ToString();
					}

					//добавление связи сотрудник-должность
					using (NpgsqlConnection cn = new NpgsqlConnection(Connection.str))
					{
						cn.Open();
						NpgsqlCommand cmd = new NpgsqlCommand("insert into \"employee-position_table\" (emp_id, pos_id) VALUES (" + empID + ", " + PositionsListBox1.SelectedValue + ");", cn);
						cmd.ExecuteNonQuery();
						cn.Close();
					}
				}
				else //если редактируем сотрудника
				{
					using (NpgsqlConnection cn = new NpgsqlConnection(Connection.str))
					{

					}


				}
				Close();
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
