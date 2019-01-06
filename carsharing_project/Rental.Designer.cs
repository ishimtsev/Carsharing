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
            this.dataGridView1.Location = new System.Drawing.Point(0, 238);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1361, 620);
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(218, 94);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.EditToolStripMenuItem.Text = "Изменить";
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.DeleteToolStripMenuItem.Text = "Удалить";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // PaidToolStripMenuItem
            // 
            this.PaidToolStripMenuItem.Name = "PaidToolStripMenuItem";
            this.PaidToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.PaidToolStripMenuItem.Text = "Прокат оплачен";
            this.PaidToolStripMenuItem.Click += new System.EventHandler(this.PaidToolStripMenuItem_Click);
            // 
            // AddRentalButton
            // 
            this.AddRentalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddRentalButton.Location = new System.Drawing.Point(1128, 35);
            this.AddRentalButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddRentalButton.Name = "AddRentalButton";
            this.AddRentalButton.Size = new System.Drawing.Size(200, 56);
            this.AddRentalButton.TabIndex = 2;
            this.AddRentalButton.Text = "Добавить прокат";
            this.AddRentalButton.UseVisualStyleBackColor = true;
            this.AddRentalButton.Click += new System.EventHandler(this.AddRentalButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(382, 48);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(84, 29);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(200, 49);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(175, 26);
            this.SearchTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Поиск";
            // 
            // FromPeriodCheckBox1
            // 
            this.FromPeriodCheckBox1.AutoSize = true;
            this.FromPeriodCheckBox1.Location = new System.Drawing.Point(770, 35);
            this.FromPeriodCheckBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FromPeriodCheckBox1.Name = "FromPeriodCheckBox1";
            this.FromPeriodCheckBox1.Size = new System.Drawing.Size(115, 24);
            this.FromPeriodCheckBox1.TabIndex = 5;
            this.FromPeriodCheckBox1.Text = "За период";
            this.FromPeriodCheckBox1.UseVisualStyleBackColor = true;
            this.FromPeriodCheckBox1.CheckedChanged += new System.EventHandler(this.FromPeriodCheckBox1_CheckedChanged);
            // 
            // StartDateTimePicker1
            // 
            this.StartDateTimePicker1.Location = new System.Drawing.Point(802, 69);
            this.StartDateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartDateTimePicker1.Name = "StartDateTimePicker1";
            this.StartDateTimePicker1.Size = new System.Drawing.Size(224, 26);
            this.StartDateTimePicker1.TabIndex = 6;
            this.StartDateTimePicker1.ValueChanged += new System.EventHandler(this.StartDateTimePicker1_ValueChanged);
            // 
            // EndDateTimePicker2
            // 
            this.EndDateTimePicker2.Location = new System.Drawing.Point(802, 104);
            this.EndDateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EndDateTimePicker2.Name = "EndDateTimePicker2";
            this.EndDateTimePicker2.Size = new System.Drawing.Size(224, 26);
            this.EndDateTimePicker2.TabIndex = 7;
            this.EndDateTimePicker2.ValueChanged += new System.EventHandler(this.StartDateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(766, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "С";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(766, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "По";
            // 
            // Rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 858);
            this.Controls.Add(this.StartDateTimePicker1);
            this.Controls.Add(this.EndDateTimePicker2);
            this.Controls.Add(this.FromPeriodCheckBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.AddRentalButton);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
	}
}