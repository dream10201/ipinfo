using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.Threading;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.IO;
using ipinfo.bean;
using System.Text;

namespace ipinfo
{
    delegate void SetLabelTextCallback(string text, Label label);
    public partial class Main : Form
    {
        private const int networkDelay = 5000;
        private const int speedDealy = 1000;
        private HttpClient client;
        private Task<Stream> stream;
        private const string B = "B/s";
        private const string KB = "KB/s";
        private const string MB = "MB/s";
        private const string GB = "GB/s";
        private const string TB = "TB/s";
        private const string PB = "PB/s";
        private const string EB = "EB/s";
        private const string ZB = "ZB/s";
        private const string YB = "YB/s";
        private const string BB = "BB/s";
        private const string NB = "NB/s";
        private const string DB = "DB/s";
        private const string CB = "CB/s";


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
        //private const double CBInterval = 1024d * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024;
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
            IPv4InterfaceStatistics ipv4Statistics;
            NetworkInterface[] nics;
            //long lastSendCount = 0;
            long lastRevCount = 0;
            long sendCount;
            long revCount;
            int i;
            //long SendSpeed;
            long RevSpeed;
            StringBuilder speedCache = new StringBuilder();
            while (runFlag)
            {
                sendCount = 0;
                revCount = 0;
                nics = NetworkInterface.GetAllNetworkInterfaces();
                try
                {
                    for (i = 0; i < nics.Length; i++)
                    {
                        ipv4Statistics = nics[i].GetIPv4Statistics();
                        sendCount += ipv4Statistics.BytesSent;
                        revCount += ipv4Statistics.BytesReceived;
                    }
                }
                catch (Exception)
                {
                    Thread.Sleep(speedDealy);
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
                    speedCache.Append(RevSpeed);
                    speedCache.Append(B);
                }
                else if (RevSpeed < KBInterval)
                {
                    speedCache.Append(Math.Round(RevSpeed / 1024d, 2));
                    speedCache.Append(KB);
                }
                else if (RevSpeed < MBInterval)
                {
                    speedCache.Append(Math.Round(RevSpeed / 1024d / 1024, 2));
                    speedCache.Append(MB);
                }
                else if (RevSpeed < GBInterval)
                {
                    speedCache.Append(Math.Round(RevSpeed / 1024d / 1024 / 1024, 2));
                    speedCache.Append(GB);
                }
                else if (RevSpeed < TBInterval)
                {
                    speedCache.Append(Math.Round(RevSpeed / 1024d / 1024 / 1024 / 1024, 2));
                    speedCache.Append(TB);
                }
                else if (RevSpeed < PBInterval)
                {
                    speedCache.Append(Math.Round(RevSpeed / 1024d / 1024 / 1024 / 1024 / 1024, 2));
                    speedCache.Append(PB);
                }
                else if (RevSpeed < EBInterval)
                {
                    speedCache.Append(Math.Round(RevSpeed / 1024d / 1024 / 1024 / 1024 / 1024 / 1024, 2));
                    speedCache.Append(EB);
                }
                else if (RevSpeed < ZBInterval)
                {
                    speedCache.Append(Math.Round(RevSpeed / 1024d / 1024 / 1024 / 1024 / 1024 / 1024 / 1024, 2));
                    speedCache.Append(ZB);
                }
                else if (RevSpeed < YBInterval)
                {
                    speedCache.Append(Math.Round(RevSpeed / 1024d / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024, 2));
                    speedCache.Append(YB);
                }
                else if (RevSpeed < BBInterval)
                {
                    speedCache.Append(Math.Round(RevSpeed / 1024d / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024, 2));
                    speedCache.Append(BB);
                }
                else if (RevSpeed < NBInterval)
                {
                    speedCache.Append(Math.Round(RevSpeed / 1024d / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024, 2));
                    speedCache.Append(NB);
                }
                else if (RevSpeed < DBInterval)
                {
                    speedCache.Append(Math.Round(RevSpeed / 1024d / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024, 2));
                    speedCache.Append(DB);
                }
                else// if (RevSpeed < CBInterval)
                {
                    speedCache.Append(Math.Round(RevSpeed / 1024d / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024, 2));
                    speedCache.Append(CB);
                }
                UpdateLabelText(speedCache.ToString(), this.speedLabel);
                speedCache.Clear();
                Thread.Sleep(speedDealy);
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
            IpApi ipapi;
            Ipsb ipsb;
            Ipwho ipwho;
            StringBuilder ip = new StringBuilder();
            StringBuilder info = new StringBuilder();
            while (runFlag)
            {
                for (; ; )
                {
                    using (client = new HttpClient())
                    {
                        try
                        {
                            using (stream = client.GetStreamAsync(Ipwho.url))
                            {

                                stream.Wait();
                                if (stream.IsCompleted)
                                {
                                    ipwho = (Ipwho)new DataContractJsonSerializer(typeof(Ipwho)).ReadObject(stream.Result);
                                    ip.Append(ipwho.Ip);
                                    info.Append(ipwho.Connection.Org);
                                    break;
                                }
                            }
                        }
                        catch { }
                        try
                        {
                            using (stream = client.GetStreamAsync(Ipsb.url))
                            {

                                stream.Wait();
                                if (stream.IsCompleted)
                                {
                                    ipsb = (Ipsb)new DataContractJsonSerializer(typeof(Ipsb)).ReadObject(stream.Result);
                                    ip.Append(ipsb.Ip);
                                    info.Append(ipsb.AsnOrganization);
                                    break;
                                }
                            }
                        }
                        catch { }
                        try
                        {
                            using (stream = client.GetStreamAsync(IpApi.url))
                            {

                                stream.Wait();
                                if (stream.IsCompleted)
                                {
                                    ipapi = (IpApi)new DataContractJsonSerializer(typeof(IpApi)).ReadObject(stream.Result);
                                    ip.Append(ipapi.Query);
                                    info.Append(ipapi.Isp);
                                    break;
                                }
                            }
                        }
                        catch { }
                    }
                    Thread.Sleep(networkDelay);
                }
                UpdateLabelText(info.ToString(), this.ipInfoLabel);
                UpdateLabelText(ip.ToString(), this.ip);
                info.Clear();
                ip.Clear();
                Thread.Sleep(networkDelay);
            }
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
