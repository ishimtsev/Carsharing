namespace carsharing_project
{
	partial class AddPosition
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.NameTB = new System.Windows.Forms.TextBox();
			this.zpTB = new System.Windows.Forms.TextBox();
			this.obyazTB = new System.Windows.Forms.TextBox();
			this.reqTB = new System.Windows.Forms.TextBox();
			this.OKb = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Название";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Оклад";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 65);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Обязанности";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 91);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "Требования";
			// 
			// NameTB
			// 
			this.NameTB.Location = new System.Drawing.Point(117, 11);
			this.NameTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.NameTB.Name = "NameTB";
			this.NameTB.Size = new System.Drawing.Size(265, 22);
			this.NameTB.TabIndex = 4;
			// 
			// zpTB
			// 
			this.zpTB.Location = new System.Drawing.Point(117, 37);
			this.zpTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.zpTB.Name = "zpTB";
			this.zpTB.Size = new System.Drawing.Size(265, 22);
			this.zpTB.TabIndex = 5;
			// 
			// obyazTB
			// 
			this.obyazTB.Location = new System.Drawing.Point(117, 62);
			this.obyazTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.obyazTB.Name = "obyazTB";
			this.obyazTB.Size = new System.Drawing.Size(265, 22);
			this.obyazTB.TabIndex = 6;
			// 
			// reqTB
			// 
			this.reqTB.Location = new System.Drawing.Point(117, 88);
			this.reqTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.reqTB.Name = "reqTB";
			this.reqTB.Size = new System.Drawing.Size(265, 22);
			this.reqTB.TabIndex = 7;
			// 
			// OKb
			// 
			this.OKb.Location = new System.Drawing.Point(117, 130);
			this.OKb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.OKb.Name = "OKb";
			this.OKb.Size = new System.Drawing.Size(152, 46);
			this.OKb.TabIndex = 8;
			this.OKb.Text = "OK";
			this.OKb.UseVisualStyleBackColor = true;
			this.OKb.Click += new System.EventHandler(this.OKb_Click);
			// 
			// AddPosition
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(394, 197);
			this.Controls.Add(this.OKb);
			this.Controls.Add(this.reqTB);
			this.Controls.Add(this.obyazTB);
			this.Controls.Add(this.zpTB);
			this.Controls.Add(this.NameTB);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "AddPosition";
			this.Text = "Должность";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox NameTB;
        public System.Windows.Forms.TextBox zpTB;
        public System.Windows.Forms.TextBox obyazTB;
        public System.Windows.Forms.TextBox reqTB;
        private System.Windows.Forms.Button OKb;
    }
}