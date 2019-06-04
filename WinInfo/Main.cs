using System;
using System.Management;
using System.Windows.Forms;
using System.Reflection;
using System.Drawing;
using System.Drawing.Text;
using System.Net.NetworkInformation;
using FlatUI;

namespace WinInfo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region 창 드래그, 크기 조정 코드

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private const int cGrip = 16;
        private const int cCaption = 32;

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

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }

            base.WndProc(ref m);
        }

        #endregion

        

        public void AddLog(string logtext, Color color)
        {
            ColoredItem coloredItem = new ColoredItem { Color = color, Text = DateTime.Now.ToLongTimeString().ToString() + " : " + logtext };
            logbox.Items.Add(coloredItem);
        }

        class ColoredItem
        {
            public string Text;
            public Color Color;
        };

        private void MainForm_Load(object sender, EventArgs e)
        {
            // 코드 최적화 하기
            // 코드 최적화 하기
            // 코드 최적화 하기
            AddLog("프로그램 정상 로딩", Color.Blue);
            AddLog("버전 : " + Assembly.GetExecutingAssembly().GetName().Version.ToString(), Color.Blue);

            string username = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString();
            ProgramVersion.Text = "version " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
            ManagementObjectSearcher searcher;

            ManagementObjectSearcher GetWMI(string MainKey) {
               return searcher = new ManagementObjectSearcher("SELECT * FROM " + MainKey);
            }

            foreach (ManagementObject share in GetWMI("Win32_OperatingSystem").Get())
            {
                OSVersion.Text = OSVersion.Text + share["Caption"].ToString() + " " + share["Version"].ToString() + " (" + share["OSArchitecture"].ToString() + ")";
                InstalledRAM.Text = InstalledRAM.Text + Int32.Parse(share["TotalVisibleMemorySize"].ToString()) / 1000000 + "GB";
            }
            foreach (ManagementObject share in GetWMI("Win32_UserAccount").Get())
            {
                SystemName.Text = SystemName.Text + share["Fullname"].ToString();
            }
            SystemName.Text = SystemName.Text + " (" + username + ")";
            foreach (ManagementObject share in GetWMI("Win32_Processor").Get())
            {
                Processor.Text = Processor.Text + share["Name"].ToString() + " , " + share["NumberOfCores"].ToString() + " 코어, " + share["ThreadCount"].ToString() + " 논리 프로세서";
            }
            foreach (ManagementObject share in GetWMI("Win32_VideoController").Get())
            {
                GPU.Text = GPU.Text + share["Name"].ToString() + " (" + share["VideoModeDescription"].ToString().Split('x')[0] + "x" + share["VideoModeDescription"].ToString().Split('x')[1] + "x " + share["CurrentRefreshRate"] + "hz), " + Math.Floor(UInt32.Parse(share["AdapterRAM"].ToString()) / 1e+9) + "GB 메모리";
            }
            foreach (ManagementObject share in GetWMI("Win32_SoundDevice").Get())
            {
                SoundDevice.Text = SoundDevice.Text + share["Caption"].ToString() + ", ";
            }
            var networks = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface share in networks)
            {
                if (share.OperationalStatus.ToString() == "Up")
                {
                    NetworkDevice.Text = NetworkDevice.Text + share.Name + ", ";
                }
            }
            // 코드 최적화 하기
            // 코드 최적화 하기
            // 코드 최적화 하기
        }

        private void MinButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void logbox_DrawItem(object sender, DrawItemEventArgs e)
        {
            ColoredItem item = logbox.Items[e.Index] as ColoredItem;

            if (item != null)
            {
                e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
                e.Graphics.DrawString(item.Text, e.Font, new SolidBrush(item.Color), e.Bounds, StringFormat.GenericDefault);
            }
        }
    }
}
