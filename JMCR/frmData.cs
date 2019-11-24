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
	public partial class frmData : Form
	{
		//--------------------------------------------------------------
		// 名簿データ
		const int	MAX_MEIBO	= 2000;		// 名簿データの最大個数
		public struct tMeibo{
			public int		No;				// ゼッケン番号
			public String	School;			// 学校名
			public String	Name;			// 選手名
			public String	Car;			// カーネーム
		}
		public static tMeibo[] meibo = new tMeibo[MAX_MEIBO];
		public static int meibo_count;		// 名簿データの数

		//--------------------------------------------------------------
		// 対戦データ
//		public static String[,] strDataPair	= new String[1000, 2];		//対戦表
		public static int[,] DataPair		= new int[MAX_MEIBO, 2];	//対戦表
		public static int DataPair_count;	// 対戦表データの数
		public static int PairNoNow = 0;	// 対戦表の現在位置
		public static int SelectNoL, SelectNoR;
	
		//--------------------------------------------------------------
		//
		public static DataTable table		= new DataTable("Table");

		public frmData()
		{
			InitializeComponent();
			CSVFileLoad_Meibo();
			CSVFileLoad_Pair();
		}

		private void frmData_Load(object sender, EventArgs e)
		{
		}

		// 名簿データの読み込み
		private void CSVFileLoad_Meibo()
		{
            // カラム名の追加
            frmData.table.Columns.Add("No");
            frmData.table.Columns.Add("学校");
            frmData.table.Columns.Add("氏名");
            frmData.table.Columns.Add("カーネーム");
	
			// CSVファイルの読み込み
			string line;
			string[] field;
			System.IO.StreamReader reader = new System.IO.StreamReader(@"データ\data.csv", Encoding.Default);
			for(meibo_count=0; !reader.EndOfStream; meibo_count++){
				line = reader.ReadLine();
				field = line.Split(',');

				// 名簿データへの読込
				meibo[meibo_count].No		= int.Parse(field[0]);
				meibo[meibo_count].School	= field[1];
				meibo[meibo_count].Name		= field[2];
				meibo[meibo_count].Car		= field[3];
	
				// データを追加
				frmData.table.Rows.Add(
					meibo[meibo_count].No.ToString("000"),
					meibo[meibo_count].School,
					meibo[meibo_count].Name,
					meibo[meibo_count].Car);
	
			}
			
			reader.Close();
		
	
		
            dataGridView1.DataSource = frmData.table;
		}

		// 対戦データの読み込み
		private void CSVFileLoad_Pair()
		{
			// CSVファイルの読み込み
			string line;
			string[] field;
			System.IO.StreamReader reader = new System.IO.StreamReader(@"データ\dataPair.csv", Encoding.Default);
			lstDataPair.Items.Clear();
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
				lstDataPair.Items.Add(	DataPair[DataPair_count, 0].ToString("000") + '\t'
										+ DataPair[DataPair_count, 1].ToString("000"));
			}
			reader.Close();
			SelectNoL = DataPair[0, 0];
			SelectNoR = DataPair[0, 1];
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dataGridView1_SelectionChanged(object sender, EventArgs e)
		{
			lblL.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
		}

		private void lstDataPair_SelectedIndexChanged(object sender, EventArgs e)
		{
			int n = lstDataPair.SelectedIndex;
			SelectNoL = DataPair[n, 0];
			SelectNoR = DataPair[n, 1];
			lblL.Text = DataPair[n, 0].ToString();
			lblR.Text = DataPair[n, 1].ToString();
			PairNoNow = n;
		}





	}
}
