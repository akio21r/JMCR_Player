﻿namespace JMCR
{
	partial class frmPair
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPair));
			this.lblSchoolL = new System.Windows.Forms.Label();
			this.lblSchoolR = new System.Windows.Forms.Label();
			this.lblNameL = new System.Windows.Forms.Label();
			this.lblNameR = new System.Windows.Forms.Label();
			this.lblCarL = new System.Windows.Forms.Label();
			this.lblCarR = new System.Windows.Forms.Label();
			this.pctVS = new System.Windows.Forms.PictureBox();
			this.pctR = new System.Windows.Forms.PictureBox();
			this.pctL = new System.Windows.Forms.PictureBox();
			this.pctBackImage = new System.Windows.Forms.PictureBox();
			this.lblL = new System.Windows.Forms.Label();
			this.lblR = new System.Windows.Forms.Label();
			this.lblCount = new System.Windows.Forms.Label();
			this.pctWinL = new System.Windows.Forms.PictureBox();
			this.pctWinR = new System.Windows.Forms.PictureBox();
			this.lblTitle = new System.Windows.Forms.Label();
			this.pctSchool = new System.Windows.Forms.PictureBox();
			this.lblCount2 = new System.Windows.Forms.Label();
			this.lblCourse1 = new System.Windows.Forms.Label();
			this.lblCourse2 = new System.Windows.Forms.Label();
			this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pctVS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pctR)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pctL)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pctBackImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pctWinL)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pctWinR)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pctSchool)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblSchoolL
			// 
			this.lblSchoolL.AutoSize = true;
			this.lblSchoolL.BackColor = System.Drawing.Color.MidnightBlue;
			this.lblSchoolL.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblSchoolL.Font = new System.Drawing.Font("MS UI Gothic", 18F);
			this.lblSchoolL.ForeColor = System.Drawing.Color.Yellow;
			this.lblSchoolL.Location = new System.Drawing.Point(13, 433);
			this.lblSchoolL.Name = "lblSchoolL";
			this.lblSchoolL.Size = new System.Drawing.Size(82, 24);
			this.lblSchoolL.TabIndex = 4;
			this.lblSchoolL.Text = "高校名";
			this.lblSchoolL.Click += new System.EventHandler(this.lblSchoolL_Click);
			// 
			// lblSchoolR
			// 
			this.lblSchoolR.AutoSize = true;
			this.lblSchoolR.BackColor = System.Drawing.Color.MidnightBlue;
			this.lblSchoolR.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblSchoolR.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lblSchoolR.ForeColor = System.Drawing.Color.Yellow;
			this.lblSchoolR.Location = new System.Drawing.Point(610, 433);
			this.lblSchoolR.Name = "lblSchoolR";
			this.lblSchoolR.Size = new System.Drawing.Size(82, 24);
			this.lblSchoolR.TabIndex = 4;
			this.lblSchoolR.Text = "高校名";
			this.lblSchoolR.Click += new System.EventHandler(this.lblSchoolR_Click);
			// 
			// lblNameL
			// 
			this.lblNameL.AutoSize = true;
			this.lblNameL.BackColor = System.Drawing.Color.MidnightBlue;
			this.lblNameL.Font = new System.Drawing.Font("MS UI Gothic", 18F);
			this.lblNameL.ForeColor = System.Drawing.Color.Yellow;
			this.lblNameL.Location = new System.Drawing.Point(13, 470);
			this.lblNameL.Name = "lblNameL";
			this.lblNameL.Size = new System.Drawing.Size(58, 24);
			this.lblNameL.TabIndex = 4;
			this.lblNameL.Text = "氏名";
			// 
			// lblNameR
			// 
			this.lblNameR.AutoSize = true;
			this.lblNameR.BackColor = System.Drawing.Color.MidnightBlue;
			this.lblNameR.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lblNameR.ForeColor = System.Drawing.Color.Yellow;
			this.lblNameR.Location = new System.Drawing.Point(610, 470);
			this.lblNameR.Name = "lblNameR";
			this.lblNameR.Size = new System.Drawing.Size(58, 24);
			this.lblNameR.TabIndex = 4;
			this.lblNameR.Text = "氏名";
			// 
			// lblCarL
			// 
			this.lblCarL.AutoSize = true;
			this.lblCarL.BackColor = System.Drawing.Color.MidnightBlue;
			this.lblCarL.Font = new System.Drawing.Font("MS UI Gothic", 18F);
			this.lblCarL.ForeColor = System.Drawing.Color.Yellow;
			this.lblCarL.Location = new System.Drawing.Point(13, 512);
			this.lblCarL.Name = "lblCarL";
			this.lblCarL.Size = new System.Drawing.Size(107, 24);
			this.lblCarL.TabIndex = 4;
			this.lblCarL.Text = "カーネーム";
			// 
			// lblCarR
			// 
			this.lblCarR.AutoSize = true;
			this.lblCarR.BackColor = System.Drawing.Color.MidnightBlue;
			this.lblCarR.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lblCarR.ForeColor = System.Drawing.Color.Yellow;
			this.lblCarR.Location = new System.Drawing.Point(610, 512);
			this.lblCarR.Name = "lblCarR";
			this.lblCarR.Size = new System.Drawing.Size(107, 24);
			this.lblCarR.TabIndex = 4;
			this.lblCarR.Text = "カーネーム";
			// 
			// pctVS
			// 
			this.pctVS.BackColor = System.Drawing.Color.Transparent;
			this.pctVS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pctVS.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pctVS.Image = ((System.Drawing.Image)(resources.GetObject("pctVS.Image")));
			this.pctVS.Location = new System.Drawing.Point(418, 156);
			this.pctVS.Name = "pctVS";
			this.pctVS.Size = new System.Drawing.Size(204, 173);
			this.pctVS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctVS.TabIndex = 16;
			this.pctVS.TabStop = false;
			this.pctVS.Click += new System.EventHandler(this.pctVS_Click);
			// 
			// pctR
			// 
			this.pctR.BackColor = System.Drawing.Color.Transparent;
			this.pctR.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pctR.Location = new System.Drawing.Point(614, 121);
			this.pctR.Name = "pctR";
			this.pctR.Size = new System.Drawing.Size(422, 305);
			this.pctR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pctR.TabIndex = 3;
			this.pctR.TabStop = false;
			this.pctR.Click += new System.EventHandler(this.pctR_Click);
			// 
			// pctL
			// 
			this.pctL.BackColor = System.Drawing.Color.Transparent;
			this.pctL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pctL.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pctL.ErrorImage = null;
			this.pctL.Location = new System.Drawing.Point(12, 121);
			this.pctL.Name = "pctL";
			this.pctL.Size = new System.Drawing.Size(422, 305);
			this.pctL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pctL.TabIndex = 0;
			this.pctL.TabStop = false;
			this.pctL.Click += new System.EventHandler(this.pctL_Click);
			// 
			// pctBackImage
			// 
			this.pctBackImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pctBackImage.Image = ((System.Drawing.Image)(resources.GetObject("pctBackImage.Image")));
			this.pctBackImage.Location = new System.Drawing.Point(0, 0);
			this.pctBackImage.Name = "pctBackImage";
			this.pctBackImage.Size = new System.Drawing.Size(1115, 546);
			this.pctBackImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctBackImage.TabIndex = 15;
			this.pctBackImage.TabStop = false;
			this.pctBackImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pctBackImage_MouseClick);
			// 
			// lblL
			// 
			this.lblL.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblL.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lblL.ForeColor = System.Drawing.Color.Chartreuse;
			this.lblL.Location = new System.Drawing.Point(44, 38);
			this.lblL.Name = "lblL";
			this.lblL.Size = new System.Drawing.Size(118, 51);
			this.lblL.TabIndex = 20;
			this.lblL.Text = "888";
			this.lblL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblL.TextChanged += new System.EventHandler(this.lblL_TextChanged);
			this.lblL.Click += new System.EventHandler(this.lblL_Click);
			// 
			// lblR
			// 
			this.lblR.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblR.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lblR.ForeColor = System.Drawing.Color.Chartreuse;
			this.lblR.Location = new System.Drawing.Point(966, 12);
			this.lblR.Name = "lblR";
			this.lblR.Size = new System.Drawing.Size(118, 51);
			this.lblR.TabIndex = 21;
			this.lblR.Text = "888";
			this.lblR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblR.TextChanged += new System.EventHandler(this.lblR_TextChanged);
			this.lblR.Click += new System.EventHandler(this.lblR_Click);
			// 
			// lblCount
			// 
			this.lblCount.BackColor = System.Drawing.Color.Transparent;
			this.lblCount.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblCount.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lblCount.ForeColor = System.Drawing.Color.Chartreuse;
			this.lblCount.Location = new System.Drawing.Point(422, 156);
			this.lblCount.Name = "lblCount";
			this.lblCount.Size = new System.Drawing.Size(200, 51);
			this.lblCount.TabIndex = 22;
			this.lblCount.Text = "1";
			this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblCount.Click += new System.EventHandler(this.lblCount_Click);
			// 
			// pctWinL
			// 
			this.pctWinL.BackColor = System.Drawing.Color.Transparent;
			this.pctWinL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pctWinL.Image = ((System.Drawing.Image)(resources.GetObject("pctWinL.Image")));
			this.pctWinL.Location = new System.Drawing.Point(88, 200);
			this.pctWinL.Name = "pctWinL";
			this.pctWinL.Size = new System.Drawing.Size(303, 181);
			this.pctWinL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctWinL.TabIndex = 16;
			this.pctWinL.TabStop = false;
			this.pctWinL.Visible = false;
			this.pctWinL.Click += new System.EventHandler(this.pctVS_Click);
			// 
			// pctWinR
			// 
			this.pctWinR.BackColor = System.Drawing.Color.Transparent;
			this.pctWinR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pctWinR.Image = ((System.Drawing.Image)(resources.GetObject("pctWinR.Image")));
			this.pctWinR.Location = new System.Drawing.Point(660, 200);
			this.pctWinR.Name = "pctWinR";
			this.pctWinR.Size = new System.Drawing.Size(303, 181);
			this.pctWinR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctWinR.TabIndex = 23;
			this.pctWinR.TabStop = false;
			this.pctWinR.Visible = false;
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.BackColor = System.Drawing.Color.Transparent;
			this.lblTitle.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblTitle.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lblTitle.ForeColor = System.Drawing.Color.GreenYellow;
			this.lblTitle.Location = new System.Drawing.Point(265, 12);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(652, 48);
			this.lblTitle.TabIndex = 24;
			this.lblTitle.Text = "アドバンストクラス決勝トーナメント";
			this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
			// 
			// pctSchool
			// 
			this.pctSchool.BackColor = System.Drawing.Color.Transparent;
			this.pctSchool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pctSchool.ErrorImage = null;
			this.pctSchool.Location = new System.Drawing.Point(807, 429);
			this.pctSchool.Name = "pctSchool";
			this.pctSchool.Size = new System.Drawing.Size(138, 105);
			this.pctSchool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pctSchool.TabIndex = 25;
			this.pctSchool.TabStop = false;
			this.pctSchool.Visible = false;
			this.pctSchool.Click += new System.EventHandler(this.pctSchool_Click);
			// 
			// lblCount2
			// 
			this.lblCount2.BackColor = System.Drawing.Color.Transparent;
			this.lblCount2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblCount2.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lblCount2.ForeColor = System.Drawing.Color.Chartreuse;
			this.lblCount2.Location = new System.Drawing.Point(422, 102);
			this.lblCount2.Name = "lblCount2";
			this.lblCount2.Size = new System.Drawing.Size(200, 51);
			this.lblCount2.TabIndex = 22;
			this.lblCount2.Text = "レースNo.";
			this.lblCount2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblCount2.Click += new System.EventHandler(this.lblCount_Click);
			// 
			// lblCourse1
			// 
			this.lblCourse1.AutoSize = true;
			this.lblCourse1.BackColor = System.Drawing.Color.Blue;
			this.lblCourse1.Font = new System.Drawing.Font("ＭＳ ゴシック", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lblCourse1.ForeColor = System.Drawing.Color.Yellow;
			this.lblCourse1.Location = new System.Drawing.Point(204, 60);
			this.lblCourse1.Name = "lblCourse1";
			this.lblCourse1.Size = new System.Drawing.Size(212, 48);
			this.lblCourse1.TabIndex = 26;
			this.lblCourse1.Text = "１コース";
			// 
			// lblCourse2
			// 
			this.lblCourse2.AutoSize = true;
			this.lblCourse2.BackColor = System.Drawing.Color.Red;
			this.lblCourse2.Font = new System.Drawing.Font("ＭＳ ゴシック", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lblCourse2.ForeColor = System.Drawing.Color.Yellow;
			this.lblCourse2.Location = new System.Drawing.Point(716, 76);
			this.lblCourse2.Name = "lblCourse2";
			this.lblCourse2.Size = new System.Drawing.Size(212, 48);
			this.lblCourse2.TabIndex = 26;
			this.lblCourse2.Text = "２コース";
			// 
			// axWindowsMediaPlayer1
			// 
			this.axWindowsMediaPlayer1.Enabled = true;
			this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(383, 335);
			this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
			this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
			this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(221, 164);
			this.axWindowsMediaPlayer1.TabIndex = 5;
			this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
			// 
			// timer1
			// 
			this.timer1.Interval = 10000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// frmPair
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MidnightBlue;
			this.ClientSize = new System.Drawing.Size(1115, 546);
			this.Controls.Add(this.lblCourse2);
			this.Controls.Add(this.lblCourse1);
			this.Controls.Add(this.pctSchool);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.axWindowsMediaPlayer1);
			this.Controls.Add(this.pctWinR);
			this.Controls.Add(this.lblCount2);
			this.Controls.Add(this.lblCount);
			this.Controls.Add(this.lblR);
			this.Controls.Add(this.lblL);
			this.Controls.Add(this.pctWinL);
			this.Controls.Add(this.pctVS);
			this.Controls.Add(this.lblCarR);
			this.Controls.Add(this.lblNameR);
			this.Controls.Add(this.lblSchoolR);
			this.Controls.Add(this.lblCarL);
			this.Controls.Add(this.lblNameL);
			this.Controls.Add(this.lblSchoolL);
			this.Controls.Add(this.pctR);
			this.Controls.Add(this.pctL);
			this.Controls.Add(this.pctBackImage);
			this.KeyPreview = true;
			this.Name = "frmPair";
			this.Text = "決勝トーナメント";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Shown += new System.EventHandler(this.frmPair_Shown);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPair_KeyDown);
			this.Resize += new System.EventHandler(this.frmTournament_Resize);
			((System.ComponentModel.ISupportInitialize)(this.pctVS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pctR)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pctL)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pctBackImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pctWinL)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pctWinR)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pctSchool)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.PictureBox pctL;
		public System.Windows.Forms.PictureBox pctR;
		public System.Windows.Forms.Label lblSchoolL;
		public System.Windows.Forms.Label lblSchoolR;
		public System.Windows.Forms.Label lblNameL;
		public System.Windows.Forms.Label lblNameR;
		public System.Windows.Forms.Label lblCarL;
		public System.Windows.Forms.Label lblCarR;
		private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
		public System.Windows.Forms.PictureBox pctBackImage;
		private System.Windows.Forms.PictureBox pctVS;
		public System.Windows.Forms.Label lblL;
		public System.Windows.Forms.Label lblR;
		private System.Windows.Forms.Label lblCount;
		private System.Windows.Forms.PictureBox pctWinL;
		private System.Windows.Forms.PictureBox pctWinR;
		public System.Windows.Forms.Label lblTitle;
		public System.Windows.Forms.PictureBox pctSchool;
		private System.Windows.Forms.Label lblCount2;
		private System.Windows.Forms.Label lblCourse1;
		private System.Windows.Forms.Label lblCourse2;
		private System.Windows.Forms.Timer timer1;
	}
}

