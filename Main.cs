using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.Threading;
using System.Net.Http;

namespace ipinfo
{
    public partial class Main : Form
    {

        private const string url = "https://api-ipv4.ip.sb/geoip";
        private const string networkError = "Network error";
        private const string space = " ";
        private bool down = false;
        private bool runFlag = true;
        private Point mousePoint;
        public Main()
        {
            InitializeComponent();
            this.Left = Screen.PrimaryScreen.WorkingArea.Right - this.Width;
            this.Top = Screen.PrimaryScreen.WorkingArea.Bottom - this.Height;
            new Thread(new ThreadStart(run)).Start();
        }

        private void run()
        {
            IPSB ipsb;
            object obj;
            while (runFlag)
            {
                obj = getIpInfo();
                if (obj != null)
                {
                    ipsb = (IPSB)obj;
                    this.Invoke(new Action(() =>
                    {
                        this.ipInfoLabel.Text = ipsb.Ip + space + ipsb.Organization;
                    }));
                }
                else
                {
                    this.Invoke(new Action(() =>
                    {
                        this.ipInfoLabel.Text = networkError;
                    }));
                }
                Thread.Sleep(5000);
            }
            Environment.Exit(0);
        }
        private object getIpInfo()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    using (var stream = client.GetStreamAsync(url).Result)
                    {
                        if (stream != null)
                        {
                            return new DataContractJsonSerializer(typeof(IPSB)).ReadObject(stream);
                        }
                    }
                }
                catch (Exception)
                {
                }
                return null;
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
