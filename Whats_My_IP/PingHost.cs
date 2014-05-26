/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Mattia
 * Datum: 21.05.2014
 * Zeit: 19:39
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Whats_My_IP
{
	/// <summary>
	/// Description of PingHost.
	/// </summary>
	public partial class PingHost : Form
	{
		public PingHost()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		void Button_OKClick(object sender, EventArgs e)
		{
			MainForm.bHost = textBox_Ping.Text;
					//MessageBox.Show(MainForm.bHost);
			this.Close();
}
		
		void PingHostLoad(object sender, EventArgs e)
		{
			//MessageBox.Show(MainForm.bHost);
			textBox_Ping.Text = MainForm.bHost;
		}
	}
}
