using System;
using System.Management;
using System.Windows.Forms;
using System.Reflection;

namespace WinInfo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region 창 드래그 코드

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            ProgramVersion.Text = "version " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from " + "Win32_OperatingSystem");
            foreach (ManagementObject share in searcher.Get())
            {
                OSVersion.Text = OSVersion.Text + share["Caption"].ToString() + " " + share["Version"].ToString();
            }
        }

        private void MinButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
