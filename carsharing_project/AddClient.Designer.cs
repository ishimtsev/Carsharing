namespace carsharing_project
{
    partial class AddClient
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
			this.fioTextBox = new System.Windows.Forms.TextBox();
			this.addressTextBox = new System.Windows.Forms.TextBox();
			this.phoneTextBox = new System.Windows.Forms.TextBox();
			this.passTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.sexBox = new System.Windows.Forms.ComboBox();
			this.birthPicker = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// fioTextBox
			// 
			this.fioTextBox.Location = new System.Drawing.Point(245, 23);
			this.fioTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.fioTextBox.Name = "fioTextBox";
			this.fioTextBox.Size = new System.Drawing.Size(316, 22);
			this.fioTextBox.TabIndex = 1;
			// 
			// addressTextBox
			// 
			this.addressTextBox.Location = new System.Drawing.Point(245, 100);
			this.addressTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.addressTextBox.Name = "addressTextBox";
			this.addressTextBox.Size = new System.Drawing.Size(316, 22);
			this.addressTextBox.TabIndex = 4;
			// 
			// phoneTextBox
			// 
			this.phoneTextBox.Location = new System.Drawing.Point(245, 126);
			this.phoneTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.phoneTextBox.Name = "phoneTextBox";
			this.phoneTextBox.Size = new System.Drawing.Size(316, 22);
			this.phoneTextBox.TabIndex = 5;
			// 
			// passTextBox
			// 
			this.passTextBox.Location = new System.Drawing.Point(245, 151);
			this.passTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.passTextBox.Name = "passTextBox";
			this.passTextBox.Size = new System.Drawing.Size(316, 22);
			this.passTextBox.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 17);
			this.label1.TabIndex = 6;
			this.label1.Text = "ФИО";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 17);
			this.label2.TabIndex = 7;
			this.label2.Text = "Пол";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(20, 79);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(111, 17);
			this.label3.TabIndex = 8;
			this.label3.Text = "Дата рождения";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(20, 105);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 17);
			this.label4.TabIndex = 9;
			this.label4.Text = "Адрес";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(20, 130);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 17);
			this.label5.TabIndex = 10;
			this.label5.Text = "Телефон";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(20, 156);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(144, 17);
			this.label6.TabIndex = 11;
			this.label6.Text = "Паспортные данные";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(223, 201);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(173, 44);
			this.button1.TabIndex = 7;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.OKb_Click);
			// 
			// sexBox
			// 
			this.sexBox.FormattingEnabled = true;
			this.sexBox.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
			this.sexBox.Location = new System.Drawing.Point(245, 49);
			this.sexBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.sexBox.Name = "sexBox";
			this.sexBox.Size = new System.Drawing.Size(316, 24);
			this.sexBox.TabIndex = 2;
			// 
			// birthPicker
			// 
			this.birthPicker.Location = new System.Drawing.Point(245, 74);
			this.birthPicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.birthPicker.Name = "birthPicker";
			this.birthPicker.Size = new System.Drawing.Size(316, 22);
			this.birthPicker.TabIndex = 3;
			// 
			// AddClient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(619, 270);
			this.Controls.Add(this.birthPicker);
			this.Controls.Add(this.sexBox);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.passTextBox);
			this.Controls.Add(this.phoneTextBox);
			this.Controls.Add(this.addressTextBox);
			this.Controls.Add(this.fioTextBox);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "AddClient";
			this.Text = "Клиент";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox fioTextBox;
        public System.Windows.Forms.TextBox addressTextBox;
        public System.Windows.Forms.TextBox phoneTextBox;
        public System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox sexBox;
        public System.Windows.Forms.DateTimePicker birthPicker;
    }
}