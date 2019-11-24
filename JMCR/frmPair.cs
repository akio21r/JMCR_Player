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

			pctBackImage.Controls.Add(lblSchoolL);
			pctBackImage.Controls.Add(lblNameL);
			pctBackImage.Controls.Add(lblCarL);
			pctBackImage.Controls.Add(pctL);

			pctBackImage.Controls.Add(lblSchoolR);
			pctBackImage.Controls.Add(lblNameR);
			pctBackImage.Controls.Add(lblCarR);
			pctBackImage.Controls.Add(pctR);

		//	pctBackImage.Controls.Add(pctCourse1);
		//	pctBackImage.Controls.Add(pctCourse2);

			pctBackImage.Controls.Add(pctVS);
		//	axWindowsMediaPlayer1.Controls.Add(lblVS);

			this.FormBorderStyle = FormBorderStyle.None;
			this.WindowState = FormWindowState.Maximized;
		}


		private void ResizeComponents()
		{
			int Width			= ClientSize.Width;
			int Height			= ClientSize.Height;
			int Center			= ClientSize.Width / 2;
			int TextHeight		= TextNameHeightPer * ClientSize.Height / 100;
			int TextTop			= ClientSize.Height - MarginBottom - TextHeight + TextMargin;

			int FontHeight		= ClientSize.Height / 20;
			Font fnt			= new Font("HG正楷書体-PRO", FontHeight);
			lblSchoolL.Font		= lblSchoolR.Font	= fnt;
			lblNameL.Font		= lblNameR.Font		= fnt;
			lblCarL.Font		= lblCarR.Font		= fnt;
			lblL.Font			= lblR.Font			= fnt;

			//lblCar
			lblCarL.Left		= MarginWOut;
			lblCarL.Top		= ClientSize.Height - MarginBottom - lblCarL.Height;
			lblCarR.Left	= Center + MarginWIn;
			lblCarR.Top		= lblCarL.Top;

			//lblName
			lblNameL.Left	= MarginWOut;
			lblNameL.Top		= lblCarL.Top - TextMargin - lblNameL.Height;
			lblNameR.Left	= lblCarR.Left;
			lblNameR.Top	= lblNameL.Top;

			//lblSchool
			lblSchoolL.Left	= MarginWOut;
			lblSchoolL.Top	= lblNameL.Top - TextMargin - lblSchoolL.Height;
			lblSchoolR.Left	= lblCarR.Left;
			lblSchoolR.Top	= lblSchoolL.Top;

			//pctLeft
			pctL.Left		= MarginWOut;
			pctL.Width		= Center - MarginWIn - pctL.Left;
			pctL.Top			= MarginTop;
			pctL.Height		= lblSchoolL.Top - TextMargin - MarginTop;

			//pctRight
			pctR.Left		= Center + MarginWIn;
			pctR.Width		= pctL.Width;
			pctR.Top		= MarginTop;
			pctR.Height		= pctL.Height;

			//pctVS
			pctVS.Left		= Center - pctVS.Width / 2;
			pctVS.Top		= pctL.Top + pctL.Height / 2 - pctVS.Height / 2;

			//pctTitle
			pctTitle.Left	= Center - pctTitle.Width / 2;
			pctTitle.Top	= 0;

			//lblL,R
			lblL.Left		= 0;
			lblL.Top		= 0;
			lblR.Left		= Width - lblR.Width;
			lblR.Top		= 0;

			//Course1,2
			pctCourse1.Left	= 0;
			pctCourse1.Top	= lblL.Height + 10;
			pctCourse2.Left	= Width - pctCourse2.Width;
			pctCourse2.Top	= lblR.Height + 10;

		}

		private void frmTournament_Resize(object sender, EventArgs e)
		{
			ResizeComponents();
		}

		private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
		}

		private void button1_Click(object sender, EventArgs e)
		{
			frmData.ShowDialog();
			lblL.Text	= frmData.SelectNoL.ToString();
			lblR.Text	= frmData.SelectNoR.ToString();
		}


		private void pctVS_Click(object sender, EventArgs e)
		{
			frmData.ShowDialog();
			lblL.Text	= frmData.SelectNoL.ToString();
			lblR.Text	= frmData.SelectNoR.ToString();

		}

		private void lblL_TextChanged(object sender, EventArgs e)
		{
			int n;
			int sel = frmData.SelectNoL;
			for(n=0; n<frmData.meibo_count; n++){
				if(sel == frmData.meibo[n].No){
					pctL.ImageLocation = @"データ\" + sel.ToString("000") + ".jpg";
					lblL.Text		= sel.ToString();
					lblSchoolL.Text	= frmData.meibo[n].School;
					lblNameL.Text	= frmData.meibo[n].Name;
					lblCarL.Text		= frmData.meibo[n].Car;
					break;
				}
			}
			if(n == frmData.meibo_count){		//データがなかったとき
				pctL.ImageLocation = "";
				lblL.Text = "";
				lblSchoolL.Text = "";
				lblNameL.Text = "";
				lblCarL.Text = "";
			}
		}

		private void lblR_TextChanged(object sender, EventArgs e)
		{
			int n;
			int sel = frmData.SelectNoR;
			for(n=0; n<frmData.meibo_count; n++){
				if(sel == frmData.meibo[n].No){
					pctR.ImageLocation = @"データ\" + sel.ToString("000") + ".jpg";
					lblR.Text		= sel.ToString();
					lblSchoolR.Text	= frmData.meibo[n].School;
					lblNameR.Text	= frmData.meibo[n].Name;
					lblCarR.Text	= frmData.meibo[n].Car;
					break;
				}
			}
			if(n == frmData.meibo_count){		//データがなかったとき
				pctR.ImageLocation = "";
				lblR.Text = "";
				lblSchoolR.Text = "";
				lblNameR.Text = "";
				lblCarR.Text = "";
			}
		}

		private void frmPair_KeyDown(object sender, KeyEventArgs e)
		{
			switch(e.KeyCode){
				case Keys.D:
					frmData.dataGridView1.Visible = !frmData.dataGridView1.Visible;
					if(frmData.dataGridView1.Visible){
						frmData.dataGridView1.Focus();
					}
					break;
				case Keys.E:
					this.FormBorderStyle = FormBorderStyle.Sizable;
					this.WindowState = FormWindowState.Normal;
					break;
				case Keys.Escape:
					this.FormBorderStyle = FormBorderStyle.Sizable;
					this.WindowState = FormWindowState.Normal;
				//	this.Close();
					break;
				case Keys.J:
					if(frmData.PairNoNow > 0) frmData.PairNoNow--;
					frmData.SelectNoL = frmData.DataPair[frmData.PairNoNow, 0];
					frmData.SelectNoR = frmData.DataPair[frmData.PairNoNow, 1];

					lblL.Text	= frmData.SelectNoL.ToString();
					lblR.Text	= frmData.SelectNoR.ToString();
					break;
				case Keys.K:
					if(frmData.PairNoNow < frmData.DataPair_count - 1) frmData.PairNoNow++;
					frmData.SelectNoL = frmData.DataPair[frmData.PairNoNow, 0];
					frmData.SelectNoR = frmData.DataPair[frmData.PairNoNow, 1];

					lblL.Text	= frmData.SelectNoL.ToString();
					lblR.Text	= frmData.SelectNoR.ToString();
					break;
			}

		}

	}
}
