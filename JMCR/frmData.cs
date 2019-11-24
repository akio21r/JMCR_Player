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

		// 名簿データ
		const int	MAX_MEIBO	= 2000;		// 名簿データの最大個数
		public struct tMeibo{
			public int		No_int;			// ゼッケン番号
			public String	No_str;			// ゼッケン番号（0埋3桁の文字列）
			public String	School;			// 学校名
			public String	Name;			// 選手名
			public String	Car;			// カーネーム
		}
		public static tMeibo[] meibo = new tMeibo[MAX_MEIBO];
		public static int meibo_count;		// 読み込んだ数



		public static DataTable table			= new DataTable("Table");
		public static String[,] strDataMeibo	= new String[1000, 4];	//基本データ
		public static String[,] strDataPair		= new String[1000, 2];	//対戦表

		public static int SelectNoLeft, SelectNoRight;

	//	public frmPair frmPair = new frmPair();

		public frmData()
		{
			InitializeComponent();
			CSVFileLoad_Meibo();
			CSVFileLoad_Pair();
		}

		private void frmData_Load(object sender, EventArgs e)
		{
		}

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
			lstDataMeibo.Items.Clear();
			for(meibo_count=0; !reader.EndOfStream; meibo_count++){
				line = reader.ReadLine();
				field = line.Split(',');

				// 名簿データへの読込
				meibo[meibo_count].No_int		= int.Parse(field[0]);
				meibo[meibo_count].No_str			= meibo[meibo_count].No_int.ToString("000");
				meibo[meibo_count].School		= field[1];
				meibo[meibo_count].Name			= field[2];
				meibo[meibo_count].Car			= field[3];
	
				
				// ListBox
				lstDataMeibo.Items.Add(
					meibo[meibo_count].No_str + '\t' +
					meibo[meibo_count].School + '\t' +
					meibo[meibo_count].Name + '\t' +
					meibo[meibo_count].Car);

				// データを追加
				frmData.table.Rows.Add(
					meibo[meibo_count].No_str,
					meibo[meibo_count].School,
					meibo[meibo_count].Name,
					meibo[meibo_count].Car);
	
				// String[,]
				frmData.strDataMeibo[meibo_count, 0] = meibo[meibo_count].No_str;
				frmData.strDataMeibo[meibo_count, 1] = meibo[meibo_count].School;
				frmData.strDataMeibo[meibo_count, 2] = meibo[meibo_count].Name;
				frmData.strDataMeibo[meibo_count, 3] = meibo[meibo_count].Car;

			}
			
			reader.Close();
		
	
		
            dataGridView1.DataSource = frmData.table;
		}

		private void CSVFileLoad_Pair()
		{
			// CSVファイルの読み込み
			string line;
			string[] field;
			System.IO.StreamReader reader = new System.IO.StreamReader(@"データ\dataPair.csv", Encoding.Default);
			lstDataPair.Items.Clear();
			for(int n=0; !reader.EndOfStream; n++){
				line = reader.ReadLine();
				field = line.Split(',');

				// String[,]
				strDataPair[n, 0] = int.Parse(field[0]).ToString("000");
				strDataPair[n, 1] = int.Parse(field[1]).ToString("000");

				// ListBox
				lstDataPair.Items.Add(strDataPair[n, 0] + '\t' + strDataPair[n, 1]);
		}
			reader.Close();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dataGridView1_SelectionChanged(object sender, EventArgs e)
		{
			txtLeft.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
/*			frmPair.txtLeft.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
			frmPair.lblSchoolLeft.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			frmPair.lblNameLeft.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
			frmPair.lblCarLeft.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
*/
		}

		private void lstDataMeibo_SelectedIndexChanged(object sender, EventArgs e)
		{
			int n = lstDataMeibo.SelectedIndex;
			txtLeft.Text = strDataMeibo[n, 0];
			

		}

		private void lstDataPair_SelectedIndexChanged(object sender, EventArgs e)
		{
			int n = lstDataPair.SelectedIndex;
			txtLeft.Text = strDataPair[n, 0];
			txtRight.Text = strDataPair[n, 1];
		}





	}
}
