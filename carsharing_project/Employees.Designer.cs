namespace carsharing_project
{
	partial class Employees
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
			this.AddEmployeeButton = new System.Windows.Forms.Button();
			this.PositionsButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGridView1.Location = new System.Drawing.Point(0, 120);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(1208, 537);
			this.dataGridView1.TabIndex = 0;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// AddEmployeeButton
			// 
			this.AddEmployeeButton.Location = new System.Drawing.Point(837, 24);
			this.AddEmployeeButton.Name = "AddEmployeeButton";
			this.AddEmployeeButton.Size = new System.Drawing.Size(151, 56);
			this.AddEmployeeButton.TabIndex = 2;
			this.AddEmployeeButton.Text = "Добавить сотрудника";
			this.AddEmployeeButton.UseVisualStyleBackColor = true;
			this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
			// 
			// PositionsButton
			// 
			this.PositionsButton.Location = new System.Drawing.Point(1039, 24);
			this.PositionsButton.Name = "PositionsButton";
			this.PositionsButton.Size = new System.Drawing.Size(139, 42);
			this.PositionsButton.TabIndex = 3;
			this.PositionsButton.Text = "Должности";
			this.PositionsButton.UseVisualStyleBackColor = true;
			// 
			// Employees
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1208, 657);
			this.Controls.Add(this.PositionsButton);
			this.Controls.Add(this.AddEmployeeButton);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Employees";
			this.Text = "Сотрудники";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Button AddEmployeeButton;
		private System.Windows.Forms.Button PositionsButton;
	}
}