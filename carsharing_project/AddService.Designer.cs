namespace carsharing_project
{
	partial class AddService
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
			this.label1 = new System.Windows.Forms.Label();
			this.OKbutton1 = new System.Windows.Forms.Button();
			this.NameTextBox1 = new System.Windows.Forms.TextBox();
			this.CountNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.DescrTextBox2 = new System.Windows.Forms.TextBox();
			this.PriceTextBox3 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.CountNumericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Название";
			// 
			// OKbutton1
			// 
			this.OKbutton1.Location = new System.Drawing.Point(121, 143);
			this.OKbutton1.Name = "OKbutton1";
			this.OKbutton1.Size = new System.Drawing.Size(107, 39);
			this.OKbutton1.TabIndex = 5;
			this.OKbutton1.Text = "OK";
			this.OKbutton1.UseVisualStyleBackColor = true;
			this.OKbutton1.Click += new System.EventHandler(this.OKbutton1_Click);
			// 
			// NameTextBox1
			// 
			this.NameTextBox1.Location = new System.Drawing.Point(112, 12);
			this.NameTextBox1.Name = "NameTextBox1";
			this.NameTextBox1.Size = new System.Drawing.Size(224, 22);
			this.NameTextBox1.TabIndex = 1;
			// 
			// CountNumericUpDown1
			// 
			this.CountNumericUpDown1.Location = new System.Drawing.Point(112, 96);
			this.CountNumericUpDown1.Name = "CountNumericUpDown1";
			this.CountNumericUpDown1.Size = new System.Drawing.Size(224, 22);
			this.CountNumericUpDown1.TabIndex = 4;
			this.CountNumericUpDown1.ValueChanged += new System.EventHandler(this.CountNumericUpDown1_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Описание";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 71);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "Цена";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 98);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 17);
			this.label4.TabIndex = 0;
			this.label4.Text = "Количество";
			// 
			// DescrTextBox2
			// 
			this.DescrTextBox2.Location = new System.Drawing.Point(112, 40);
			this.DescrTextBox2.Name = "DescrTextBox2";
			this.DescrTextBox2.Size = new System.Drawing.Size(224, 22);
			this.DescrTextBox2.TabIndex = 2;
			// 
			// PriceTextBox3
			// 
			this.PriceTextBox3.Location = new System.Drawing.Point(112, 68);
			this.PriceTextBox3.Name = "PriceTextBox3";
			this.PriceTextBox3.Size = new System.Drawing.Size(224, 22);
			this.PriceTextBox3.TabIndex = 3;
			// 
			// AddService
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(348, 202);
			this.Controls.Add(this.CountNumericUpDown1);
			this.Controls.Add(this.PriceTextBox3);
			this.Controls.Add(this.DescrTextBox2);
			this.Controls.Add(this.NameTextBox1);
			this.Controls.Add(this.OKbutton1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "AddService";
			this.Text = "Услуга";
			this.Load += new System.EventHandler(this.AddService_Load);
			((System.ComponentModel.ISupportInitialize)(this.CountNumericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button OKbutton1;
		public System.Windows.Forms.TextBox NameTextBox1;
		public System.Windows.Forms.NumericUpDown CountNumericUpDown1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		public System.Windows.Forms.TextBox DescrTextBox2;
		public System.Windows.Forms.TextBox PriceTextBox3;
	}
}