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
			this.btnPair = new System.Windows.Forms.Button();
			this.btnTeam = new System.Windows.Forms.Button();
			this.pctKame = new System.Windows.Forms.PictureBox();
			this.pctBackImage = new System.Windows.Forms.PictureBox();
			this.lblTitle = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pctKame)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pctBackImage)).BeginInit();
			this.SuspendLayout();
			// 
			// btnPair
			// 
			this.btnPair.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btnPair.Location = new System.Drawing.Point(32, 95);
			this.btnPair.Name = "btnPair";
			this.btnPair.Size = new System.Drawing.Size(259, 52);
			this.btnPair.TabIndex = 1;
			this.btnPair.Text = "予選・決勝トーナメント";
			this.btnPair.UseVisualStyleBackColor = true;
			this.btnPair.Click += new System.EventHandler(this.btnTournament_Click);
			// 
			// btnTeam
			// 
			this.btnTeam.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btnTeam.Location = new System.Drawing.Point(32, 178);
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
			this.pctKame.Location = new System.Drawing.Point(399, 178);
			this.pctKame.Name = "pctKame";
			this.pctKame.Size = new System.Drawing.Size(222, 290);
			this.pctKame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pctKame.TabIndex = 3;
			this.pctKame.TabStop = false;
			// 
			// pctBackImage
			// 
			this.pctBackImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pctBackImage.Image = ((System.Drawing.Image)(resources.GetObject("pctBackImage.Image")));
			this.pctBackImage.Location = new System.Drawing.Point(0, 0);
			this.pctBackImage.Name = "pctBackImage";
			this.pctBackImage.Size = new System.Drawing.Size(636, 480);
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
			this.lblTitle.Size = new System.Drawing.Size(542, 55);
			this.lblTitle.TabIndex = 5;
			this.lblTitle.Text = "ジャパン・マイコンカーラリー";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Teal;
			this.ClientSize = new System.Drawing.Size(636, 480);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.pctKame);
			this.Controls.Add(this.btnTeam);
			this.Controls.Add(this.btnPair);
			this.Controls.Add(this.pctBackImage);
			this.Name = "frmMain";
			this.Text = "frmMain";
			this.Resize += new System.EventHandler(this.frmMain_Resize);
			((System.ComponentModel.ISupportInitialize)(this.pctKame)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pctBackImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnPair;
		private System.Windows.Forms.Button btnTeam;
		private System.Windows.Forms.PictureBox pctKame;
		private System.Windows.Forms.PictureBox pctBackImage;
		private System.Windows.Forms.Label lblTitle;
	}
}