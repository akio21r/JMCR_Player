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
	public partial class frmPair : Form
	{

		int		MarginWOut			= 20;
		int		MarginWIn			= 100;
		int		MarginTop			= 20;
		int		MarginBottom		= 20;
		int		TextNameHeightPer	= 20;
		int		TextMargin			= 20;

		public frmData frmData = new frmData();

		public frmPair()
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
			int n;
			for(n=0; n<frmData.meibo_count; n++){
				if(txtLeft.Text == frmData.meibo[n].No_str){
					pctLeft.ImageLocation = @"データ\" + txtLeft.Text + ".jpg";
					txtLeft.Text = frmData.strDataMeibo[n, 0];
					lblSchoolLeft.Text = frmData.strDataMeibo[n, 1];
					lblNameLeft.Text = frmData.strDataMeibo[n, 2];
					lblCarLeft.Text = frmData.strDataMeibo[n, 3];
					break;
				}
			}
			if(n == frmData.meibo_count){		//データがなかったとき
				pctLeft.ImageLocation = "";
				txtLeft.Text = "";
				lblSchoolLeft.Text = "";
				lblNameLeft.Text = "";
				lblCarLeft.Text = "";
			}
		}

		private void txtRight_TextChanged(object sender, EventArgs e)
		{
			int n;
			for(n=0; n<frmData.meibo_count; n++){
				if(txtRight.Text == frmData.meibo[n].No_str){
					pctRight.ImageLocation = @"データ\" + txtRight.Text + ".jpg";
					txtRight.Text = frmData.strDataMeibo[n, 0];
					lblSchoolRight.Text = frmData.strDataMeibo[n, 1];
					lblNameRight.Text = frmData.strDataMeibo[n, 2];
					lblCarRight.Text = frmData.strDataMeibo[n, 3];
					break;
				}
			}
			if(n == frmData.meibo_count){		//データがなかったとき
				pctRight.ImageLocation = "";
				txtRight.Text = "";
				lblSchoolRight.Text = "";
				lblNameRight.Text = "";
				lblCarRight.Text = "";
			}
		}

		private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
		}

		private void button1_Click(object sender, EventArgs e)
		{
			frmData.ShowDialog();
			txtLeft.Text	= frmData.txtLeft.Text;
			txtRight.Text	= frmData.txtRight.Text;
		}


		private void frmTournament_KeyPress(object sender, KeyPressEventArgs e)
		{
			switch(e.KeyChar){
				case 'd':
					frmData.dataGridView1.Visible = !frmData.dataGridView1.Visible;
					if(frmData.dataGridView1.Visible){
						frmData.dataGridView1.Focus();
					}

					break;
			}
		}


	}
}
