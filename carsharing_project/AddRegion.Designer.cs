namespace carsharing_project
{
	partial class AddRegion
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
			this.OKbutton1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.NametextBox1 = new System.Windows.Forms.TextBox();
			this.PointstextBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// OKbutton1
			// 
			this.OKbutton1.Location = new System.Drawing.Point(92, 80);
			this.OKbutton1.Name = "OKbutton1";
			this.OKbutton1.Size = new System.Drawing.Size(144, 46);
			this.OKbutton1.TabIndex = 0;
			this.OKbutton1.Text = "OK";
			this.OKbutton1.UseVisualStyleBackColor = true;
			this.OKbutton1.Click += new System.EventHandler(this.OKbutton1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Название";
			// 
			// NametextBox1
			// 
			this.NametextBox1.Location = new System.Drawing.Point(92, 12);
			this.NametextBox1.Name = "NametextBox1";
			this.NametextBox1.Size = new System.Drawing.Size(231, 22);
			this.NametextBox1.TabIndex = 2;
			// 
			// PointstextBox2
			// 
			this.PointstextBox2.Location = new System.Drawing.Point(92, 40);
			this.PointstextBox2.Name = "PointstextBox2";
			this.PointstextBox2.Size = new System.Drawing.Size(231, 22);
			this.PointstextBox2.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Точки";
			// 
			// AddRegion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(337, 142);
			this.Controls.Add(this.PointstextBox2);
			this.Controls.Add(this.NametextBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.OKbutton1);
			this.Name = "AddRegion";
			this.Text = "Область";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button OKbutton1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox NametextBox1;
		private System.Windows.Forms.TextBox PointstextBox2;
		private System.Windows.Forms.Label label2;
	}
}