namespace WinInfo
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.dashboard = new System.Windows.Forms.TabPage();
            this.CPUPage = new System.Windows.Forms.TabPage();
            this.Log = new System.Windows.Forms.TabPage();
            this.H1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MinButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProgramVersion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TabControl1 = new FlatUI.FlatTabControl();
            this.tab_dash = new System.Windows.Forms.TabPage();
            this.OSVersion = new System.Windows.Forms.Label();
            this.NetworkDevice = new System.Windows.Forms.Label();
            this.SystemName = new System.Windows.Forms.Label();
            this.Processor = new System.Windows.Forms.Label();
            this.SoundDevice = new System.Windows.Forms.Label();
            this.GPU = new System.Windows.Forms.Label();
            this.InstalledRAM = new System.Windows.Forms.Label();
            this.tab_log = new System.Windows.Forms.TabPage();
            this.logbox = new System.Windows.Forms.ListBox();
            this.TabControl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.tab_dash.SuspendLayout();
            this.tab_log.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.dashboard);
            this.TabControl.Controls.Add(this.CPUPage);
            this.TabControl.Controls.Add(this.Log);
            this.TabControl.Font = new System.Drawing.Font("맑은 고딕", 13F);
            this.TabControl.Location = new System.Drawing.Point(584, 223);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(811, 399);
            this.TabControl.TabIndex = 0;
            // 
            // dashboard
            // 
            this.dashboard.BackColor = System.Drawing.Color.White;
            this.dashboard.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.dashboard.Location = new System.Drawing.Point(4, 32);
            this.dashboard.Name = "dashboard";
            this.dashboard.Padding = new System.Windows.Forms.Padding(3);
            this.dashboard.Size = new System.Drawing.Size(803, 363);
            this.dashboard.TabIndex = 0;
            this.dashboard.Text = "Dashboard";
            // 
            // CPUPage
            // 
            this.CPUPage.Location = new System.Drawing.Point(4, 32);
            this.CPUPage.Name = "CPUPage";
            this.CPUPage.Padding = new System.Windows.Forms.Padding(3);
            this.CPUPage.Size = new System.Drawing.Size(803, 363);
            this.CPUPage.TabIndex = 1;
            this.CPUPage.Text = "CPU";
            this.CPUPage.UseVisualStyleBackColor = true;
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(4, 32);
            this.Log.Name = "Log";
            this.Log.Padding = new System.Windows.Forms.Padding(3);
            this.Log.Size = new System.Drawing.Size(803, 363);
            this.Log.TabIndex = 2;
            this.Log.Text = "Log";
            this.Log.UseVisualStyleBackColor = true;
            // 
            // H1
            // 
            this.H1.AutoSize = true;
            this.H1.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.H1.Location = new System.Drawing.Point(68, 6);
            this.H1.Name = "H1";
            this.H1.Size = new System.Drawing.Size(114, 37);
            this.H1.TabIndex = 1;
            this.H1.Text = "WinInfo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.MinButton);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 10);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // MinButton
            // 
            this.MinButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.MinButton.FlatAppearance.BorderSize = 0;
            this.MinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinButton.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.MinButton.ForeColor = System.Drawing.Color.Black;
            this.MinButton.Location = new System.Drawing.Point(760, 0);
            this.MinButton.Name = "MinButton";
            this.MinButton.Size = new System.Drawing.Size(26, 10);
            this.MinButton.TabIndex = 5;
            this.MinButton.TabStop = false;
            this.MinButton.Text = "-";
            this.MinButton.UseVisualStyleBackColor = false;
            this.MinButton.Click += new System.EventHandler(this.MinButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Red;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.CloseButton.ForeColor = System.Drawing.Color.Black;
            this.CloseButton.Location = new System.Drawing.Point(786, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(26, 10);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.TabStop = false;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TabControl1);
            this.panel2.Controls.Add(this.ProgramVersion);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.TabControl);
            this.panel2.Controls.Add(this.H1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(811, 472);
            this.panel2.TabIndex = 3;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // ProgramVersion
            // 
            this.ProgramVersion.AutoSize = true;
            this.ProgramVersion.Location = new System.Drawing.Point(74, 41);
            this.ProgramVersion.Name = "ProgramVersion";
            this.ProgramVersion.Size = new System.Drawing.Size(99, 15);
            this.ProgramVersion.TabIndex = 3;
            this.ProgramVersion.Text = "version unknown";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // TabControl1
            // 
            this.TabControl1.ActiveColor = System.Drawing.Color.DodgerBlue;
            this.TabControl1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.TabControl1.Controls.Add(this.tab_dash);
            this.TabControl1.Controls.Add(this.tab_log);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TabControl1.ItemSize = new System.Drawing.Size(120, 40);
            this.TabControl1.Location = new System.Drawing.Point(0, 67);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(811, 405);
            this.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl1.TabIndex = 8;
            // 
            // tab_dash
            // 
            this.tab_dash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.tab_dash.Controls.Add(this.OSVersion);
            this.tab_dash.Controls.Add(this.NetworkDevice);
            this.tab_dash.Controls.Add(this.SystemName);
            this.tab_dash.Controls.Add(this.Processor);
            this.tab_dash.Controls.Add(this.SoundDevice);
            this.tab_dash.Controls.Add(this.GPU);
            this.tab_dash.Controls.Add(this.InstalledRAM);
            this.tab_dash.Location = new System.Drawing.Point(4, 44);
            this.tab_dash.Name = "tab_dash";
            this.tab_dash.Padding = new System.Windows.Forms.Padding(3);
            this.tab_dash.Size = new System.Drawing.Size(803, 357);
            this.tab_dash.TabIndex = 0;
            this.tab_dash.Text = "대시보드";
            // 
            // OSVersion
            // 
            this.OSVersion.AutoSize = true;
            this.OSVersion.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.OSVersion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OSVersion.Location = new System.Drawing.Point(7, 82);
            this.OSVersion.Name = "OSVersion";
            this.OSVersion.Size = new System.Drawing.Size(97, 19);
            this.OSVersion.TabIndex = 1;
            this.OSVersion.Text = "윈도우 버전 : ";
            // 
            // NetworkDevice
            // 
            this.NetworkDevice.AutoSize = true;
            this.NetworkDevice.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.NetworkDevice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NetworkDevice.Location = new System.Drawing.Point(7, 154);
            this.NetworkDevice.Name = "NetworkDevice";
            this.NetworkDevice.Size = new System.Drawing.Size(166, 19);
            this.NetworkDevice.TabIndex = 7;
            this.NetworkDevice.Text = "네트워크 장치 (연결됨) : ";
            // 
            // SystemName
            // 
            this.SystemName.AutoSize = true;
            this.SystemName.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.SystemName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SystemName.Location = new System.Drawing.Point(7, 10);
            this.SystemName.Name = "SystemName";
            this.SystemName.Size = new System.Drawing.Size(97, 19);
            this.SystemName.TabIndex = 2;
            this.SystemName.Text = "시스템 이름 : ";
            // 
            // Processor
            // 
            this.Processor.AutoSize = true;
            this.Processor.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.Processor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Processor.Location = new System.Drawing.Point(7, 34);
            this.Processor.Name = "Processor";
            this.Processor.Size = new System.Drawing.Size(78, 19);
            this.Processor.TabIndex = 3;
            this.Processor.Text = "프로세서 : ";
            // 
            // SoundDevice
            // 
            this.SoundDevice.AutoSize = true;
            this.SoundDevice.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.SoundDevice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SoundDevice.Location = new System.Drawing.Point(7, 130);
            this.SoundDevice.Name = "SoundDevice";
            this.SoundDevice.Size = new System.Drawing.Size(97, 19);
            this.SoundDevice.TabIndex = 6;
            this.SoundDevice.Text = "사운드 장치 : ";
            // 
            // GPU
            // 
            this.GPU.AutoSize = true;
            this.GPU.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.GPU.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GPU.Location = new System.Drawing.Point(7, 106);
            this.GPU.Name = "GPU";
            this.GPU.Size = new System.Drawing.Size(133, 19);
            this.GPU.TabIndex = 5;
            this.GPU.Text = "GPU (그래픽카드) : ";
            // 
            // InstalledRAM
            // 
            this.InstalledRAM.AutoSize = true;
            this.InstalledRAM.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.InstalledRAM.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InstalledRAM.Location = new System.Drawing.Point(7, 58);
            this.InstalledRAM.Name = "InstalledRAM";
            this.InstalledRAM.Size = new System.Drawing.Size(155, 19);
            this.InstalledRAM.TabIndex = 4;
            this.InstalledRAM.Text = "설치된 메모리 (RAM) : ";
            // 
            // tab_log
            // 
            this.tab_log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tab_log.Controls.Add(this.logbox);
            this.tab_log.Location = new System.Drawing.Point(4, 44);
            this.tab_log.Name = "tab_log";
            this.tab_log.Padding = new System.Windows.Forms.Padding(3);
            this.tab_log.Size = new System.Drawing.Size(803, 357);
            this.tab_log.TabIndex = 1;
            this.tab_log.Text = "로그";
            // 
            // logbox
            // 
            this.logbox.BackColor = System.Drawing.Color.DarkGray;
            this.logbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.logbox.Enabled = false;
            this.logbox.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.logbox.FormattingEnabled = true;
            this.logbox.ItemHeight = 19;
            this.logbox.Location = new System.Drawing.Point(3, 3);
            this.logbox.Name = "logbox";
            this.logbox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.logbox.Size = new System.Drawing.Size(797, 351);
            this.logbox.TabIndex = 0;
            this.logbox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.logbox_DrawItem);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(811, 482);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "WinInfo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TabControl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.tab_dash.ResumeLayout(false);
            this.tab_dash.PerformLayout();
            this.tab_log.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage dashboard;
        private System.Windows.Forms.TabPage CPUPage;
        private System.Windows.Forms.Label H1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label OSVersion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ProgramVersion;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button MinButton;
        private System.Windows.Forms.Label SystemName;
        private System.Windows.Forms.Label Processor;
        private System.Windows.Forms.Label InstalledRAM;
        private System.Windows.Forms.Label GPU;
        private System.Windows.Forms.Label SoundDevice;
        private System.Windows.Forms.Label NetworkDevice;
        private System.Windows.Forms.TabPage Log;
        private FlatUI.FlatTabControl TabControl1;
        private System.Windows.Forms.TabPage tab_dash;
        private System.Windows.Forms.TabPage tab_log;
        private System.Windows.Forms.ListBox logbox;
    }
}

