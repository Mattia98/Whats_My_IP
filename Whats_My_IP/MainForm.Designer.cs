/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Mattia
 * Datum: 16.05.2014
 * Zeit: 07:16
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
namespace Whats_My_IP
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label_Ueberschrift = new System.Windows.Forms.Label();
			this.label_IP = new System.Windows.Forms.Label();
			this.groupBox_IPBox = new System.Windows.Forms.GroupBox();
			this.statusStrip_Main = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel_Status = new System.Windows.Forms.ToolStripStatusLabel();
			this.button_Go = new System.Windows.Forms.Button();
			this.backgroundWorker_Main = new System.ComponentModel.BackgroundWorker();
			this.groupBox_ISPBox = new System.Windows.Forms.GroupBox();
			this.label_ISP = new System.Windows.Forms.Label();
			this.groupBox_LocationBox = new System.Windows.Forms.GroupBox();
			this.label_Location = new System.Windows.Forms.Label();
			this.groupBox_PingBox = new System.Windows.Forms.GroupBox();
			this.label_Ping = new System.Windows.Forms.Label();
			this.button_PingHost = new System.Windows.Forms.Button();
			this.pictureBox_Flag = new System.Windows.Forms.PictureBox();
			this.button_Analize = new System.Windows.Forms.Button();
			this.groupBox_IPBox.SuspendLayout();
			this.statusStrip_Main.SuspendLayout();
			this.groupBox_ISPBox.SuspendLayout();
			this.groupBox_LocationBox.SuspendLayout();
			this.groupBox_PingBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Flag)).BeginInit();
			this.SuspendLayout();
			// 
			// label_Ueberschrift
			// 
			this.label_Ueberschrift.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Ueberschrift.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.label_Ueberschrift.Location = new System.Drawing.Point(12, 9);
			this.label_Ueberschrift.Name = "label_Ueberschrift";
			this.label_Ueberschrift.Size = new System.Drawing.Size(515, 33);
			this.label_Ueberschrift.TabIndex = 0;
			this.label_Ueberschrift.Text = "What\'s My IP?";
			this.label_Ueberschrift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_IP
			// 
			this.label_IP.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_IP.Location = new System.Drawing.Point(6, 35);
			this.label_IP.Name = "label_IP";
			this.label_IP.Size = new System.Drawing.Size(172, 33);
			this.label_IP.TabIndex = 1;
			this.label_IP.Text = "xxx.xxx.xxx.xxx";
			this.label_IP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox_IPBox
			// 
			this.groupBox_IPBox.Controls.Add(this.label_IP);
			this.groupBox_IPBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox_IPBox.Location = new System.Drawing.Point(12, 45);
			this.groupBox_IPBox.Name = "groupBox_IPBox";
			this.groupBox_IPBox.Size = new System.Drawing.Size(179, 76);
			this.groupBox_IPBox.TabIndex = 2;
			this.groupBox_IPBox.TabStop = false;
			this.groupBox_IPBox.Text = "IP:";
			// 
			// statusStrip_Main
			// 
			this.statusStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripStatusLabel_Status});
			this.statusStrip_Main.Location = new System.Drawing.Point(0, 319);
			this.statusStrip_Main.Name = "statusStrip_Main";
			this.statusStrip_Main.Size = new System.Drawing.Size(541, 22);
			this.statusStrip_Main.SizingGrip = false;
			this.statusStrip_Main.TabIndex = 3;
			this.statusStrip_Main.Text = "Info";
			// 
			// toolStripStatusLabel_Status
			// 
			this.toolStripStatusLabel_Status.Name = "toolStripStatusLabel_Status";
			this.toolStripStatusLabel_Status.Size = new System.Drawing.Size(40, 17);
			this.toolStripStatusLabel_Status.Text = "Bereit!";
			// 
			// button_Go
			// 
			this.button_Go.Location = new System.Drawing.Point(12, 291);
			this.button_Go.Name = "button_Go";
			this.button_Go.Size = new System.Drawing.Size(75, 23);
			this.button_Go.TabIndex = 1;
			this.button_Go.Text = "GO!";
			this.button_Go.UseVisualStyleBackColor = true;
			this.button_Go.Click += new System.EventHandler(this.Button_GetIPClick);
			// 
			// backgroundWorker_Main
			// 
			this.backgroundWorker_Main.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_MainDoWork);
			this.backgroundWorker_Main.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_MainRunWorkerCompleted);
			// 
			// groupBox_ISPBox
			// 
			this.groupBox_ISPBox.Controls.Add(this.label_ISP);
			this.groupBox_ISPBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox_ISPBox.Location = new System.Drawing.Point(12, 127);
			this.groupBox_ISPBox.Name = "groupBox_ISPBox";
			this.groupBox_ISPBox.Size = new System.Drawing.Size(515, 76);
			this.groupBox_ISPBox.TabIndex = 3;
			this.groupBox_ISPBox.TabStop = false;
			this.groupBox_ISPBox.Text = "ISP:";
			// 
			// label_ISP
			// 
			this.label_ISP.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_ISP.Location = new System.Drawing.Point(6, 35);
			this.label_ISP.Name = "label_ISP";
			this.label_ISP.Size = new System.Drawing.Size(503, 33);
			this.label_ISP.TabIndex = 1;
			this.label_ISP.Text = ".";
			this.label_ISP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox_LocationBox
			// 
			this.groupBox_LocationBox.Controls.Add(this.label_Location);
			this.groupBox_LocationBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox_LocationBox.Location = new System.Drawing.Point(12, 209);
			this.groupBox_LocationBox.Name = "groupBox_LocationBox";
			this.groupBox_LocationBox.Size = new System.Drawing.Size(515, 76);
			this.groupBox_LocationBox.TabIndex = 4;
			this.groupBox_LocationBox.TabStop = false;
			this.groupBox_LocationBox.Text = "Location:";
			// 
			// label_Location
			// 
			this.label_Location.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Location.Location = new System.Drawing.Point(6, 35);
			this.label_Location.Name = "label_Location";
			this.label_Location.Size = new System.Drawing.Size(503, 33);
			this.label_Location.TabIndex = 1;
			this.label_Location.Text = ".";
			this.label_Location.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox_PingBox
			// 
			this.groupBox_PingBox.Controls.Add(this.label_Ping);
			this.groupBox_PingBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox_PingBox.Location = new System.Drawing.Point(197, 45);
			this.groupBox_PingBox.Name = "groupBox_PingBox";
			this.groupBox_PingBox.Size = new System.Drawing.Size(213, 76);
			this.groupBox_PingBox.TabIndex = 3;
			this.groupBox_PingBox.TabStop = false;
			this.groupBox_PingBox.Text = "Ping:";
			// 
			// label_Ping
			// 
			this.label_Ping.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Ping.Location = new System.Drawing.Point(6, 35);
			this.label_Ping.Name = "label_Ping";
			this.label_Ping.Size = new System.Drawing.Size(201, 33);
			this.label_Ping.TabIndex = 1;
			this.label_Ping.Text = "xxx ms";
			this.label_Ping.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// button_PingHost
			// 
			this.button_PingHost.Location = new System.Drawing.Point(407, 291);
			this.button_PingHost.Name = "button_PingHost";
			this.button_PingHost.Size = new System.Drawing.Size(120, 23);
			this.button_PingHost.TabIndex = 3;
			this.button_PingHost.Text = "Anderen Ping-Hoster";
			this.button_PingHost.UseVisualStyleBackColor = true;
			this.button_PingHost.Click += new System.EventHandler(this.Button_PingHostClick);
			// 
			// pictureBox_Flag
			// 
			this.pictureBox_Flag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox_Flag.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox_Flag.Location = new System.Drawing.Point(416, 45);
			this.pictureBox_Flag.Name = "pictureBox_Flag";
			this.pictureBox_Flag.Size = new System.Drawing.Size(111, 76);
			this.pictureBox_Flag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox_Flag.TabIndex = 6;
			this.pictureBox_Flag.TabStop = false;
			// 
			// button_Analize
			// 
			this.button_Analize.Location = new System.Drawing.Point(281, 291);
			this.button_Analize.Name = "button_Analize";
			this.button_Analize.Size = new System.Drawing.Size(120, 23);
			this.button_Analize.TabIndex = 2;
			this.button_Analize.Text = "Andere IP Analysieren";
			this.button_Analize.UseVisualStyleBackColor = true;
			this.button_Analize.Click += new System.EventHandler(this.Button_AnalizeClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(541, 341);
			this.Controls.Add(this.button_Analize);
			this.Controls.Add(this.pictureBox_Flag);
			this.Controls.Add(this.button_PingHost);
			this.Controls.Add(this.groupBox_PingBox);
			this.Controls.Add(this.groupBox_LocationBox);
			this.Controls.Add(this.groupBox_ISPBox);
			this.Controls.Add(this.button_Go);
			this.Controls.Add(this.statusStrip_Main);
			this.Controls.Add(this.groupBox_IPBox);
			this.Controls.Add(this.label_Ueberschrift);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "What\'s My IP?";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.groupBox_IPBox.ResumeLayout(false);
			this.statusStrip_Main.ResumeLayout(false);
			this.statusStrip_Main.PerformLayout();
			this.groupBox_ISPBox.ResumeLayout(false);
			this.groupBox_LocationBox.ResumeLayout(false);
			this.groupBox_PingBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Flag)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button_Analize;
		private System.Windows.Forms.PictureBox pictureBox_Flag;
		private System.Windows.Forms.Button button_PingHost;
		private System.Windows.Forms.Label label_Ping;
		private System.Windows.Forms.GroupBox groupBox_PingBox;
		private System.Windows.Forms.Label label_Location;
		private System.Windows.Forms.GroupBox groupBox_LocationBox;
		private System.Windows.Forms.Label label_ISP;
		private System.Windows.Forms.GroupBox groupBox_ISPBox;
		private System.ComponentModel.BackgroundWorker backgroundWorker_Main;
		private System.Windows.Forms.Button button_Go;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Status;
		private System.Windows.Forms.StatusStrip statusStrip_Main;
		private System.Windows.Forms.GroupBox groupBox_IPBox;
		private System.Windows.Forms.Label label_IP;
		private System.Windows.Forms.Label label_Ueberschrift;
	}
}
