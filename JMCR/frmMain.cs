using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JMCR
{
	public partial class frmMain : Form
	{
		//データの場所
		public const String imgFolder_Face		= @"データ\選手\";
		public const String imgFolder_School	= @"データ\学校\";
		public const String wavFileName_Don		= @"素材\音\don-1.wav";
		public const String movFileName_Next	= @"素材\NextChallenger.mp4";
		public const String imgFileName_Poster	= @"素材\ポスターs.png";
		public const String dataMeibo			= @"データ\名簿.csv";

		//--------------------------------------------------------------
		// 名簿データ
		const int	MAX_MEIBO	= 2000;		// 名簿データの最大個数
		public struct tMeibo{
			public int		No;				// ゼッケン番号
			public String	School;			// 学校名
			public String	Name;			// 選手名
			public String	Car;			// カーネーム
			public String	Image;			// 写真のファイルネーム
		}
		public static tMeibo[] meibo		= new tMeibo[MAX_MEIBO];
		public static int meibo_count;		// 名簿データの数
		public static DataTable table		= new DataTable("Table");

		//--------------------------------------------------------------
		// 対戦データ
//		public static String[,] strDataPair	= new String[1000, 2];		//対戦表
		public static int[,] DataPair		= new int[MAX_MEIBO, 2];	//対戦表
		public static int DataPair_count;	// 対戦表データの数
		public static int PairNoNow = 0;	// 対戦表の現在位置
		public static int SelectNoL, SelectNoR;

	
		
		
		//--------------------------------------------------------------
		public frmMain()
		{
			InitializeComponent();
			pctBackImage.Controls.Add(pctKame);
			pctBackImage.Controls.Add(lblTitle);

			//全画面表示
			this.FormBorderStyle = FormBorderStyle.None;
			this.WindowState = FormWindowState.Maximized;
	}

		private void frmMain_Resize(object sender, EventArgs e)
		{
			pctKame.Left = this.ClientSize.Width - pctKame.Width;
			pctKame.Top  = this.ClientSize.Height - pctKame.Height;
		}

		private void btnPair_Click(object sender, EventArgs e)
		{
			frmPair f = new frmPair();

			if(sender.Equals(btnYosenA1)){
				f.lblTitle.Text = "Advanced Class 予選 １走目";
			}
			else if(sender.Equals(btnYosenA2)){
				f.lblTitle.Text = "Advanced Class 予選 ２走目";
			}
			else if(sender.Equals(btnKessyoA)){
				f.lblTitle.Text = "Advanced Class 決勝トーナメント";
			}

			if(sender.Equals(btnYosenB1)){
				f.lblTitle.Text = "Basic Class 予選 １走目";
			}
			else if(sender.Equals(btnYosenB2)){
				f.lblTitle.Text = "Basic Class 予選 ２走目";
			}
			else if(sender.Equals(btnKessyoB)){
				f.lblTitle.Text = "Basic Class 決勝トーナメント";
			}

			if(sender.Equals(btnC1)){
				f.lblTitle.Text = "Camera Class １走目";
			}
			else if(sender.Equals(btnC2)){
				f.lblTitle.Text = "Camera Class ２走目";
			}

			f.ShowDialog();
		}

		private void btnTeam_Click(object sender, EventArgs e)
		{
			frmTeam f = new frmTeam();
			f.ShowDialog();
		}

		private void pctKame_Click(object sender, EventArgs e)
		{
			pctPoster.ImageLocation = imgFileName_Poster;
			pctPoster.Dock = DockStyle.Fill;
			pctPoster.Visible = true;
		}

		private void pctPoster_Click(object sender, EventArgs e)
		{
			pctPoster.Visible = false;
		}

		private void lblTitle_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	}
}
