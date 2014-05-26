/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Mattia
 * Datum: 16.05.2014
 * Zeit: 07:16
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Net.NetworkInformation;

namespace Whats_My_IP
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		string[] aInfo = new string[4];
		string aHost = "http://ip-api.com/json";//Json-Hoster
		public static string bHost = "www.google.com";//Ping-Hoster
		int aPing;
		
		
		void MainFormLoad(object sender, EventArgs e)
		{
			button_GetIP.Enabled = false;
			backgroundWorker_GetIP.RunWorkerAsync();
			
		}
		
		void Button_GetIPClick(object sender, EventArgs e)
		{
			button_GetIP.Enabled = false;
			backgroundWorker_GetIP.RunWorkerAsync();
			
		}
		
		string GetJson(string host)
		{
			string bIP;
			using(WebClient client = new WebClient()) {
  					bIP = client.DownloadString(host);
				}
			return bIP;
		}
		
		void ConvertJson(string json)
		{
			JObject o = JObject.Parse(json);
			/*aInfo[0] = (string)o["YourFuckingIPAddress"];
			aInfo[1] = (string)o["YourFuckingLocation"];
			aInfo[2] = (string)o["YourFuckingHostname"];
			aInfo[3] = (string)o["YourFuckingISP"];
			*/
			aInfo[0] = (string)o["query"];
			aInfo[1] = (string)o["regionName"]+" | "+(string)o["country"];
			aInfo[2] = (string)o["countryCode"];
			aInfo[3] = (string)o["isp"];
		}
		
		int GetPing()
		{
			int ping;
			using (Ping p = new Ping()) {
				ping = Convert.ToInt32(p.Send(bHost).RoundtripTime);
			}
			return ping;
		}
		
		void RefreshUI()
		{
			label_IP.Text = aInfo[0];
			label_ISP.Text = aInfo[3];
			label_Location.Text = aInfo[1];
			label_Ping.Text = aPing.ToString()+" ms";
			pictureBox_Flag.ImageLocation = "http://flagpedia.net/data/flags/small/"+aInfo[2].ToLower()+".png";
		}
		
		void BackgroundWorker_GetIPDoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			BackgroundWorker worker = sender as BackgroundWorker;
			
			try 
			{
				//Hole und konvertiere die Json
				toolStripStatusLabel_Status.Text = "Hole Json-Datei von \""+aHost+"\"...";
				string[] aInfo = new string[3];
				ConvertJson(GetJson(aHost));
				toolStripStatusLabel_Status.Text = "OK!";
				//Teste den Ping
				toolStripStatusLabel_Status.Text = "Teste Ping über \""+bHost+"\"...";
				aPing = GetPing();
				toolStripStatusLabel_Status.Text = "OK! ("+aPing.ToString()+" ms)";
				//
				toolStripStatusLabel_Status.Text = "Fertig! (Json-Host: \""+aHost+"\", Ping-Host: \""+bHost+"\")";
			}
			catch (Exception ex) 
			{
				toolStripStatusLabel_Status.Text = "Fehler: "+ ex.Message;
				MessageBox.Show(ex.Message, "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}
		
		void BackgroundWorker_GetIPRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if(e.Error != null)
			{
				MessageBox.Show(e.Error.Message, "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				RefreshUI();
			}
			button_GetIP.Enabled = true;
		}
		
		void Button_PingHostClick(object sender, EventArgs e)
		{
			PingHost ph = new PingHost();
			ph.Show();
		}
		
		void Button_AnalizeClick(object sender, EventArgs e)
		{
			
		}
	}
}
