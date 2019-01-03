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
			form.Show();
		}
	}
}
