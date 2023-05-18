namespace Webcam
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.sb = new System.Windows.Forms.StatusStrip();
			this.status = new System.Windows.Forms.ToolStripStatusLabel();
			this.msg = new System.Windows.Forms.ToolStripStatusLabel();
			this.pnlBody = new System.Windows.Forms.Panel();
			this.grpSettings = new System.Windows.Forms.GroupBox();
			this.btnInstallCpp = new System.Windows.Forms.Button();
			this.btnFolderBrowser = new System.Windows.Forms.Button();
			this.btnRunCustomURL = new System.Windows.Forms.Button();
			this.grpCaptureMode = new System.Windows.Forms.GroupBox();
			this.cboCaptureMode = new System.Windows.Forms.ComboBox();
			this.btnPauseCapturing = new System.Windows.Forms.Button();
			this.btnStartCapturing = new System.Windows.Forms.Button();
			this.btnTakeImage = new System.Windows.Forms.Button();
			this.grpCamera = new System.Windows.Forms.GroupBox();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnStop = new System.Windows.Forms.Button();
			this.btnWP = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.pbxOutput = new System.Windows.Forms.PictureBox();
			this.pbxCamera = new System.Windows.Forms.PictureBox();
			this.tt = new System.Windows.Forms.ToolTip(this.components);
			this.captureTimer = new System.Windows.Forms.Timer(this.components);
			this.statusTimer = new System.Windows.Forms.Timer(this.components);
			this.sb.SuspendLayout();
			this.pnlBody.SuspendLayout();
			this.grpSettings.SuspendLayout();
			this.grpCaptureMode.SuspendLayout();
			this.grpCamera.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbxOutput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxCamera)).BeginInit();
			this.SuspendLayout();
			// 
			// sb
			// 
			this.sb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status,
            this.msg});
			this.sb.Location = new System.Drawing.Point(0, 742);
			this.sb.Name = "sb";
			this.sb.Size = new System.Drawing.Size(958, 24);
			this.sb.SizingGrip = false;
			this.sb.TabIndex = 8;
			this.sb.Text = "statusStrip1";
			this.sb.DoubleClick += new System.EventHandler(this.status_DoubleClick);
			// 
			// status
			// 
			this.status.AutoSize = false;
			this.status.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.status.Name = "status";
			this.status.Size = new System.Drawing.Size(900, 19);
			this.status.Spring = true;
			this.status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.status.DoubleClick += new System.EventHandler(this.status_DoubleClick);
			// 
			// msg
			// 
			this.msg.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
			this.msg.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
			this.msg.Name = "msg";
			this.msg.Size = new System.Drawing.Size(43, 19);
			this.msg.Text = "Status";
			this.msg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnlBody
			// 
			this.pnlBody.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlBody.Controls.Add(this.grpSettings);
			this.pnlBody.Controls.Add(this.grpCaptureMode);
			this.pnlBody.Controls.Add(this.grpCamera);
			this.pnlBody.Controls.Add(this.btnWP);
			this.pnlBody.Controls.Add(this.btnExit);
			this.pnlBody.Controls.Add(this.pbxOutput);
			this.pnlBody.Controls.Add(this.pbxCamera);
			this.pnlBody.Location = new System.Drawing.Point(0, 0);
			this.pnlBody.Name = "pnlBody";
			this.pnlBody.Size = new System.Drawing.Size(958, 741);
			this.pnlBody.TabIndex = 9;
			// 
			// grpSettings
			// 
			this.grpSettings.Controls.Add(this.btnInstallCpp);
			this.grpSettings.Controls.Add(this.btnFolderBrowser);
			this.grpSettings.Controls.Add(this.btnRunCustomURL);
			this.grpSettings.Location = new System.Drawing.Point(8, 622);
			this.grpSettings.Name = "grpSettings";
			this.grpSettings.Size = new System.Drawing.Size(193, 79);
			this.grpSettings.TabIndex = 26;
			this.grpSettings.TabStop = false;
			this.grpSettings.Text = "Settings";
			// 
			// btnInstallCpp
			// 
			this.btnInstallCpp.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnInstallCpp.Image = global::Webcam.Properties.Resources.Setup_Installer__1_;
			this.btnInstallCpp.Location = new System.Drawing.Point(131, 19);
			this.btnInstallCpp.Name = "btnInstallCpp";
			this.btnInstallCpp.Size = new System.Drawing.Size(53, 50);
			this.btnInstallCpp.TabIndex = 18;
			this.tt.SetToolTip(this.btnInstallCpp, "Install 2008 C++ distro");
			this.btnInstallCpp.UseVisualStyleBackColor = true;
			this.btnInstallCpp.Click += new System.EventHandler(this.btnInstallCpp_Click);
			// 
			// btnFolderBrowser
			// 
			this.btnFolderBrowser.Image = global::Webcam.Properties.Resources.Folder___Bliss;
			this.btnFolderBrowser.Location = new System.Drawing.Point(13, 19);
			this.btnFolderBrowser.Name = "btnFolderBrowser";
			this.btnFolderBrowser.Size = new System.Drawing.Size(53, 50);
			this.btnFolderBrowser.TabIndex = 9;
			this.tt.SetToolTip(this.btnFolderBrowser, "Set folder to save picture to");
			this.btnFolderBrowser.UseVisualStyleBackColor = true;
			this.btnFolderBrowser.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnRunCustomURL
			// 
			this.btnRunCustomURL.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnRunCustomURL.Image = global::Webcam.Properties.Resources.Gear__6_;
			this.btnRunCustomURL.Location = new System.Drawing.Point(72, 19);
			this.btnRunCustomURL.Name = "btnRunCustomURL";
			this.btnRunCustomURL.Size = new System.Drawing.Size(53, 50);
			this.btnRunCustomURL.TabIndex = 16;
			this.tt.SetToolTip(this.btnRunCustomURL, "Launch protocol settings");
			this.btnRunCustomURL.UseVisualStyleBackColor = true;
			this.btnRunCustomURL.Click += new System.EventHandler(this.btnRunCustomURL_Click);
			// 
			// grpCaptureMode
			// 
			this.grpCaptureMode.Controls.Add(this.cboCaptureMode);
			this.grpCaptureMode.Controls.Add(this.btnPauseCapturing);
			this.grpCaptureMode.Controls.Add(this.btnStartCapturing);
			this.grpCaptureMode.Controls.Add(this.btnTakeImage);
			this.grpCaptureMode.Location = new System.Drawing.Point(346, 622);
			this.grpCaptureMode.Name = "grpCaptureMode";
			this.grpCaptureMode.Size = new System.Drawing.Size(139, 112);
			this.grpCaptureMode.TabIndex = 25;
			this.grpCaptureMode.TabStop = false;
			this.grpCaptureMode.Text = "Capture Mode";
			this.grpCaptureMode.Visible = false;
			// 
			// cboCaptureMode
			// 
			this.cboCaptureMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboCaptureMode.FormattingEnabled = true;
			this.cboCaptureMode.Items.AddRange(new object[] {
            "Single",
            "Continuous"});
			this.cboCaptureMode.Location = new System.Drawing.Point(10, 19);
			this.cboCaptureMode.Name = "cboCaptureMode";
			this.cboCaptureMode.Size = new System.Drawing.Size(121, 21);
			this.cboCaptureMode.TabIndex = 19;
			this.cboCaptureMode.Visible = false;
			this.cboCaptureMode.SelectedIndexChanged += new System.EventHandler(this.cboCaptureMode_SelectedIndexChanged);
			// 
			// btnPauseCapturing
			// 
			this.btnPauseCapturing.Image = global::Webcam.Properties.Resources.Pause;
			this.btnPauseCapturing.Location = new System.Drawing.Point(69, 46);
			this.btnPauseCapturing.Name = "btnPauseCapturing";
			this.btnPauseCapturing.Size = new System.Drawing.Size(53, 50);
			this.btnPauseCapturing.TabIndex = 21;
			this.btnPauseCapturing.UseVisualStyleBackColor = true;
			this.btnPauseCapturing.Visible = false;
			this.btnPauseCapturing.Click += new System.EventHandler(this.btnPauseCapturing_Click);
			// 
			// btnStartCapturing
			// 
			this.btnStartCapturing.Image = global::Webcam.Properties.Resources.Play__3_;
			this.btnStartCapturing.Location = new System.Drawing.Point(10, 46);
			this.btnStartCapturing.Name = "btnStartCapturing";
			this.btnStartCapturing.Size = new System.Drawing.Size(53, 50);
			this.btnStartCapturing.TabIndex = 20;
			this.btnStartCapturing.UseVisualStyleBackColor = true;
			this.btnStartCapturing.Visible = false;
			this.btnStartCapturing.Click += new System.EventHandler(this.btnStartCapturing_Click);
			// 
			// btnTakeImage
			// 
			this.btnTakeImage.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnTakeImage.Image = global::Webcam.Properties.Resources.Picture__65_;
			this.btnTakeImage.Location = new System.Drawing.Point(10, 46);
			this.btnTakeImage.Name = "btnTakeImage";
			this.btnTakeImage.Size = new System.Drawing.Size(53, 50);
			this.btnTakeImage.TabIndex = 10;
			this.tt.SetToolTip(this.btnTakeImage, "Take picture");
			this.btnTakeImage.UseVisualStyleBackColor = true;
			this.btnTakeImage.Visible = false;
			this.btnTakeImage.Click += new System.EventHandler(this.button2_Click);
			// 
			// grpCamera
			// 
			this.grpCamera.Controls.Add(this.btnStart);
			this.grpCamera.Controls.Add(this.btnStop);
			this.grpCamera.Location = new System.Drawing.Point(205, 622);
			this.grpCamera.Name = "grpCamera";
			this.grpCamera.Size = new System.Drawing.Size(135, 75);
			this.grpCamera.TabIndex = 24;
			this.grpCamera.TabStop = false;
			this.grpCamera.Text = "Camera";
			// 
			// btnStart
			// 
			this.btnStart.Image = global::Webcam.Properties.Resources.Start_Sign;
			this.btnStart.Location = new System.Drawing.Point(12, 19);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(53, 50);
			this.btnStart.TabIndex = 13;
			this.tt.SetToolTip(this.btnStart, "Start webcam");
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.button4_Click);
			// 
			// btnStop
			// 
			this.btnStop.Image = global::Webcam.Properties.Resources.Stop_Sign;
			this.btnStop.Location = new System.Drawing.Point(71, 19);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(53, 50);
			this.btnStop.TabIndex = 12;
			this.tt.SetToolTip(this.btnStop, "Stop webcam");
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Visible = false;
			this.btnStop.Click += new System.EventHandler(this.button3_Click);
			// 
			// btnWP
			// 
			this.btnWP.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnWP.Image = global::Webcam.Properties.Resources.Wordpress;
			this.btnWP.Location = new System.Drawing.Point(891, 612);
			this.btnWP.Name = "btnWP";
			this.btnWP.Size = new System.Drawing.Size(53, 50);
			this.btnWP.TabIndex = 17;
			this.tt.SetToolTip(this.btnWP, "Send image to server");
			this.btnWP.UseVisualStyleBackColor = true;
			this.btnWP.Visible = false;
			this.btnWP.Click += new System.EventHandler(this.btnWP_Click);
			// 
			// btnExit
			// 
			this.btnExit.Image = global::Webcam.Properties.Resources.X__9_;
			this.btnExit.Location = new System.Drawing.Point(870, 668);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(74, 66);
			this.btnExit.TabIndex = 15;
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
			// 
			// pbxOutput
			// 
			this.pbxOutput.BackColor = System.Drawing.SystemColors.ControlDark;
			this.pbxOutput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pbxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbxOutput.Location = new System.Drawing.Point(8, 3);
			this.pbxOutput.Name = "pbxOutput";
			this.pbxOutput.Size = new System.Drawing.Size(948, 598);
			this.pbxOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbxOutput.TabIndex = 14;
			this.pbxOutput.TabStop = false;
			// 
			// pbxCamera
			// 
			this.pbxCamera.BackColor = System.Drawing.SystemColors.ControlDark;
			this.pbxCamera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbxCamera.Location = new System.Drawing.Point(3, 3);
			this.pbxCamera.Name = "pbxCamera";
			this.pbxCamera.Size = new System.Drawing.Size(948, 598);
			this.pbxCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbxCamera.TabIndex = 8;
			this.pbxCamera.TabStop = false;
			// 
			// captureTimer
			// 
			this.captureTimer.Interval = 1500;
			this.captureTimer.Tick += new System.EventHandler(this.captureTimer_Tick);
			// 
			// statusTimer
			// 
			this.statusTimer.Interval = 1500;
			this.statusTimer.Tick += new System.EventHandler(this.statusTimer_Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(958, 766);
			this.Controls.Add(this.pnlBody);
			this.Controls.Add(this.sb);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Cypherion - Webcam";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.sb.ResumeLayout(false);
			this.sb.PerformLayout();
			this.pnlBody.ResumeLayout(false);
			this.grpSettings.ResumeLayout(false);
			this.grpCaptureMode.ResumeLayout(false);
			this.grpCamera.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbxOutput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxCamera)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.StatusStrip sb;
		private System.Windows.Forms.ToolStripStatusLabel status;
		private System.Windows.Forms.Panel pnlBody;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnTakeImage;
		private System.Windows.Forms.Button btnFolderBrowser;
		private System.Windows.Forms.PictureBox pbxCamera;
		private System.Windows.Forms.PictureBox pbxOutput;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.ToolTip tt;
		private System.Windows.Forms.ToolStripStatusLabel msg;
		private System.Windows.Forms.Button btnRunCustomURL;
		private System.Windows.Forms.Button btnWP;
		private System.Windows.Forms.Button btnInstallCpp;
		private System.Windows.Forms.Timer captureTimer;
		private System.Windows.Forms.Button btnPauseCapturing;
		private System.Windows.Forms.Button btnStartCapturing;
		private System.Windows.Forms.ComboBox cboCaptureMode;
		private System.Windows.Forms.GroupBox grpSettings;
		private System.Windows.Forms.GroupBox grpCaptureMode;
		private System.Windows.Forms.GroupBox grpCamera;
		private System.Windows.Forms.Timer statusTimer;
	}
}

