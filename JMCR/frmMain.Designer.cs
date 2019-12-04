namespace JMCR
{
	partial class frmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.btnKessyoA = new System.Windows.Forms.Button();
			this.btnTeam = new System.Windows.Forms.Button();
			this.pctKame = new System.Windows.Forms.PictureBox();
			this.pctBackImage = new System.Windows.Forms.PictureBox();
			this.lblTitle = new System.Windows.Forms.Label();
			this.btnYosenA = new System.Windows.Forms.Button();
			this.btnYosenB = new System.Windows.Forms.Button();
			this.btnKessyoB = new System.Windows.Forms.Button();
			this.btnKessyoC = new System.Windows.Forms.Button();
			this.pctPoster = new System.Windows.Forms.PictureBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pctKame)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pctBackImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pctPoster)).BeginInit();
			this.SuspendLayout();
			// 
			// btnKessyoA
			// 
			this.btnKessyoA.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btnKessyoA.Location = new System.Drawing.Point(299, 112);
			this.btnKessyoA.Name = "btnKessyoA";
			this.btnKessyoA.Size = new System.Drawing.Size(259, 52);
			this.btnKessyoA.TabIndex = 1;
			this.btnKessyoA.Text = "Advanced Class 決勝";
			this.btnKessyoA.UseVisualStyleBackColor = true;
			this.btnKessyoA.Click += new System.EventHandler(this.btnKessyoA_Click);
			// 
			// btnTeam
			// 
			this.btnTeam.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btnTeam.Location = new System.Drawing.Point(34, 376);
			this.btnTeam.Name = "btnTeam";
			this.btnTeam.Size = new System.Drawing.Size(259, 52);
			this.btnTeam.TabIndex = 2;
			this.btnTeam.Text = "地区対抗団体戦";
			this.btnTeam.UseVisualStyleBackColor = true;
			this.btnTeam.Click += new System.EventHandler(this.btnTeam_Click);
			// 
			// pctKame
			// 
			this.pctKame.BackColor = System.Drawing.Color.Transparent;
			this.pctKame.Image = ((System.Drawing.Image)(resources.GetObject("pctKame.Image")));
			this.pctKame.Location = new System.Drawing.Point(680, 271);
			this.pctKame.Name = "pctKame";
			this.pctKame.Size = new System.Drawing.Size(222, 290);
			this.pctKame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pctKame.TabIndex = 3;
			this.pctKame.TabStop = false;
			this.pctKame.Click += new System.EventHandler(this.pctKame_Click);
			// 
			// pctBackImage
			// 
			this.pctBackImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pctBackImage.Image = ((System.Drawing.Image)(resources.GetObject("pctBackImage.Image")));
			this.pctBackImage.Location = new System.Drawing.Point(0, 0);
			this.pctBackImage.Name = "pctBackImage";
			this.pctBackImage.Size = new System.Drawing.Size(914, 573);
			this.pctBackImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctBackImage.TabIndex = 4;
			this.pctBackImage.TabStop = false;
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.BackColor = System.Drawing.Color.Transparent;
			this.lblTitle.Font = new System.Drawing.Font("メイリオ", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lblTitle.ForeColor = System.Drawing.Color.Yellow;
			this.lblTitle.Location = new System.Drawing.Point(12, 9);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(802, 55);
			this.lblTitle.TabIndex = 5;
			this.lblTitle.Text = "ジャパン・マイコンカーラリー2020 全国大会";
			this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
			// 
			// btnYosenA
			// 
			this.btnYosenA.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btnYosenA.Location = new System.Drawing.Point(34, 112);
			this.btnYosenA.Name = "btnYosenA";
			this.btnYosenA.Size = new System.Drawing.Size(259, 52);
			this.btnYosenA.TabIndex = 6;
			this.btnYosenA.Text = "Advanced Class 予選";
			this.btnYosenA.UseVisualStyleBackColor = true;
			this.btnYosenA.Click += new System.EventHandler(this.btnYosenA_Click);
			// 
			// btnYosenB
			// 
			this.btnYosenB.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btnYosenB.Location = new System.Drawing.Point(34, 200);
			this.btnYosenB.Name = "btnYosenB";
			this.btnYosenB.Size = new System.Drawing.Size(259, 52);
			this.btnYosenB.TabIndex = 7;
			this.btnYosenB.Text = "Basic Class 予選";
			this.btnYosenB.UseVisualStyleBackColor = true;
			this.btnYosenB.Click += new System.EventHandler(this.btnYosenB_Click);
			// 
			// btnKessyoB
			// 
			this.btnKessyoB.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btnKessyoB.Location = new System.Drawing.Point(299, 200);
			this.btnKessyoB.Name = "btnKessyoB";
			this.btnKessyoB.Size = new System.Drawing.Size(259, 52);
			this.btnKessyoB.TabIndex = 8;
			this.btnKessyoB.Text = "Basic Class 決勝";
			this.btnKessyoB.UseVisualStyleBackColor = true;
			this.btnKessyoB.Click += new System.EventHandler(this.btnKessyoB_Click);
			// 
			// btnKessyoC
			// 
			this.btnKessyoC.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btnKessyoC.Location = new System.Drawing.Point(34, 288);
			this.btnKessyoC.Name = "btnKessyoC";
			this.btnKessyoC.Size = new System.Drawing.Size(259, 52);
			this.btnKessyoC.TabIndex = 9;
			this.btnKessyoC.Text = "Camera Class";
			this.btnKessyoC.UseVisualStyleBackColor = true;
			this.btnKessyoC.Click += new System.EventHandler(this.btnKessyoC_Click);
			// 
			// pctPoster
			// 
			this.pctPoster.Location = new System.Drawing.Point(398, 344);
			this.pctPoster.Name = "pctPoster";
			this.pctPoster.Size = new System.Drawing.Size(100, 50);
			this.pctPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pctPoster.TabIndex = 10;
			this.pctPoster.TabStop = false;
			this.pctPoster.Visible = false;
			this.pctPoster.Click += new System.EventHandler(this.pctPoster_Click);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(34, 510);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(60, 51);
			this.btnClose.TabIndex = 11;
			this.btnClose.Text = "終了";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(97, 529);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(196, 12);
			this.label1.TabIndex = 12;
			this.label1.Text = "それぞれ、タイトル文字のクリックでも終了";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(914, 573);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.pctPoster);
			this.Controls.Add(this.btnKessyoC);
			this.Controls.Add(this.btnKessyoB);
			this.Controls.Add(this.btnYosenB);
			this.Controls.Add(this.btnYosenA);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.pctKame);
			this.Controls.Add(this.btnTeam);
			this.Controls.Add(this.btnKessyoA);
			this.Controls.Add(this.pctBackImage);
			this.Name = "frmMain";
			this.Text = "frmMain";
			this.Resize += new System.EventHandler(this.frmMain_Resize);
			((System.ComponentModel.ISupportInitialize)(this.pctKame)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pctBackImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pctPoster)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnKessyoA;
		private System.Windows.Forms.Button btnTeam;
		private System.Windows.Forms.PictureBox pctKame;
		private System.Windows.Forms.PictureBox pctBackImage;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Button btnYosenA;
		private System.Windows.Forms.Button btnYosenB;
		private System.Windows.Forms.Button btnKessyoB;
		private System.Windows.Forms.Button btnKessyoC;
		private System.Windows.Forms.PictureBox pctPoster;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label label1;
	}
}