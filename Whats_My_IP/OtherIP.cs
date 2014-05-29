/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Mattia
 * Datum: 23.05.2014
 * Zeit: 07:28
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Whats_My_IP
{
	/// <summary>
	/// Description of OtherIP.
	/// </summary>
	public partial class OtherIP : Form
	{
		public OtherIP()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		void Button_OKClick(object sender, EventArgs e)
		{
			MainForm.aIP = textBox_IP.Text;
			MainForm.bHost = textBox_IP.Text;
			this.Close();
		}
	}
}
