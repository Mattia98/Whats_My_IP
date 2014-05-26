/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Mattia
 * Datum: 23.05.2014
 * Zeit: 07:28
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
namespace Whats_My_IP
{
	partial class OtherIP
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtherIP));
			this.button_OK = new System.Windows.Forms.Button();
			this.groupBox_PingBx = new System.Windows.Forms.GroupBox();
			this.textBox_Ping = new System.Windows.Forms.TextBox();
			this.label_IP = new System.Windows.Forms.Label();
			this.groupBox_PingBx.SuspendLayout();
			this.SuspendLayout();
			// 
			// button_OK
			// 
			this.button_OK.Location = new System.Drawing.Point(12, 91);
			this.button_OK.Name = "button_OK";
			this.button_OK.Size = new System.Drawing.Size(75, 23);
			this.button_OK.TabIndex = 7;
			this.button_OK.Text = "OK";
			this.button_OK.UseVisualStyleBackColor = true;
			// 
			// groupBox_PingBx
			// 
			this.groupBox_PingBx.Controls.Add(this.textBox_Ping);
			this.groupBox_PingBx.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox_PingBx.Location = new System.Drawing.Point(12, 12);
			this.groupBox_PingBx.Name = "groupBox_PingBx";
			this.groupBox_PingBx.Size = new System.Drawing.Size(386, 73);
			this.groupBox_PingBx.TabIndex = 6;
			this.groupBox_PingBx.TabStop = false;
			this.groupBox_PingBx.Text = "Ping hoster (z.B. \"www.google.com\"):";
			// 
			// textBox_Ping
			// 
			this.textBox_Ping.Location = new System.Drawing.Point(6, 32);
			this.textBox_Ping.Name = "textBox_Ping";
			this.textBox_Ping.Size = new System.Drawing.Size(365, 33);
			this.textBox_Ping.TabIndex = 0;
			this.textBox_Ping.Text = "www.google.com";
			// 
			// label_IP
			// 
			this.label_IP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_IP.Location = new System.Drawing.Point(93, 91);
			this.label_IP.Name = "label_IP";
			this.label_IP.Size = new System.Drawing.Size(305, 23);
			this.label_IP.TabIndex = 8;
			this.label_IP.Text = "Achtung: Nicht alle Seiten können gepingt werden!";
			this.label_IP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// OtherIP
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(409, 124);
			this.Controls.Add(this.button_OK);
			this.Controls.Add(this.groupBox_PingBx);
			this.Controls.Add(this.label_IP);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "OtherIP";
			this.ShowInTaskbar = false;
			this.Text = "IP Wählen";
			this.groupBox_PingBx.ResumeLayout(false);
			this.groupBox_PingBx.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label_IP;
		private System.Windows.Forms.TextBox textBox_Ping;
		private System.Windows.Forms.GroupBox groupBox_PingBx;
		private System.Windows.Forms.Button button_OK;
	}
}
