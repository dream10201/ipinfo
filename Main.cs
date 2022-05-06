﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.Threading;
using System.Net.Http;
using System.Net.NetworkInformation;

namespace ipinfo
{
    delegate void SetLabelTextCallback(string text, Label label);
    public partial class Main : Form
    {
        private const string url = "https://api-ipv4.ip.sb/geoip";
        private const string networkError = "Network error";
        private const string B = "{0:G}B/s";
        private const string KB = "{0:G}KB/s";
        private const string MB = "{0:G}MB/s";
        private const string GB = "{0:G}GB/s";
        private const string TB = "{0:G}TB/s";
        private const string PB = "{0:G}PB/s";
        private const string EB = "{0:G}EB/s";
        private const string ZB = "{0:G}ZB/s";
        private const string YB = "{0:G}YB/s";
        private const string BB = "{0:G}BB/s";
        private const string NB = "{0:G}NB/s";
        private const string DB = "{0:G}DB/s";
        private const string CB = "{0:G}CB/s";


        private const double BInterval = 1024d;
        private const double KBInterval = 1024d * 1024;
        private const double MBInterval = 1024d * 1024 * 1024;
        private const double GBInterval = 1024d * 1024 * 1024 * 1024;
        private const double TBInterval = 1024d * 1024 * 1024 * 1024 * 1024;
        private const double PBInterval = 1024d * 1024 * 1024 * 1024 * 1024 * 1024;
        private const double EBInterval = 1024d * 1024 * 1024 * 1024 * 1024 * 1024 * 1024;
        private const double ZBInterval = 1024d * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024;
        private const double YBInterval = 1024d * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024;
        private const double BBInterval = 1024d * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024;
        private const double NBInterval = 1024d * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024;
        private const double DBInterval = 1024d * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024;
        private const double CBInterval = 1024d * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024;
        private bool down = false;
        private bool runFlag = true;
        private Point mousePoint;
        SetLabelTextCallback setLabelTextCallback;
        public Main()
        {
            InitializeComponent();
            setLabelTextCallback = UpdateLabelText;
            this.Left = Screen.PrimaryScreen.WorkingArea.Right - this.Width;
            this.Top = Screen.PrimaryScreen.WorkingArea.Bottom - this.Height;
            new Thread(new ThreadStart(run)).Start();
            new Thread(new ThreadStart(speed)).Start();
        }
        private void speed()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            IPv4InterfaceStatistics ipv4Statistics;
            //long lastSendCount = 0;
            long lastRevCount = 0;
            long sendCount;
            long revCount;
            //long SendSpeed;
            long RevSpeed;
            string cache = string.Empty;
            int limit = 1000;
            while (runFlag)
            {
                sendCount = 0;
                revCount = 0;
                try
                {
                    foreach (NetworkInterface adapter in nics)
                    {
                        ipv4Statistics = adapter.GetIPv4Statistics();
                        sendCount += ipv4Statistics.BytesSent;
                        revCount += ipv4Statistics.BytesReceived;
                    }
                }
                catch (Exception ex)
                {
                    nics = NetworkInterface.GetAllNetworkInterfaces();
                    continue;
                }
                //SendSpeed = sendCount - lastSendCount;
                RevSpeed = revCount - lastRevCount;
                //var SendCount = (sendCount / 1024 / 1024).ToString(); 
                //var RevCount = (revCount / 1024 / 1024).ToString();
                lastRevCount = revCount;
                //lastSendCount = sendCount;
                if (RevSpeed < BInterval)
                {
                    cache = String.Format(B, RevSpeed);
                }
                else if (RevSpeed < KBInterval)
                {
                    cache = String.Format(KB, Math.Round(RevSpeed / 1024d, 2));
                }
                else if (RevSpeed < MBInterval)
                {
                    cache = String.Format(MB, Math.Round(RevSpeed / 1024d / 1024, 2));
                }
                else if (RevSpeed < GBInterval)
                {
                    cache = String.Format(GB, Math.Round(RevSpeed / 1024d / 1024 / 1024, 2));
                }
                else if (RevSpeed < TBInterval)
                {
                    cache = String.Format(TB, Math.Round(RevSpeed / 1024d / 1024 / 1024 / 1024, 2));
                }
                else if (RevSpeed < PBInterval)
                {
                    cache = String.Format(PB, Math.Round(RevSpeed / 1024d / 1024 / 1024 / 1024 / 1024, 2));
                }
                else if (RevSpeed < EBInterval)
                {
                    cache = String.Format(EB, Math.Round(RevSpeed / 1024d / 1024 / 1024 / 1024 / 1024 / 1024, 2));
                }
                else if (RevSpeed < ZBInterval)
                {
                    cache = String.Format(ZB, Math.Round(RevSpeed / 1024d / 1024 / 1024 / 1024 / 1024 / 1024 / 1024, 2));
                }
                else if (RevSpeed < YBInterval)
                {
                    cache = String.Format(YB, Math.Round(RevSpeed / 1024d / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024, 2));
                }
                else if (RevSpeed < BBInterval)
                {
                    cache = String.Format(BB, Math.Round(RevSpeed / 1024d / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024, 2));
                }
                else if (RevSpeed < NBInterval)
                {
                    cache = String.Format(NB, Math.Round(RevSpeed / 1024d / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024, 2));
                }
                else if (RevSpeed < DBInterval)
                {
                    cache = String.Format(DB, Math.Round(RevSpeed / 1024d / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024, 2));
                }
                else if (RevSpeed < CBInterval)
                {
                    cache = String.Format(CB, Math.Round(RevSpeed / 1024d / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024, 2));
                }
                UpdateLabelText(cache, this.speedLabel);
                Thread.Sleep(limit);
            }
        }
        private void UpdateLabelText(string text, Label label)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(setLabelTextCallback, text, label);
            }
            else
            {
                label.Text = text;
            }
        }
        private void run()
        {
            IPSB ipsb;
            int limit = 5000;
            while (runFlag)
            {
                ipsb = getIpInfo();
                if (ipsb != null)
                {
                    UpdateLabelText(ipsb.Organization, this.ipInfoLabel);
                    UpdateLabelText(ipsb.Ip, this.ip);
                }
                else
                {
                    UpdateLabelText(networkError, this.ipInfoLabel);
                }
                Thread.Sleep(limit);
            }
        }
        private IPSB getIpInfo()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    using (var stream = client.GetStreamAsync(url))
                    {
                        stream.Wait();
                        if (stream.IsCompleted)
                        {
                            return (IPSB)new DataContractJsonSerializer(typeof(IPSB)).ReadObject(stream.Result);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
            return null;

        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    down = true;
                    mousePoint.X = e.X;
                    mousePoint.Y = e.Y;
                    break;
                case MouseButtons.Right:
                    runFlag = false;
                    Environment.Exit(0);
                    break;
            }
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (down && e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mousePoint.X, this.Location.Y + e.Y - mousePoint.Y); ;
            }
        }

        private void Main_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                down = false;
            }
        }
    }
}
