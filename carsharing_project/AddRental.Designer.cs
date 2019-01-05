namespace carsharing_project
{
	partial class AddRental
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
			this.components = new System.ComponentModel.Container();
			this.CarListBox1 = new System.Windows.Forms.ListBox();
			this.ClientListBox2 = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.StartDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.EndDateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.IsPaidCheckBox1 = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.OKbutton1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.PeriodLabel = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.PriceLabel = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.EmployeesListBox1 = new System.Windows.Forms.ListBox();
			this.label9 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// CarListBox1
			// 
			this.CarListBox1.FormattingEnabled = true;
			this.CarListBox1.ItemHeight = 16;
			this.CarListBox1.Location = new System.Drawing.Point(12, 29);
			this.CarListBox1.Name = "CarListBox1";
			this.CarListBox1.Size = new System.Drawing.Size(325, 292);
			this.CarListBox1.TabIndex = 0;
			// 
			// ClientListBox2
			// 
			this.ClientListBox2.FormattingEnabled = true;
			this.ClientListBox2.ItemHeight = 16;
			this.ClientListBox2.Location = new System.Drawing.Point(343, 29);
			this.ClientListBox2.Name = "ClientListBox2";
			this.ClientListBox2.Size = new System.Drawing.Size(330, 292);
			this.ClientListBox2.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(126, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Автомобиль";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(483, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Клиент";
			// 
			// StartDateTimePicker1
			// 
			this.StartDateTimePicker1.Location = new System.Drawing.Point(189, 21);
			this.StartDateTimePicker1.Name = "StartDateTimePicker1";
			this.StartDateTimePicker1.Size = new System.Drawing.Size(271, 22);
			this.StartDateTimePicker1.TabIndex = 2;
			this.StartDateTimePicker1.ValueChanged += new System.EventHandler(this.StartDateTimePicker1_ValueChanged);
			// 
			// EndDateTimePicker2
			// 
			this.EndDateTimePicker2.Location = new System.Drawing.Point(189, 49);
			this.EndDateTimePicker2.Name = "EndDateTimePicker2";
			this.EndDateTimePicker2.Size = new System.Drawing.Size(271, 22);
			this.EndDateTimePicker2.TabIndex = 2;
			this.EndDateTimePicker2.ValueChanged += new System.EventHandler(this.StartDateTimePicker1_ValueChanged);
			// 
			// IsPaidCheckBox1
			// 
			this.IsPaidCheckBox1.AutoSize = true;
			this.IsPaidCheckBox1.Location = new System.Drawing.Point(190, 127);
			this.IsPaidCheckBox1.Name = "IsPaidCheckBox1";
			this.IsPaidCheckBox1.Size = new System.Drawing.Size(89, 21);
			this.IsPaidCheckBox1.TabIndex = 3;
			this.IsPaidCheckBox1.Text = "Оплачен";
			this.IsPaidCheckBox1.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 26);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(116, 17);
			this.label4.TabIndex = 1;
			this.label4.Text = "Начало проката";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 54);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(140, 17);
			this.label5.TabIndex = 1;
			this.label5.Text = "Окончание проката";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.IsPaidCheckBox1);
			this.groupBox1.Controls.Add(this.PriceLabel);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.PeriodLabel);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.EndDateTimePicker2);
			this.groupBox1.Controls.Add(this.StartDateTimePicker1);
			this.groupBox1.Location = new System.Drawing.Point(12, 557);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(466, 162);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Основное";
			// 
			// OKbutton1
			// 
			this.OKbutton1.Location = new System.Drawing.Point(679, 657);
			this.OKbutton1.Name = "OKbutton1";
			this.OKbutton1.Size = new System.Drawing.Size(135, 48);
			this.OKbutton1.TabIndex = 5;
			this.OKbutton1.Text = "OK";
			this.OKbutton1.UseVisualStyleBackColor = true;
			this.OKbutton1.Click += new System.EventHandler(this.OKbutton1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 17);
			this.label3.TabIndex = 1;
			this.label3.Text = "Период (дней): ";
			// 
			// PeriodLabel
			// 
			this.PeriodLabel.AutoSize = true;
			this.PeriodLabel.Location = new System.Drawing.Point(187, 80);
			this.PeriodLabel.Name = "PeriodLabel";
			this.PeriodLabel.Size = new System.Drawing.Size(56, 17);
			this.PeriodLabel.TabIndex = 1;
			this.PeriodLabel.Text = "период";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 107);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(123, 17);
			this.label6.TabIndex = 1;
			this.label6.Text = "Стоимость (руб): ";
			// 
			// PriceLabel
			// 
			this.PriceLabel.AutoSize = true;
			this.PriceLabel.Location = new System.Drawing.Point(187, 107);
			this.PriceLabel.Name = "PriceLabel";
			this.PriceLabel.Size = new System.Drawing.Size(76, 17);
			this.PriceLabel.TabIndex = 1;
			this.PriceLabel.Text = "стоимость";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
			this.dataGridView1.Location = new System.Drawing.Point(6, 21);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(997, 197);
			this.dataGridView1.TabIndex = 6;
			this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.DeleteToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(148, 76);
			// 
			// EditToolStripMenuItem
			// 
			this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
			this.EditToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
			this.EditToolStripMenuItem.Text = "Изменить";
			this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
			// 
			// DeleteToolStripMenuItem
			// 
			this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
			this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
			this.DeleteToolStripMenuItem.Text = "Удалить";
			this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
			// 
			// AddToolStripMenuItem
			// 
			this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
			this.AddToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
			this.AddToolStripMenuItem.Text = "Добавить";
			this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dataGridView1);
			this.groupBox2.Location = new System.Drawing.Point(12, 327);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1006, 224);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Услуги";
			// 
			// EmployeesListBox1
			// 
			this.EmployeesListBox1.FormattingEnabled = true;
			this.EmployeesListBox1.ItemHeight = 16;
			this.EmployeesListBox1.Location = new System.Drawing.Point(679, 29);
			this.EmployeesListBox1.Name = "EmployeesListBox1";
			this.EmployeesListBox1.Size = new System.Drawing.Size(336, 292);
			this.EmployeesListBox1.TabIndex = 0;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(816, 9);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(78, 17);
			this.label9.TabIndex = 1;
			this.label9.Text = "Сотрудник";
			// 
			// AddRental
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1027, 724);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.OKbutton1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.EmployeesListBox1);
			this.Controls.Add(this.ClientListBox2);
			this.Controls.Add(this.CarListBox1);
			this.Name = "AddRental";
			this.Text = "Прокат";
			this.Load += new System.EventHandler(this.AddRental_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox CarListBox1;
		private System.Windows.Forms.ListBox ClientListBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker StartDateTimePicker1;
		private System.Windows.Forms.DateTimePicker EndDateTimePicker2;
		private System.Windows.Forms.CheckBox IsPaidCheckBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label PriceLabel;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label PeriodLabel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button OKbutton1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ListBox EmployeesListBox1;
		private System.Windows.Forms.Label label9;
	}
}