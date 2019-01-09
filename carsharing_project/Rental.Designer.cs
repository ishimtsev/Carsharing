namespace carsharing_project
{
	partial class Rental
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PaidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddRentalButton = new System.Windows.Forms.Button();
			this.SearchButton = new System.Windows.Forms.Button();
			this.SearchTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.FromPeriodCheckBox1 = new System.Windows.Forms.CheckBox();
			this.StartDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.EndDateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.DistanceButton1 = new System.Windows.Forms.Button();
			this.IsInRegionutton3 = new System.Windows.Forms.Button();
			this.SecondLocatTextBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGridView1.Location = new System.Drawing.Point(0, 190);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(1210, 496);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditToolStripMenuItem,
            this.DeleteToolStripMenuItem,
            this.PaidToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(192, 76);
			// 
			// EditToolStripMenuItem
			// 
			this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
			this.EditToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
			this.EditToolStripMenuItem.Text = "Изменить";
			this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
			// 
			// DeleteToolStripMenuItem
			// 
			this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
			this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
			this.DeleteToolStripMenuItem.Text = "Удалить";
			this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
			// 
			// PaidToolStripMenuItem
			// 
			this.PaidToolStripMenuItem.Name = "PaidToolStripMenuItem";
			this.PaidToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
			this.PaidToolStripMenuItem.Text = "Прокат оплачен";
			this.PaidToolStripMenuItem.Click += new System.EventHandler(this.PaidToolStripMenuItem_Click);
			// 
			// AddRentalButton
			// 
			this.AddRentalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.AddRentalButton.Location = new System.Drawing.Point(1020, 24);
			this.AddRentalButton.Name = "AddRentalButton";
			this.AddRentalButton.Size = new System.Drawing.Size(178, 45);
			this.AddRentalButton.TabIndex = 2;
			this.AddRentalButton.Text = "Добавить прокат";
			this.AddRentalButton.UseVisualStyleBackColor = true;
			this.AddRentalButton.Click += new System.EventHandler(this.AddRentalButton_Click);
			// 
			// SearchButton
			// 
			this.SearchButton.Location = new System.Drawing.Point(228, 35);
			this.SearchButton.Name = "SearchButton";
			this.SearchButton.Size = new System.Drawing.Size(75, 23);
			this.SearchButton.TabIndex = 2;
			this.SearchButton.Text = "Поиск";
			this.SearchButton.UseVisualStyleBackColor = true;
			this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
			// 
			// SearchTextBox
			// 
			this.SearchTextBox.Location = new System.Drawing.Point(66, 35);
			this.SearchTextBox.Name = "SearchTextBox";
			this.SearchTextBox.Size = new System.Drawing.Size(156, 22);
			this.SearchTextBox.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "Поиск";
			// 
			// FromPeriodCheckBox1
			// 
			this.FromPeriodCheckBox1.AutoSize = true;
			this.FromPeriodCheckBox1.Location = new System.Drawing.Point(364, 12);
			this.FromPeriodCheckBox1.Name = "FromPeriodCheckBox1";
			this.FromPeriodCheckBox1.Size = new System.Drawing.Size(99, 21);
			this.FromPeriodCheckBox1.TabIndex = 5;
			this.FromPeriodCheckBox1.Text = "За период";
			this.FromPeriodCheckBox1.UseVisualStyleBackColor = true;
			this.FromPeriodCheckBox1.CheckedChanged += new System.EventHandler(this.FromPeriodCheckBox1_CheckedChanged);
			// 
			// StartDateTimePicker1
			// 
			this.StartDateTimePicker1.Location = new System.Drawing.Point(393, 39);
			this.StartDateTimePicker1.Name = "StartDateTimePicker1";
			this.StartDateTimePicker1.Size = new System.Drawing.Size(200, 22);
			this.StartDateTimePicker1.TabIndex = 6;
			this.StartDateTimePicker1.ValueChanged += new System.EventHandler(this.StartDateTimePicker1_ValueChanged);
			// 
			// EndDateTimePicker2
			// 
			this.EndDateTimePicker2.Location = new System.Drawing.Point(393, 67);
			this.EndDateTimePicker2.Name = "EndDateTimePicker2";
			this.EndDateTimePicker2.Size = new System.Drawing.Size(200, 22);
			this.EndDateTimePicker2.TabIndex = 7;
			this.EndDateTimePicker2.ValueChanged += new System.EventHandler(this.StartDateTimePicker1_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(361, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(17, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "С";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(361, 72);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(26, 17);
			this.label4.TabIndex = 4;
			this.label4.Text = "По";
			// 
			// DistanceButton1
			// 
			this.DistanceButton1.Location = new System.Drawing.Point(168, 112);
			this.DistanceButton1.Name = "DistanceButton1";
			this.DistanceButton1.Size = new System.Drawing.Size(123, 61);
			this.DistanceButton1.TabIndex = 8;
			this.DistanceButton1.Text = "Расстояние между двумя точками";
			this.DistanceButton1.UseVisualStyleBackColor = true;
			this.DistanceButton1.Click += new System.EventHandler(this.DistanceButton1_Click);
			// 
			// IsInRegionutton3
			// 
			this.IsInRegionutton3.Location = new System.Drawing.Point(297, 112);
			this.IsInRegionutton3.Name = "IsInRegionutton3";
			this.IsInRegionutton3.Size = new System.Drawing.Size(123, 61);
			this.IsInRegionutton3.TabIndex = 8;
			this.IsInRegionutton3.Text = "Находится ли автомобиль в области";
			this.IsInRegionutton3.UseVisualStyleBackColor = true;
			this.IsInRegionutton3.Click += new System.EventHandler(this.IsInRegionutton3_Click);
			// 
			// SecondLocatTextBox1
			// 
			this.SecondLocatTextBox1.Location = new System.Drawing.Point(15, 142);
			this.SecondLocatTextBox1.Name = "SecondLocatTextBox1";
			this.SecondLocatTextBox1.Size = new System.Drawing.Size(147, 22);
			this.SecondLocatTextBox1.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(41, 122);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(98, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "Вторая точка";
			// 
			// Rental
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1210, 686);
			this.Controls.Add(this.SecondLocatTextBox1);
			this.Controls.Add(this.IsInRegionutton3);
			this.Controls.Add(this.DistanceButton1);
			this.Controls.Add(this.StartDateTimePicker1);
			this.Controls.Add(this.EndDateTimePicker2);
			this.Controls.Add(this.FromPeriodCheckBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.SearchTextBox);
			this.Controls.Add(this.SearchButton);
			this.Controls.Add(this.AddRentalButton);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Rental";
			this.Text = "Прокаты";
			this.Load += new System.EventHandler(this.Rental_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Button AddRentalButton;
		private System.Windows.Forms.Button SearchButton;
		private System.Windows.Forms.TextBox SearchTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem PaidToolStripMenuItem;
		private System.Windows.Forms.CheckBox FromPeriodCheckBox1;
		private System.Windows.Forms.DateTimePicker StartDateTimePicker1;
		private System.Windows.Forms.DateTimePicker EndDateTimePicker2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button DistanceButton1;
		private System.Windows.Forms.Button IsInRegionutton3;
		private System.Windows.Forms.TextBox SecondLocatTextBox1;
		private System.Windows.Forms.Label label3;
	}
}