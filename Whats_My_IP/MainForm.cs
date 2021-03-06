﻿/*
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
			Main();
		}
		
		void Button_GetIPClick(object sender, EventArgs e)
		{
			Main();
		}
		
		string GetJson(string host)
		{
			string Json;
			using(WebClient client = new WebClient()) {
  					Json = client.DownloadString(host);
				}
			return Json;
		}
		
		public void Main()
		{
			InvertButtonStatus();
			
			backgroundWorker_Main.RunWorkerAsync();
		}
		
		void InvertButtonStatus()
		{
			
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
			using (Ping p = new Ping()) 
			{
				int[] pings = new int[10];
				int zwischensumme = 0;
				for (int i = 0; i < pings.Length; i++)
				{
					pings[i] = Convert.ToInt32(p.Send(bHost).RoundtripTime);
					toolStripStatusLabel_Status.Text = "Teste Ping über \""+bHost+"\"... ("+i.ToString()+" von 10)";
				}
				for (int i = 0; i < pings.Length; i++) 
				{
					zwischensumme = zwischensumme+pings[i];
				}
				ping = zwischensumme/pings.Length;
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
		
		void BackgroundWorker_MainDoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			BackgroundWorker worker = sender as BackgroundWorker;
			
			/*try 
			{*/
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
			/*}
			catch (Exception ex) 
			{
			
			}*/
			
		}
		
		void BackgroundWorker_MainRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if(e.Error == null)
			{
				RefreshUI();
				button_GetIP.Enabled = true;
			}
			else
			{
				toolStripStatusLabel_Status.Text = "Fehler: "+ e.Error.Message;
				MessageBox.Show(e.Error.Message, "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			aHost="http://ip-api.com/json";
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
