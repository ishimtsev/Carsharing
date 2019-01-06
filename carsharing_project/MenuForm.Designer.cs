namespace carsharing_project
{
	partial class MenuForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.CarsButton3 = new System.Windows.Forms.Button();
			this.RentalButton3 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(48, 17);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(282, 34);
			this.button1.TabIndex = 0;
			this.button1.Text = "Клиенты";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(48, 56);
			this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(282, 34);
			this.button2.TabIndex = 1;
			this.button2.Text = "Сотрудники и должности";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// CarsButton3
			// 
			this.CarsButton3.Location = new System.Drawing.Point(48, 94);
			this.CarsButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.CarsButton3.Name = "CarsButton3";
			this.CarsButton3.Size = new System.Drawing.Size(282, 34);
			this.CarsButton3.TabIndex = 1;
			this.CarsButton3.Text = "Автомобили";
			this.CarsButton3.UseVisualStyleBackColor = true;
			this.CarsButton3.Click += new System.EventHandler(this.CarsButton3_Click);
			// 
			// RentalButton3
			// 
			this.RentalButton3.Location = new System.Drawing.Point(48, 132);
			this.RentalButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.RentalButton3.Name = "RentalButton3";
			this.RentalButton3.Size = new System.Drawing.Size(282, 34);
			this.RentalButton3.TabIndex = 1;
			this.RentalButton3.Text = "Прокаты";
			this.RentalButton3.UseVisualStyleBackColor = true;
			this.RentalButton3.Click += new System.EventHandler(this.RentalButton3_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 211);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(738, 321);
			this.textBox1.TabIndex = 3;
			this.textBox1.Text = "В AddRental из конструктора выбирать строки с нужной машиной и сотрудником в лист" +
    "боксах.\r\n\r\n\r\n";
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// MenuForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(762, 544);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.RentalButton3);
			this.Controls.Add(this.CarsButton3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "MenuForm";
			this.Text = "Меню";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button CarsButton3;
		private System.Windows.Forms.Button RentalButton3;
		private System.Windows.Forms.TextBox textBox1;
	}
}

