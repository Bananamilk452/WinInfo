using System;
using System.Management;
using System.Windows.Forms;

namespace WinInfo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from " + "Win32_OperatingSystem");
            foreach (ManagementObject share in searcher.Get())
            {
                OSVersion.Text = OSVersion.Text + share["Caption"].ToString() + " " + share["Version"].ToString();
            }
        }

    }
}
