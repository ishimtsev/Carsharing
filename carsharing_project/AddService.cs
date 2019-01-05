using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carsharing_project
{
	public partial class AddService : Form
	{
		public bool EditMode = false;

		public AddService()
		{
			InitializeComponent();
		}

		public AddService(string name, string description, string price, string count)
		{
			InitializeComponent();

			NameTextBox1.Text = name;
			DescrTextBox2.Text = description;
			PriceTextBox3.Text = price;
			CountNumericUpDown1.Value = Convert.ToInt32(count);
			EditMode = true;
		}

		private void AddService_Load(object sender, EventArgs e)
		{
			CountNumericUpDown1.Value = 1;
		}

		private void CountNumericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			if (CountNumericUpDown1.Value < 1)
				CountNumericUpDown1.Value = 1;
		}

		private void OKbutton1_Click(object sender, EventArgs e)
		{
			try
			{
				if (NameTextBox1.Text == "" || DescrTextBox2.Text == "" || PriceTextBox3.Text == "")
					throw new Exception("Заполните все поля.");
				if (!int.TryParse(PriceTextBox3.Text, out int price) || (price < 0))
					throw new Exception("Введён некорректный возраст.");

				if (EditMode)
				{
					DialogResult = DialogResult.OK;
				}
				else
				{
					DialogResult = DialogResult.OK;
				}
			}
			catch(Exception er)
			{
				MessageBox.Show(er.Message);
			}
		}
	}
}
