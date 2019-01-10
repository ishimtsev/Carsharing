namespace carsharing_project
{
	partial class RentalMap
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
			this.gmap = new GMap.NET.WindowsForms.GMapControl();
			this.IsInRegionutton3 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.DistanceLabel = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// gmap
			// 
			this.gmap.Bearing = 0F;
			this.gmap.CanDragMap = true;
			this.gmap.Dock = System.Windows.Forms.DockStyle.Top;
			this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
			this.gmap.GrayScaleMode = false;
			this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
			this.gmap.LevelsKeepInMemmory = 5;
			this.gmap.Location = new System.Drawing.Point(0, 0);
			this.gmap.MarkersEnabled = true;
			this.gmap.MaxZoom = 17;
			this.gmap.MinZoom = 2;
			this.gmap.MouseWheelZoomEnabled = true;
			this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
			this.gmap.Name = "gmap";
			this.gmap.NegativeMode = false;
			this.gmap.PolygonsEnabled = true;
			this.gmap.RetryLoadTile = 0;
			this.gmap.RoutesEnabled = true;
			this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
			this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
			this.gmap.ShowTileGridLines = false;
			this.gmap.Size = new System.Drawing.Size(1206, 652);
			this.gmap.TabIndex = 0;
			this.gmap.Zoom = 0D;
			// 
			// IsInRegionutton3
			// 
			this.IsInRegionutton3.Location = new System.Drawing.Point(160, 673);
			this.IsInRegionutton3.Name = "IsInRegionutton3";
			this.IsInRegionutton3.Size = new System.Drawing.Size(142, 61);
			this.IsInRegionutton3.TabIndex = 9;
			this.IsInRegionutton3.Text = "Находится ли автомобиль в области";
			this.IsInRegionutton3.UseVisualStyleBackColor = true;
			this.IsInRegionutton3.Click += new System.EventHandler(this.IsInRegionutton3_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(904, 673);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(142, 61);
			this.button1.TabIndex = 10;
			this.button1.Text = "Все треки и области";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(419, 695);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 17);
			this.label1.TabIndex = 11;
			this.label1.Text = "Длина трека ";
			this.label1.Visible = false;
			// 
			// DistanceLabel
			// 
			this.DistanceLabel.AutoSize = true;
			this.DistanceLabel.Location = new System.Drawing.Point(522, 695);
			this.DistanceLabel.Name = "DistanceLabel";
			this.DistanceLabel.Size = new System.Drawing.Size(16, 17);
			this.DistanceLabel.TabIndex = 11;
			this.DistanceLabel.Text = "0";
			this.DistanceLabel.Visible = false;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(308, 688);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(86, 31);
			this.button2.TabIndex = 12;
			this.button2.Text = "Сброс";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(1052, 673);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(142, 61);
			this.button3.TabIndex = 13;
			this.button3.Text = "Самая часто посещаемая область";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(12, 673);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(142, 61);
			this.button4.TabIndex = 14;
			this.button4.Text = "Область и трек";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// RentalMap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1206, 758);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.DistanceLabel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.IsInRegionutton3);
			this.Controls.Add(this.gmap);
			this.Name = "RentalMap";
			this.Text = "Карта";
			this.Load += new System.EventHandler(this.RentalMap_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private GMap.NET.WindowsForms.GMapControl gmap;
		private System.Windows.Forms.Button IsInRegionutton3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label DistanceLabel;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
	}
}