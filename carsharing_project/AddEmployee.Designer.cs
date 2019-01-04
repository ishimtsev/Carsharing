namespace carsharing_project
{
	partial class AddEmployee
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.ChooseRadioButton1 = new System.Windows.Forms.RadioButton();
			this.AddRadioButton2 = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.EmployeesListBox2 = new System.Windows.Forms.ListBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.phonetextBox5 = new System.Windows.Forms.TextBox();
			this.passporttextBox4 = new System.Windows.Forms.TextBox();
			this.agetextBox3 = new System.Windows.Forms.TextBox();
			this.addresstextBox2 = new System.Windows.Forms.TextBox();
			this.fiotextBox1 = new System.Windows.Forms.TextBox();
			this.SexComboBox1 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.OKbutton1 = new System.Windows.Forms.Button();
			this.PositionsListBox1 = new System.Windows.Forms.ListBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// ChooseRadioButton1
			// 
			this.ChooseRadioButton1.AutoSize = true;
			this.ChooseRadioButton1.Checked = true;
			this.ChooseRadioButton1.Location = new System.Drawing.Point(6, 21);
			this.ChooseRadioButton1.Name = "ChooseRadioButton1";
			this.ChooseRadioButton1.Size = new System.Drawing.Size(154, 21);
			this.ChooseRadioButton1.TabIndex = 0;
			this.ChooseRadioButton1.TabStop = true;
			this.ChooseRadioButton1.Text = "Выбрать из списка";
			this.ChooseRadioButton1.UseVisualStyleBackColor = true;
			// 
			// AddRadioButton2
			// 
			this.AddRadioButton2.AutoSize = true;
			this.AddRadioButton2.Location = new System.Drawing.Point(306, 21);
			this.AddRadioButton2.Name = "AddRadioButton2";
			this.AddRadioButton2.Size = new System.Drawing.Size(221, 21);
			this.AddRadioButton2.TabIndex = 0;
			this.AddRadioButton2.Text = "Добавить нового сотрудника";
			this.AddRadioButton2.UseVisualStyleBackColor = true;
			this.AddRadioButton2.CheckedChanged += new System.EventHandler(this.AddRadioButton2_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.EmployeesListBox2);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.ChooseRadioButton1);
			this.groupBox1.Controls.Add(this.AddRadioButton2);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(788, 397);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Сотрудник";
			// 
			// EmployeesListBox2
			// 
			this.EmployeesListBox2.FormattingEnabled = true;
			this.EmployeesListBox2.ItemHeight = 16;
			this.EmployeesListBox2.Location = new System.Drawing.Point(6, 48);
			this.EmployeesListBox2.Name = "EmployeesListBox2";
			this.EmployeesListBox2.Size = new System.Drawing.Size(271, 340);
			this.EmployeesListBox2.TabIndex = 6;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.phonetextBox5);
			this.groupBox2.Controls.Add(this.passporttextBox4);
			this.groupBox2.Controls.Add(this.agetextBox3);
			this.groupBox2.Controls.Add(this.addresstextBox2);
			this.groupBox2.Controls.Add(this.fiotextBox1);
			this.groupBox2.Controls.Add(this.SexComboBox1);
			this.groupBox2.Enabled = false;
			this.groupBox2.Location = new System.Drawing.Point(306, 48);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(475, 200);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Сотрудник";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 167);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(68, 17);
			this.label7.TabIndex = 2;
			this.label7.Text = "Телефон";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 138);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(144, 17);
			this.label6.TabIndex = 2;
			this.label6.Text = "Паспортные данные";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 110);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 17);
			this.label5.TabIndex = 2;
			this.label5.Text = "Возраст";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 80);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 17);
			this.label4.TabIndex = 2;
			this.label4.Text = "Пол";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 52);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Адрес";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "ФИО";
			// 
			// phonetextBox5
			// 
			this.phonetextBox5.Location = new System.Drawing.Point(166, 164);
			this.phonetextBox5.Name = "phonetextBox5";
			this.phonetextBox5.Size = new System.Drawing.Size(303, 22);
			this.phonetextBox5.TabIndex = 4;
			// 
			// passporttextBox4
			// 
			this.passporttextBox4.Location = new System.Drawing.Point(166, 135);
			this.passporttextBox4.Name = "passporttextBox4";
			this.passporttextBox4.Size = new System.Drawing.Size(303, 22);
			this.passporttextBox4.TabIndex = 4;
			// 
			// agetextBox3
			// 
			this.agetextBox3.Location = new System.Drawing.Point(166, 107);
			this.agetextBox3.Name = "agetextBox3";
			this.agetextBox3.Size = new System.Drawing.Size(303, 22);
			this.agetextBox3.TabIndex = 4;
			// 
			// addresstextBox2
			// 
			this.addresstextBox2.Location = new System.Drawing.Point(166, 49);
			this.addresstextBox2.Name = "addresstextBox2";
			this.addresstextBox2.Size = new System.Drawing.Size(303, 22);
			this.addresstextBox2.TabIndex = 4;
			// 
			// fiotextBox1
			// 
			this.fiotextBox1.Location = new System.Drawing.Point(166, 21);
			this.fiotextBox1.Name = "fiotextBox1";
			this.fiotextBox1.Size = new System.Drawing.Size(303, 22);
			this.fiotextBox1.TabIndex = 4;
			// 
			// SexComboBox1
			// 
			this.SexComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SexComboBox1.FormattingEnabled = true;
			this.SexComboBox1.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
			this.SexComboBox1.Location = new System.Drawing.Point(166, 77);
			this.SexComboBox1.Name = "SexComboBox1";
			this.SexComboBox1.Size = new System.Drawing.Size(303, 24);
			this.SexComboBox1.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(922, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Должность";
			// 
			// OKbutton1
			// 
			this.OKbutton1.Location = new System.Drawing.Point(484, 429);
			this.OKbutton1.Name = "OKbutton1";
			this.OKbutton1.Size = new System.Drawing.Size(135, 50);
			this.OKbutton1.TabIndex = 4;
			this.OKbutton1.Text = "OK";
			this.OKbutton1.UseVisualStyleBackColor = true;
			this.OKbutton1.Click += new System.EventHandler(this.OKbutton1_Click);
			// 
			// PositionsListBox1
			// 
			this.PositionsListBox1.FormattingEnabled = true;
			this.PositionsListBox1.ItemHeight = 16;
			this.PositionsListBox1.Location = new System.Drawing.Point(830, 33);
			this.PositionsListBox1.Name = "PositionsListBox1";
			this.PositionsListBox1.Size = new System.Drawing.Size(267, 372);
			this.PositionsListBox1.TabIndex = 6;
			// 
			// AddEmployee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1109, 491);
			this.Controls.Add(this.PositionsListBox1);
			this.Controls.Add(this.OKbutton1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.groupBox1);
			this.Name = "AddEmployee";
			this.Text = "Сотрудник";
			this.Load += new System.EventHandler(this.AddEmployee_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton ChooseRadioButton1;
		private System.Windows.Forms.RadioButton AddRadioButton2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox fiotextBox1;
		private System.Windows.Forms.ComboBox SexComboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox phonetextBox5;
		private System.Windows.Forms.TextBox passporttextBox4;
		private System.Windows.Forms.TextBox agetextBox3;
		private System.Windows.Forms.TextBox addresstextBox2;
		private System.Windows.Forms.Button OKbutton1;
		private System.Windows.Forms.ListBox EmployeesListBox2;
		private System.Windows.Forms.ListBox PositionsListBox1;
	}
}