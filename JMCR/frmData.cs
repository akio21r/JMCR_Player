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
		//

		public frmData()
		{
			InitializeComponent();
		
			CSVFileLoad_Meibo();
			CSVFileLoad_Pair();
		}

		private void frmData_Load(object sender, EventArgs e)
		{
		//	CSVFileLoad_Meibo();
		//	CSVFileLoad_Pair();
		}

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
	
				// データを追加
				frmMain.table.Rows.Add(
					frmMain.meibo[frmMain.meibo_count].No.ToString("000"),
					frmMain.meibo[frmMain.meibo_count].School,
					frmMain.meibo[frmMain.meibo_count].Name,
					frmMain.meibo[frmMain.meibo_count].Car,
					frmMain.meibo[frmMain.meibo_count].Image);
	
			}
			
			reader.Close();

			dataGridView1.DataSource = frmMain.table;
		}

		// 対戦データの読み込み
		public void CSVFileLoad_Pair()
		{
			// CSVファイルの読み込み
			string line;
			string[] field;
			System.IO.StreamReader reader = new System.IO.StreamReader(@"データ\dataPair.csv", Encoding.Default);
			lstDataPair.Items.Clear();
			for(frmMain.DataPair_count=0; !reader.EndOfStream; frmMain.DataPair_count++){
				line = reader.ReadLine();
				field = line.Split(',');

				// 対戦データ
				frmMain.DataPair[frmMain.DataPair_count, 0] = int.Parse(field[0]);
				frmMain.DataPair[frmMain.DataPair_count, 1] = int.Parse(field[1]);

				// String[,]
			//	strDataPair[n, 0] = DataPair[n, 0].ToString("000");
			//	strDataPair[n, 1] = DataPair[n, 1].ToString("000");

				// ListBox
				lstDataPair.Items.Add(	frmMain.DataPair[frmMain.DataPair_count, 0].ToString("000") + '\t'
										+ frmMain.DataPair[frmMain.DataPair_count, 1].ToString("000"));
			}
			reader.Close();
			frmMain.SelectNoL = frmMain.DataPair[0, 0];
			frmMain.SelectNoR = frmMain.DataPair[0, 1];
		}

		private void lstDataPair_SelectedIndexChanged(object sender, EventArgs e)
		{
			int n = lstDataPair.SelectedIndex;
			txtL.Text = frmMain.DataPair[n, 0].ToString();
			txtR.Text = frmMain.DataPair[n, 1].ToString();
		//	SelectNoL = DataPair[n, 0];
		//	SelectNoR = DataPair[n, 1];
			frmMain.PairNoNow = n;
		}

		private void dataGridView1_SelectionChanged(object sender, EventArgs e)
		{
			if(dataGridView1.Rows.Count > 0){
				if(rdL.Checked){
					txtL.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
				//	SelectNoL = int.Parse(txtL.Text);
				}
				if(rdR.Checked){
					txtR.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
				//	SelectNoR = int.Parse(txtR.Text);
				}
			}
		}

		private void dataGridView1_DoubleClick(object sender, EventArgs e)
		{
			if(rdL.Checked){
				txtL.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
			//	SelectNoL = int.Parse(txtL.Text);
			}
			if(rdR.Checked){
				txtR.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
			//	SelectNoR = int.Parse(txtR.Text);
			}
			this.Close();
		}

		private void txtL_TextChanged(object sender, EventArgs e)
		{
			if(txtL.Text != "")
				frmMain.SelectNoL = int.Parse(txtL.Text);
		}

		private void txtR_TextChanged(object sender, EventArgs e)
		{
			if(txtR.Text != "")
				frmMain.SelectNoR = int.Parse(txtR.Text);
		}

	}
}
