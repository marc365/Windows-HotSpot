using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace HotSpot
{
    public partial class HotSpot : Form
    {
        internal ProcessStartInfo start;
        internal Process p;
        internal RegistryKey registry;
        public HotSpot()
        {
            InitializeComponent();
            registry = Registry.CurrentUser.OpenSubKey("HotSpot");
            if (registry != null)
            {
                ssid.Text = registry.GetValue("ssid", null).ToString();
                key.Text = registry.GetValue("key", null).ToString();
            }

            textBox1.Text += Netsh("wlan show hostednetwork");
        }

        private string Netsh(string arg)
        {
            p = new Process();
            start = new ProcessStartInfo();
            start.Arguments = arg;
            start.FileName = "netsh";
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            start.CreateNoWindow = true;

            p.StartInfo = start;

            p.Start();
            return p.StandardOutput.ReadToEnd();
        }
        private void button_Click(object sender, EventArgs e)
        {
            registry = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("HotSpot");
            registry.SetValue("ssid", ssid.Text);
            registry.SetValue("key", key.Text);
            registry.Close();

            textBox1.Text += Netsh(string.Format("wlan set hostednetwork ssid={0} key={1}", ssid.Text, key.Text));
            textBox1.Text += Netsh("wlan start hostednetwork");
            textBox1.Text += Netsh("wlan show hostednetwork");
            textBox1.Text += "Now >> Open Network and Sharing Centre >> click your Internet Public Network >> properties button >> Sharing Tab >> Allow other network user to connect through this internet connection >> choose the new hosted wifi network.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += Netsh("wlan stop hostednetwork");
            textBox1.Text += Netsh("wlan show hostednetwork");
        }

    }
}
