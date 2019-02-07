﻿namespace WinInfo
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
            this.OSVersion = new System.Windows.Forms.Label();
            this.CPUPage = new System.Windows.Forms.TabPage();
            this.H1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MinButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProgramVersion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TabControl.SuspendLayout();
            this.dashboard.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.dashboard);
            this.TabControl.Controls.Add(this.CPUPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TabControl.Font = new System.Drawing.Font("맑은 고딕", 13F);
            this.TabControl.Location = new System.Drawing.Point(0, 83);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(811, 399);
            this.TabControl.TabIndex = 0;
            // 
            // dashboard
            // 
            this.dashboard.Controls.Add(this.OSVersion);
            this.dashboard.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.dashboard.Location = new System.Drawing.Point(4, 32);
            this.dashboard.Name = "dashboard";
            this.dashboard.Padding = new System.Windows.Forms.Padding(3);
            this.dashboard.Size = new System.Drawing.Size(803, 363);
            this.dashboard.TabIndex = 0;
            this.dashboard.Text = "Dashboard";
            this.dashboard.UseVisualStyleBackColor = true;
            // 
            // OSVersion
            // 
            this.OSVersion.AutoSize = true;
            this.OSVersion.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.OSVersion.Location = new System.Drawing.Point(3, 12);
            this.OSVersion.Name = "OSVersion";
            this.OSVersion.Size = new System.Drawing.Size(97, 19);
            this.OSVersion.TabIndex = 1;
            this.OSVersion.Text = "윈도우 버전 : ";
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
            this.panel2.Controls.Add(this.ProgramVersion);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.H1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(811, 73);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(811, 482);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TabControl);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "WinInfo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TabControl.ResumeLayout(false);
            this.dashboard.ResumeLayout(false);
            this.dashboard.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}

