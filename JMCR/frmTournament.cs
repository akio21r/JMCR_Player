using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	public partial class frmTournament : Form
	{
		DataTable table				= new DataTable("Table");
		String[,] strDataMeibo		= new String[1000, 4];	//基本データ
		String[,] strDataPair		= new String[1000, 2];	//対戦表

		int		MarginWOut			= 20;
		int		MarginWIn			= 100;
		int		MarginTop			= 20;
		int		MarginBottom		= 20;
		int		TextNameHeightPer	= 20;
		int		TextMargin			= 20;

		public frmTournament()
		{
			InitializeComponent();
		}

		private void frmTournament_Load(object sender, EventArgs e)
		{
			//MediaPlayerの設定
			axWindowsMediaPlayer1.uiMode = "none";
			axWindowsMediaPlayer1.stretchToFit = true;
			axWindowsMediaPlayer1.Dock = DockStyle.Fill;
			axWindowsMediaPlayer1.settings.setMode("loop", true);
			axWindowsMediaPlayer1.URL = @"素材\fire.mp4";	//渡されたファイルURLを読み込み

			ResizeComponents();
			CSVFileLoad_Meibo();
			CSVFileLoad_Pair();
		}

		private void CSVFileLoad_Meibo()
		{
            // カラム名の追加
            table.Columns.Add("No");
            table.Columns.Add("学校");
            table.Columns.Add("氏名");
            table.Columns.Add("カーネーム");
	
			// CSVファイルの読み込み
			string line;
			string[] field;
			System.IO.StreamReader reader = new System.IO.StreamReader(@"データ\data.csv", Encoding.Default);
			lstDataMeibo.Items.Clear();
			for(int n=0; !reader.EndOfStream; n++){
				line = reader.ReadLine();
				field = line.Split(',');
				lstDataMeibo.Items.Add(field[0] + '\t' + field[1] + '\t' + field[2] + '\t' + field[3]);

				// データを追加
				table.Rows.Add(field[0], field[1], field[2], field[3]);
	
				// String[,]
				strDataMeibo[n, 0] = field[0];
				strDataMeibo[n, 1] = field[1];
				strDataMeibo[n, 2] = field[2];
				strDataMeibo[n, 3] = field[3];
			}
			reader.Close();
		
	
		
            dataGridView1.DataSource = table;
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
				lstDataPair.Items.Add(field[0] + '\t' + field[1]);

				// String[,]
				strDataPair[n, 0] = field[0];
				strDataPair[n, 1] = field[1];
			}
			reader.Close();
		}

		private void ResizeComponents()
		{
			int Center			= ClientSize.Width / 2;
			int TextHeight		= TextNameHeightPer * ClientSize.Height / 100;
			int TextTop			= ClientSize.Height - MarginBottom - TextHeight + TextMargin;

			int FontHeight		= ClientSize.Height / 20;
			Font fnt			= new Font("HG正楷書体-PRO", FontHeight);
			lblSchoolLeft.Font	= lblSchoolRight.Font = fnt;
			lblNameLeft.Font	= lblNameRight.Font = fnt;
			lblCarLeft.Font		= lblCarRight.Font = fnt;

			//lblCar
			lblCarLeft.Left		= MarginWOut;
			lblCarLeft.Top		= ClientSize.Height - MarginBottom - lblCarLeft.Height;
			lblCarRight.Left	= Center + MarginWIn;
			lblCarRight.Top		= lblCarLeft.Top;

			//lblName
			lblNameLeft.Left	= MarginWOut;
			lblNameLeft.Top		= lblCarLeft.Top - TextMargin - lblNameLeft.Height;
			lblNameRight.Left	= lblCarRight.Left;
			lblNameRight.Top	= lblNameLeft.Top;

			//lblSchool
			lblSchoolLeft.Left	= MarginWOut;
			lblSchoolLeft.Top	= lblNameLeft.Top - TextMargin - lblSchoolLeft.Height;
			lblSchoolRight.Left	= lblCarRight.Left;
			lblSchoolRight.Top	= lblSchoolLeft.Top;

			//pctLeft
			pctLeft.Left		= MarginWOut;
			pctLeft.Width		= Center - MarginWIn - pctLeft.Left;
			pctLeft.Top			= MarginTop;
			pctLeft.Height		= lblSchoolLeft.Top - TextMargin - MarginTop;

			//pctRight
			pctRight.Left		= Center + MarginWIn;
			pctRight.Width		= pctLeft.Width;
			pctRight.Top		= MarginTop;
			pctRight.Height		= pctLeft.Height;

			//lblVS
			lblVS.Left			= Center - lblVS.Width / 2;
			lblVS.Top			= pctLeft.Top + pctLeft.Height / 2 - lblVS.Height / 2;

			//txt
			txtLeft.Left		= pctLeft.Left;
			txtLeft.Top			= pctLeft.Top - txtLeft.Height;
			txtRight.Left		= pctRight.Left;
			txtRight.Top		= txtLeft.Top;
			
		}

		private void frmTournament_Resize(object sender, EventArgs e)
		{
			ResizeComponents();
		}

		private void txtLeft_TextChanged(object sender, EventArgs e)
		{
			pctLeft.ImageLocation = @"データ\" + txtLeft.Text + ".jpg";
		}

		private void txtRight_TextChanged(object sender, EventArgs e)
		{
			pctRight.ImageLocation = @"データ\" + txtRight.Text + ".jpg";
		}

		private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
		}

		private void button1_Click(object sender, EventArgs e)
		{
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dataGridView1_SelectionChanged(object sender, EventArgs e)
		{
			txtLeft.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
			lblSchoolLeft.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			lblNameLeft.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
			lblCarLeft.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

		}

		private void lstData_SelectedIndexChanged(object sender, EventArgs e)
		{
			int n = lstDataMeibo.SelectedIndex;
			txtLeft.Text = strDataMeibo[n, 0];
			lblSchoolLeft.Text = strDataMeibo[n, 1];
			lblNameLeft.Text = strDataMeibo[n, 2];
			lblCarLeft.Text = strDataMeibo[n, 3];

		}

		private void frmTournament_KeyPress(object sender, KeyPressEventArgs e)
		{
			switch(e.KeyChar){
				case 'd':
					dataGridView1.Visible = !dataGridView1.Visible;
					if(dataGridView1.Visible){
						dataGridView1.Focus();
					}

					break;
			}
		}

		private void lstDataPair_SelectedIndexChanged(object sender, EventArgs e)
		{
			int n = lstDataPair.SelectedIndex;
		//	SelectLeft (strDataPair[lstDataPair.SelectedIndex, 0]);
		//	SelectRight(strDataPair[lstDataPair.SelectedIndex, 1]);
		}

		private void SelectLeft(int n)
		{
		}

	}
}
