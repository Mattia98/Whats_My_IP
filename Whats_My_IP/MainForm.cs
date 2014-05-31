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
	/// MainForm ist die Hauptform des Programmes.
	/// Hier wird die Hauptarbeit gemacht.
	/// Die anderen Formen dienen nur zur Informationsbeschaffung über den Benutzer.
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
		string[] aInfo = new string[4];//Gesplittete Json-Datei
		string aHost = "http://ip-api.com/json";//Json-Hoster
		public static string bHost = "www.google.com";//Ping-Hoster
		public static string aIP;//Benutzerdefinierte IP-Adresse
		public static bool aAnalisiere = true;//Soll Programm IP vom Web holen(false). Soll Programm IP analisieren(true).
		int aPing;//Ping von GetPing()
		
		
		void MainFormLoad(object sender, EventArgs e)
		{
<<<<<<< HEAD
			Go();
=======
			button_GetIP.Enabled = false;
			backgroundWorker_GetIP.RunWorkerAsync();
			
>>>>>>> parent of b3eefd5... v1.3.1 BETA
		}
		
		void Button_GetIPClick(object sender, EventArgs e)
		{
<<<<<<< HEAD
			Go();
=======
			button_GetIP.Enabled = false;
			if(aAnalisiere)
				aHost = aHost+"/"+aIP;//Füge benutzerdefinierte IP-Adresse
			backgroundWorker_GetIP.RunWorkerAsync();
			
>>>>>>> parent of b3eefd5... v1.3.1 BETA
		}
		
		string GetJson(string host)
		{
			string IP;
			using(WebClient client = new WebClient()) {
  					IP = client.DownloadString(host);
				}
<<<<<<< HEAD
			return Json;
		}
		
		public void Go()
		{
			
			InvertButtonStatus();
			
			backgroundWorker_Main.RunWorkerAsync();
		}
		
		void InvertButtonStatus()
		{
			if(button_Go.Enabled)
			{
				button_Go.Enabled = false;
				button_PingHost.Enabled = false;
				button_Analize.Enabled = false;
			}
			else
			{
				button_Go.Enabled = true;
				button_PingHost.Enabled = true;
				button_Analize.Enabled = true;
			}
=======
			return IP;
>>>>>>> parent of b3eefd5... v1.3.1 BETA
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
<<<<<<< HEAD
			using (Ping p = new Ping()) 
			{
				int[] pings = new int[10];
				int zwischensumme = 0;
				MessageBox.Show(pings.Length.ToString());
				for (int i = 0; i == pings.Length; i++)
				{
					pings[i] = Convert.ToInt32(p.Send(bHost).RoundtripTime);
					if(pings[1]==0)
						break;
					toolStripStatusLabel_Status.Text = "Teste Ping über \""+bHost+"\"... ("+i.ToString()+" von 10)";
				}
				for (int i = 0; i < pings.Length; i++) 
				{
					zwischensumme = zwischensumme+pings[i];
				}
				ping = zwischensumme/pings.Length;
=======
			using (Ping p = new Ping()) {
				ping = Convert.ToInt32(p.Send(bHost).RoundtripTime);
>>>>>>> parent of b3eefd5... v1.3.1 BETA
			}
			return ping;
		}
		
		void RefreshUI()
		{
			label_IP.Text = aInfo[0];
			label_ISP.Text = aInfo[3];
			label_Location.Text = aInfo[1];
			if(aPing==0)
				label_Ping.Text = "Kein Ping!";
			else
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
				//OK
				toolStripStatusLabel_Status.Text = "Fertig! (Json-Host: \""+aHost+"\", Ping-Host: \""+bHost+"\")";
			}
			catch (Exception ex) 
			{
				toolStripStatusLabel_Status.Text = "Fehler: "+ ex.Message;
				MessageBox.Show(ex.Message, "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				aHost="http://ip-api.com/json";
			}
			
		}
		
		void BackgroundWorker_GetIPRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
<<<<<<< HEAD
			if(e.Error == null)
			{
				RefreshUI();
				InvertButtonStatus();
			}
			else
			{
				toolStripStatusLabel_Status.Text = "Fehler: "+ e.Error.Message;
				MessageBox.Show(e.Error.Message, "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
=======
			RefreshUI();
>>>>>>> parent of b3eefd5... v1.3.1 BETA
			aHost="http://ip-api.com/json";
			button_GetIP.Enabled = true;
		}
		
		void Button_PingHostClick(object sender, EventArgs e)//Öffne den PingHost-Form um den PingHost vom Benutzer zu krigen.
		{
			PingHost ph = new PingHost();
			ph.Show();
		}
		
		void Button_AnalizeClick(object sender, EventArgs e)//Öffne den OtherIP-Form um eine zu analisierende IP-Adresse zu krigen.
		{
			OtherIP oip = new OtherIP();
			oip.Show();
		}
	}
}
