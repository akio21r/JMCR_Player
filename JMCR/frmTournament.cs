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
			CSVFileLoad();
		}

		private void CSVFileLoad()
		{
			string line;
			string[] field;
			System.IO.StreamReader reader = new System.IO.StreamReader(@"データ\data.csv", Encoding.Default);
			lstNo.Items.Clear();
			while(!reader.EndOfStream){
				line = reader.ReadLine();
				field = line.Split(',');
				lstNo.Items.Add(field[0]);
				lstSchool.Items.Add(field[1]);
				lstName.Items.Add(field[2]);
				lstCar.Items.Add(field[3]);
			}
			reader.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
 
		}

		private void ResizeComponents()
		{
			int Center			= ClientSize.Width / 2;
			int TextHeight		= TextNameHeightPer * ClientSize.Height / 100;
			int TextTop			= ClientSize.Height - MarginBottom - TextHeight + TextMargin;


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
	//		for(int i=0; i<lstNo.Items.Count; i++){
	//			if(lstNo.Items[i].ToString == txtLeft.Text){
	//				lblSchoolLeft.Text = lstSchool.Items[i].ToString;
	//			}
	//		}

		}

		private void txtRight_TextChanged(object sender, EventArgs e)
		{
			pctRight.ImageLocation = @"データ\" + txtRight.Text + ".jpg";
		}


	}
}
