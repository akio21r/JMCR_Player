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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPair));
			this.pctLeft = new System.Windows.Forms.PictureBox();
			this.txtLeft = new System.Windows.Forms.TextBox();
			this.lblVS = new System.Windows.Forms.Label();
			this.pctRight = new System.Windows.Forms.PictureBox();
			this.txtRight = new System.Windows.Forms.TextBox();
			this.lblSchoolLeft = new System.Windows.Forms.Label();
			this.lblSchoolRight = new System.Windows.Forms.Label();
			this.lblNameLeft = new System.Windows.Forms.Label();
			this.lblNameRight = new System.Windows.Forms.Label();
			this.lblCarLeft = new System.Windows.Forms.Label();
			this.lblCarRight = new System.Windows.Forms.Label();
			this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pctLeft)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pctRight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pctLeft
			// 
			this.pctLeft.BackColor = System.Drawing.Color.Transparent;
			this.pctLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pctLeft.ErrorImage = null;
			this.pctLeft.Location = new System.Drawing.Point(12, 56);
			this.pctLeft.Name = "pctLeft";
			this.pctLeft.Size = new System.Drawing.Size(422, 370);
			this.pctLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pctLeft.TabIndex = 0;
			this.pctLeft.TabStop = false;
			// 
			// txtLeft
			// 
			this.txtLeft.BackColor = System.Drawing.Color.Teal;
			this.txtLeft.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtLeft.Location = new System.Drawing.Point(12, 12);
			this.txtLeft.Name = "txtLeft";
			this.txtLeft.Size = new System.Drawing.Size(121, 12);
			this.txtLeft.TabIndex = 1;
			this.txtLeft.TextChanged += new System.EventHandler(this.txtLeft_TextChanged);
			// 
			// lblVS
			// 
			this.lblVS.AutoSize = true;
			this.lblVS.Font = new System.Drawing.Font("Segoe UI Symbol", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVS.ForeColor = System.Drawing.Color.Yellow;
			this.lblVS.Location = new System.Drawing.Point(486, 216);
			this.lblVS.Name = "lblVS";
			this.lblVS.Size = new System.Drawing.Size(73, 50);
			this.lblVS.TabIndex = 2;
			this.lblVS.Text = "VS.";
			// 
			// pctRight
			// 
			this.pctRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pctRight.Location = new System.Drawing.Point(614, 56);
			this.pctRight.Name = "pctRight";
			this.pctRight.Size = new System.Drawing.Size(422, 370);
			this.pctRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pctRight.TabIndex = 3;
			this.pctRight.TabStop = false;
			// 
			// txtRight
			// 
			this.txtRight.BackColor = System.Drawing.Color.Teal;
			this.txtRight.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtRight.Location = new System.Drawing.Point(614, 12);
			this.txtRight.Name = "txtRight";
			this.txtRight.Size = new System.Drawing.Size(121, 12);
			this.txtRight.TabIndex = 1;
			this.txtRight.TextChanged += new System.EventHandler(this.txtRight_TextChanged);
			// 
			// lblSchoolLeft
			// 
			this.lblSchoolLeft.AutoSize = true;
			this.lblSchoolLeft.Font = new System.Drawing.Font("HG正楷書体-PRO", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lblSchoolLeft.ForeColor = System.Drawing.Color.Yellow;
			this.lblSchoolLeft.Location = new System.Drawing.Point(13, 433);
			this.lblSchoolLeft.Name = "lblSchoolLeft";
			this.lblSchoolLeft.Size = new System.Drawing.Size(85, 24);
			this.lblSchoolLeft.TabIndex = 4;
			this.lblSchoolLeft.Text = "高校名";
			// 
			// lblSchoolRight
			// 
			this.lblSchoolRight.AutoSize = true;
			this.lblSchoolRight.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lblSchoolRight.ForeColor = System.Drawing.Color.Yellow;
			this.lblSchoolRight.Location = new System.Drawing.Point(610, 433);
			this.lblSchoolRight.Name = "lblSchoolRight";
			this.lblSchoolRight.Size = new System.Drawing.Size(82, 24);
			this.lblSchoolRight.TabIndex = 4;
			this.lblSchoolRight.Text = "高校名";
			// 
			// lblNameLeft
			// 
			this.lblNameLeft.AutoSize = true;
			this.lblNameLeft.Font = new System.Drawing.Font("HG正楷書体-PRO", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(128)));
			this.lblNameLeft.ForeColor = System.Drawing.Color.Yellow;
			this.lblNameLeft.Location = new System.Drawing.Point(13, 470);
			this.lblNameLeft.Name = "lblNameLeft";
			this.lblNameLeft.Size = new System.Drawing.Size(60, 24);
			this.lblNameLeft.TabIndex = 4;
			this.lblNameLeft.Text = "氏名";
			// 
			// lblNameRight
			// 
			this.lblNameRight.AutoSize = true;
			this.lblNameRight.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lblNameRight.ForeColor = System.Drawing.Color.Yellow;
			this.lblNameRight.Location = new System.Drawing.Point(610, 470);
			this.lblNameRight.Name = "lblNameRight";
			this.lblNameRight.Size = new System.Drawing.Size(58, 24);
			this.lblNameRight.TabIndex = 4;
			this.lblNameRight.Text = "氏名";
			// 
			// lblCarLeft
			// 
			this.lblCarLeft.AutoSize = true;
			this.lblCarLeft.BackColor = System.Drawing.Color.Transparent;
			this.lblCarLeft.Font = new System.Drawing.Font("HG正楷書体-PRO", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lblCarLeft.ForeColor = System.Drawing.Color.Yellow;
			this.lblCarLeft.Location = new System.Drawing.Point(13, 512);
			this.lblCarLeft.Name = "lblCarLeft";
			this.lblCarLeft.Size = new System.Drawing.Size(180, 33);
			this.lblCarLeft.TabIndex = 4;
			this.lblCarLeft.Text = "カーネーム";
			// 
			// lblCarRight
			// 
			this.lblCarRight.AutoSize = true;
			this.lblCarRight.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lblCarRight.ForeColor = System.Drawing.Color.Yellow;
			this.lblCarRight.Location = new System.Drawing.Point(610, 512);
			this.lblCarRight.Name = "lblCarRight";
			this.lblCarRight.Size = new System.Drawing.Size(107, 24);
			this.lblCarRight.TabIndex = 4;
			this.lblCarRight.Text = "カーネーム";
			// 
			// axWindowsMediaPlayer1
			// 
			this.axWindowsMediaPlayer1.Enabled = true;
			this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(311, 331);
			this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
			this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
			this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(297, 178);
			this.axWindowsMediaPlayer1.TabIndex = 5;
			this.axWindowsMediaPlayer1.Visible = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(464, 35);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = global::JMCR.Properties.Resources.Image3;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1048, 554);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 15;
			this.pictureBox1.TabStop = false;
			// 
			// frmPair
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MidnightBlue;
			this.ClientSize = new System.Drawing.Size(1048, 554);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblCarRight);
			this.Controls.Add(this.lblNameRight);
			this.Controls.Add(this.lblSchoolRight);
			this.Controls.Add(this.lblCarLeft);
			this.Controls.Add(this.lblNameLeft);
			this.Controls.Add(this.lblSchoolLeft);
			this.Controls.Add(this.pctRight);
			this.Controls.Add(this.lblVS);
			this.Controls.Add(this.txtRight);
			this.Controls.Add(this.txtLeft);
			this.Controls.Add(this.pctLeft);
			this.Controls.Add(this.axWindowsMediaPlayer1);
			this.Controls.Add(this.pictureBox1);
			this.KeyPreview = true;
			this.Name = "frmPair";
			this.Text = "決勝トーナメント";
			this.Load += new System.EventHandler(this.frmTournament_Load);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmTournament_KeyPress);
			this.Resize += new System.EventHandler(this.frmTournament_Resize);
			((System.ComponentModel.ISupportInitialize)(this.pctLeft)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pctRight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.PictureBox pctLeft;
		public System.Windows.Forms.TextBox txtLeft;
		public System.Windows.Forms.Label lblVS;
		public System.Windows.Forms.PictureBox pctRight;
		public System.Windows.Forms.TextBox txtRight;
		public System.Windows.Forms.Label lblSchoolLeft;
		public System.Windows.Forms.Label lblSchoolRight;
		public System.Windows.Forms.Label lblNameLeft;
		public System.Windows.Forms.Label lblNameRight;
		public System.Windows.Forms.Label lblCarLeft;
		public System.Windows.Forms.Label lblCarRight;
		private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
		private System.Windows.Forms.Button button1;
		public System.Windows.Forms.PictureBox pictureBox1;
	}
}
