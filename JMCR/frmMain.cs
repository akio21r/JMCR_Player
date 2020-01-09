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
		//ファイル名、フォルダ名
		public const String fileSetting			= @"データ\設定.csv";
		public const String imgFolder_Face		= @"データ\選手\";
		public const String imgFolder_School	= @"データ\学校\";
		public const String wavFileName_Don		= @"素材\don-1.wav";
		public const String movFileName_Next	= @"素材\NextChallenger.mp4";
		public const String imgFileName_Poster	= @"素材\ポスターs.png";
		public const String dataMeibo			= @"データ\名簿.csv";
		public const String dataA1				= @"データ\A1.csv";
		public const String dataA2				= @"データ\A2.csv";
		public const String dataA3				= @"データ\A決勝.csv";
		public const String dataB1				= @"データ\B1.csv";
		public const String dataB2				= @"データ\B2.csv";
		public const String dataB3				= @"データ\B決勝.csv";
		public const String dataC1				= @"データ\C1.csv";
		public const String dataC2				= @"データ\C2.csv";
		public const String dataTeam			= @"データ\Team.csv";

		//--------------------------------------------------------------
		// 名簿データ
		const int	MAX_MEIBO	= 2000;		// 名簿データの最大個数
		public struct tMeibo{
			public int		No;				// ゼッケン番号
			public String	School;			// 学校名
			public String	Name;			// 選手名
			public String	Car;			// カーネーム
			public String	Image;          // 写真のファイルネーム
			public String	Past1;          // 昨年の成績
			public String	Past2;			// 一昨年の成績
		}
		public static tMeibo[] meibo		= new tMeibo[MAX_MEIBO];
		public static int meibo_count;		// 名簿データの数
		public static DataTable table		= new DataTable("Table");

		//--------------------------------------------------------------
		// 対戦データ
//		public static String[,] strDataPair	= new String[1000, 2];		//対戦表
		public static int[,] DataPair	= new int[MAX_MEIBO, 2];	//対戦表
		public static int DataPair_count;	// 対戦表データの数
		public static int PairNoNow = 0;	// 対戦表の現在位置
		public static int SelectNoL, SelectNoR;
		public static String filename;

		//--------------------------------------------------------------
		// 地区対抗団体戦出場選手
		public static int[,] tableTeam	= new int[10,5];		//各地区の選手No
			//地区No, 地区名,     先鋒, 中堅, 大将, A補欠, B補欠
			//  1   , 北海道地区
			//  2   , 東北地区
			//  3   , 関東地区
			//  4   , 北信越地区
			//  5   , 東海地区
			//  6   , 近畿地区
			//  7   , 中国地区
			//  8   , 四国地区
			//  9   , 九州地区
		
		//--------------------------------------------------------------
		// 各種設定
		public static int setTimerSchool	= 10000;		//frmPair画面での出場校切替時間

		//--------------------------------------------------------------
		public frmData frmData = new frmData();

		
		
		//--------------------------------------------------------------
		public frmMain()
		{
			InitializeComponent();
			pctBackImage.Controls.Add(pctKame);
			pctBackImage.Controls.Add(lblTitle);

			//全画面表示
			this.FormBorderStyle = FormBorderStyle.None;
			this.WindowState = FormWindowState.Maximized;

			//名簿データの読み込み
			CSVFileLoad_Meibo();

			//設定ファイルの読み込み
			CSVFileLoad_Setting();
		}

		//--------------------------------------------------------------
		// 名簿データの読み込み
		private void CSVFileLoad_Meibo()
		{
			// CSVファイルの読み込み
			string line;
			string[] field;
			System.IO.StreamReader reader = new System.IO.StreamReader(frmMain.dataMeibo, Encoding.Default);

			// カラム名の追加
			if(frmMain.table.Columns.Count == 0){
				//空であれば列を追加
				frmMain.table.Columns.Add("No");
				frmMain.table.Columns.Add("学校");
				frmMain.table.Columns.Add("氏名");
				frmMain.table.Columns.Add("Car");
				frmMain.table.Columns.Add("写真");
				frmMain.table.Columns.Add("昨年");
				frmMain.table.Columns.Add("一昨年");
			}
			else{
				//空でなければデータを全てクリアする
				frmMain.table.Clear();
			}
	
			for(frmMain.meibo_count=0; !reader.EndOfStream; frmMain.meibo_count++){
				line = reader.ReadLine();
				field = line.Split(',');

				// 名簿データへの読込
				frmMain.meibo[frmMain.meibo_count].No		= int.Parse(field[0]);
				frmMain.meibo[frmMain.meibo_count].School	= field[1];
				frmMain.meibo[frmMain.meibo_count].Name		= field[2];
				frmMain.meibo[frmMain.meibo_count].Car		= field[3];
				frmMain.meibo[frmMain.meibo_count].Image	= field[4];
				frmMain.meibo[frmMain.meibo_count].Past1	= field[5];
				frmMain.meibo[frmMain.meibo_count].Past2	= field[6];

				// データを追加
				frmMain.table.Rows.Add(
					frmMain.meibo[frmMain.meibo_count].No.ToString("000"),
					frmMain.meibo[frmMain.meibo_count].School,
					frmMain.meibo[frmMain.meibo_count].Name,
					frmMain.meibo[frmMain.meibo_count].Car,
					frmMain.meibo[frmMain.meibo_count].Image,
					frmMain.meibo[frmMain.meibo_count].Past1,
					frmMain.meibo[frmMain.meibo_count].Past2
				);
	
			}
			
			reader.Close();

		//	frmData.dataGridView1.DataSource = frmMain.table;
		}


		// 対戦データの読み込み
		public void CSVFileLoad_Pair(String filename)
		{
			// CSVファイルの読み込み
			string line;
			string[] field;
			System.IO.StreamReader reader = new System.IO.StreamReader(filename, Encoding.Default);
			frmData.lstDataPair.Items.Clear();
			for(DataPair_count=0; !reader.EndOfStream; DataPair_count++){
				line = reader.ReadLine();
				field = line.Split(',');

				// 対戦データ
				DataPair[DataPair_count, 0] = int.Parse(field[0]);
				DataPair[DataPair_count, 1] = int.Parse(field[1]);

				// String[,]
			//	strDataPair[n, 0] = DataPair[n, 0].ToString("000");
			//	strDataPair[n, 1] = DataPair[n, 1].ToString("000");

				// ListBox
				frmData.lstDataPair.Items.Add(	DataPair[DataPair_count, 0].ToString("000") + '\t'
										+ DataPair[DataPair_count, 1].ToString("000"));
			}
			reader.Close();
			SelectNoL = DataPair[0, 0];
			SelectNoR = DataPair[0, 1];
			PairNoNow = 0;
		}

		// 地区対抗団体戦CSVデータの読み込み
		public void CSVFileLoad_Team()
		{
			string line;
			string[] field;
			System.IO.StreamReader reader = new System.IO.StreamReader(dataTeam, Encoding.Default);
			line = reader.ReadLine();	//1行目を捨てる
			for(int n=1; !reader.EndOfStream; n++){
				line = reader.ReadLine();
				field = line.Split(',');
				for(int i=0; i<5; i++){
					tableTeam[n, i] = int.Parse(field[2+i]);
				}
			}
			reader.Close();
		}

		// 設定の読み込み
		public void CSVFileLoad_Setting()
		{
			string line;
			string[] field;
			System.IO.StreamReader reader = new System.IO.StreamReader(fileSetting, Encoding.Default);
			for (int n = 1; !reader.EndOfStream; n++)
			{
				line = reader.ReadLine();
				field = line.Split(',');
				if (field[0] == "timer1")
					setTimerSchool = int.Parse(field[1]);
			}
			reader.Close();
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
				filename = dataA1;
				CSVFileLoad_Pair(dataA1);
			//	f.lblTitle.Text = "Advanced Class 予選 １走目";
				f.lblTitle.Text = "Ａクラス予選１走目";
			}
			else if(sender.Equals(btnYosenA2)){
				filename = dataA2;
				CSVFileLoad_Pair(dataA2);
			//	f.lblTitle.Text = "Advanced Class 予選 ２走目";
				f.lblTitle.Text = "Ａクラス予選２走目";
			}
			else if(sender.Equals(btnKessyoA)){
				filename = dataA3;
				CSVFileLoad_Pair(dataA3);
			//	f.lblTitle.Text = "Advanced Class 決勝トーナメント";
				f.lblTitle.Text = "Ａクラス決勝トーナメント";
			}

			if(sender.Equals(btnYosenB1)){
				filename = dataB1;
				CSVFileLoad_Pair(dataB1);
			//	f.lblTitle.Text = "Basic Class 予選 １走目";
				f.lblTitle.Text = "Ｂクラス予選１走目";
			}
			else if(sender.Equals(btnYosenB2)){
				filename = dataB2;
				CSVFileLoad_Pair(dataB2);
			//	f.lblTitle.Text = "Basic Class 予選 ２走目";
				f.lblTitle.Text = "Ｂクラス予選２走目";
			}
			else if(sender.Equals(btnKessyoB)){
				filename = dataB3;
				CSVFileLoad_Pair(dataB3);
			//	f.lblTitle.Text = "Basic Class 決勝トーナメント";
				f.lblTitle.Text = "Ｂクラス決勝トーナメント";
			}

			if(sender.Equals(btnC1)){
				filename = dataC1;
				CSVFileLoad_Pair(dataC1);
			//	f.lblTitle.Text = "Camera Class １走目";
				f.lblTitle.Text = "Ｃクラス１走目";
			}
			else if(sender.Equals(btnC2)){
				filename = dataC2;
				CSVFileLoad_Pair(dataC2);
			//	f.lblTitle.Text = "Camera Class ２走目";
				f.lblTitle.Text = "Ｃクラス２走目";
			}

			f.ShowDialog();
		}

		private void btnTeam_Click(object sender, EventArgs e)
		{
			CSVFileLoad_Team();
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
