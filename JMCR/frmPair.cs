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

		int		MarginW				= 20;
		int		MarginWIn			= 100;
		int		MarginTop			= 20;
		int		MarginBottom		= 20;
		int		TextNameHeightPer	= 20;
		int		TextMargin			= 20;

		public frmData frmData = new frmData();

		public frmPair()
		{
			InitializeComponent();

			//MediaPlayerの設定
			axWindowsMediaPlayer1.settings.autoStart = false;
			axWindowsMediaPlayer1.uiMode = "none";
			axWindowsMediaPlayer1.stretchToFit = true;
		//	axWindowsMediaPlayer1.Dock = DockStyle.Fill;
		//	axWindowsMediaPlayer1.fullScreen = true;
		//	axWindowsMediaPlayer1.settings.setMode("loop", true);
			axWindowsMediaPlayer1.URL = frmMain.movFileName_Next;	//渡されたファイルURLを読み込み
			axWindowsMediaPlayer1.Visible = false;

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

			pctBackImage.Controls.Add(lblTitle);
			pctBackImage.Controls.Add(pctVS);
			pctBackImage.Controls.Add(lblCount);

		//	axWindowsMediaPlayer1.Controls.Add(lblVS);

			//全画面表示
			this.FormBorderStyle = FormBorderStyle.None;
			this.WindowState = FormWindowState.Maximized;

			pctL.Controls.Add(pctWinL);
			pctR.Controls.Add(pctWinR);

			lblCount.Text = (frmMain.PairNoNow+1).ToString();
		}

		private void ResizeComponents()
		{
			int Width			= ClientSize.Width;
			int Height			= ClientSize.Height;
			int Center			= ClientSize.Width / 2;
			int TextHeight		= TextNameHeightPer * ClientSize.Height / 100;
			int TextTop			= ClientSize.Height - MarginBottom - TextHeight + TextMargin;

			int FontHeight		= ClientSize.Height / 20;
			Font fnt			= new Font("HG正楷書体-PRO", FontHeight, FontStyle.Regular, GraphicsUnit.Pixel);
			Font fntS			= new Font("HG正楷書体-PRO", FontHeight*3/4, FontStyle.Regular, GraphicsUnit.Pixel);
			Font fntL			= new Font("HG正楷書体-PRO", FontHeight*4/3, FontStyle.Regular, GraphicsUnit.Pixel);

			lblSchoolL.Font		= lblSchoolR.Font	= fnt;
			lblNameL.Font		= lblNameR.Font		= fntL;
			lblCarL.Font		= lblCarR.Font		= fnt;
			lblL.Font			= lblR.Font			= fnt;

			//lblCar
			lblCarL.Left	= MarginW;
			lblCarL.Top		= ClientSize.Height - MarginBottom - lblCarL.Height;
			lblCarR.Left	= Center + MarginWIn;
			lblCarR.Top		= lblCarL.Top;

			//lblName
			lblNameL.Left	= MarginW;
			lblNameL.Top		= lblCarL.Top - TextMargin - lblNameL.Height;
			lblNameR.Left	= lblCarR.Left;
			lblNameR.Top	= lblNameL.Top;

			//lblSchool
			lblSchoolL.Left	= MarginW;
			lblSchoolL.Top	= lblNameL.Top - TextMargin - lblSchoolL.Height;
			lblSchoolR.Left	= lblCarR.Left;
			lblSchoolR.Top	= lblSchoolL.Top;

			//pctLeft
			pctL.Left		= MarginW;
			pctL.Width		= Center - MarginWIn - pctL.Left;
			pctL.Top		= lblL.Top + lblL.Height + 5;
			pctL.Height		= lblSchoolL.Top - TextMargin - pctL.Top;

			//pctRight
			pctR.Left		= Center + MarginWIn;
			pctR.Width		= pctL.Width;
			pctR.Top		= pctL.Top;
			pctR.Height		= pctL.Height;

			//pctVS
			pctVS.Left		= Center - pctVS.Width / 2;
			pctVS.Top		= pctL.Top + pctL.Height / 2 - pctVS.Height / 2;

			//lblCount
			lblCount.Left	= Center - lblCount.Width / 2;
			lblCount.Top	= lblTitle.Top + lblTitle.Height + 20;

			//lblTitle
			lblTitle.Left	= Center - lblTitle.Width / 2;
			lblTitle.Top	= 0;
			lblTitle.Height	= pctL.Top;

			//lblL,R
			lblL.Left		= 0;
			lblR.Left		= Width - lblR.Width;
			lblL.Top		=  lblR.Top		= 0;
			lblL.Height		=  lblR.Height	= FontHeight;

			//Course1,2
			pctCourse1.Left	= 0;
			pctCourse1.Top	= lblL.Height + 10;
			pctCourse2.Left	= Width - pctCourse2.Width;
			pctCourse2.Top	= lblR.Height + 10;

			lblL.Text		= frmMain.SelectNoL.ToString();
			lblR.Text		= frmMain.SelectNoR.ToString();

			pctWinL.Left	= pctL.Width/2 - pctWinL.Width/2;
			pctWinL.Top		= pctL.Height/2 - pctWinL.Height/2;
			pctWinR.Left	= pctR.Width/2 - pctWinR.Width/2;
			pctWinR.Top		= pctR.Height/2 - pctWinR.Height/2;

			axWindowsMediaPlayer1.Top = 0;
			axWindowsMediaPlayer1.Left = 0;
			axWindowsMediaPlayer1.Width = Width;
			axWindowsMediaPlayer1.Height = Height;
		}

		private void frmTournament_Resize(object sender, EventArgs e)
		{
			ResizeComponents();
		}

		private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
		}

		private void pctVS_Click(object sender, EventArgs e)
		{
			String l,r;
			l = lblL.Text;
			r = lblR.Text;
			if(r == "") frmMain.SelectNoL = 0;
			else        frmMain.SelectNoL = int.Parse(r);
			if(l == "") frmMain.SelectNoR = 0;
			else        frmMain.SelectNoR = int.Parse(l);
	
			lblL.Text = r;
			lblR.Text = l;
		}

		private void lblL_TextChanged(object sender, EventArgs e)
		{
			int n;
			int sel = frmMain.SelectNoL;
			for(n=0; n<frmMain.meibo_count; n++){
				if(sel == frmMain.meibo[n].No){
					pctL.ImageLocation = frmMain.imgFolder_Face + frmMain.meibo[n].Image;
					lblL.Text		= sel.ToString();
					lblSchoolL.Text	= frmMain.meibo[n].School;
					lblNameL.Text	= frmMain.meibo[n].Name;
					lblCarL.Text		= frmMain.meibo[n].Car;
					break;
				}
			}
			if(n == frmMain.meibo_count){		//データがなかったとき
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
			int sel = frmMain.SelectNoR;
			for(n=0; n<frmMain.meibo_count; n++){
				if(sel == frmMain.meibo[n].No){
					pctR.ImageLocation = frmMain.imgFolder_Face + frmMain.meibo[n].Image;
					lblR.Text		= sel.ToString();
					lblSchoolR.Text	= frmMain.meibo[n].School;
					lblNameR.Text	= frmMain.meibo[n].Name;
					lblCarR.Text	= frmMain.meibo[n].Car;
					break;
				}
			}
			if(n == frmMain.meibo_count){		//データがなかったとき
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
				//	this.FormBorderStyle = FormBorderStyle.Sizable;
				//	this.WindowState = FormWindowState.Normal;
					this.Close();
					break;
				case Keys.Up:
					GoPrev();
					break;

				case Keys.Down:
					GoNext(false);
					break;

				case Keys.Left:
					pctWinL.Visible = true;
					pctWinR.Visible = false;
					break;
	
				case Keys.Right:
					pctWinL.Visible = false;
					pctWinR.Visible = true;
					break;
	
			}

		}

		private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
		{
			switch (e.newState){
				case (int)WMPLib.WMPPlayState.wmppsStopped:
					//停止時
					break;

				case (int)WMPLib.WMPPlayState.wmppsPlaying:
					//再生時
					break;

				case (int)WMPLib.WMPPlayState.wmppsMediaEnded:
					//再生終了時
				//	pctBackImage.Visible = true;
					axWindowsMediaPlayer1.Visible = false;
				//	pctL.Visible = pctR.Visible = true;
					break;

				default:
					break;
				}
		}

		private void pctBackImage_MouseClick(object sender, MouseEventArgs e)
		{
			switch(e.Button){
				case MouseButtons.Left:
					GoNext(true);
					break;
				case MouseButtons.Right:
					ShowData();
					break;
			}
		}

		private void GoNext(bool movie)
		{
			if(movie){
				pctBackImage.Visible = false;
				pctL.Visible = pctR.Visible = false;

				axWindowsMediaPlayer1.Visible = true;
				axWindowsMediaPlayer1.Ctlcontrols.play();
			}
			if(frmMain.PairNoNow < frmMain.DataPair_count - 1) frmMain.PairNoNow++;
			lblCount.Text = (frmMain.PairNoNow+1).ToString();
			frmMain.SelectNoL = frmMain.DataPair[frmMain.PairNoNow, 0];
			frmMain.SelectNoR = frmMain.DataPair[frmMain.PairNoNow, 1];
			lblL.Text	= frmMain.SelectNoL.ToString();
			lblR.Text	= frmMain.SelectNoR.ToString();
			pctWinL.Visible = false;
			pctWinR.Visible = false;
			pctL.Visible = pctR.Visible = true;
			pctBackImage.Visible = true;
		}

		private void GoPrev()
		{
			if(frmMain.PairNoNow > 0) frmMain.PairNoNow--;
			lblCount.Text = (frmMain.PairNoNow+1).ToString();
			frmMain.SelectNoL = frmMain.DataPair[frmMain.PairNoNow, 0];
			frmMain.SelectNoR = frmMain.DataPair[frmMain.PairNoNow, 1];
			lblL.Text	= frmMain.SelectNoL.ToString();
			lblR.Text	= frmMain.SelectNoR.ToString();
			pctWinL.Visible = false;
			pctWinR.Visible = false;
		}

		private void ShowData()
		{
			frmData.ShowDialog();
			lblL.Text	= frmMain.SelectNoL.ToString();
			lblR.Text	= frmMain.SelectNoR.ToString();
		}

		private void lblTitle_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void lblL_Click(object sender, EventArgs e)
		{
			frmData.rdL.Checked = true;
			frmData.ShowDialog();
			lblL.Text	= frmMain.SelectNoL.ToString();
		}

		private void lblR_Click(object sender, EventArgs e)
		{
			frmData.rdR.Checked = true;
			frmData.ShowDialog();
			lblR.Text	= frmMain.SelectNoR.ToString();
		}

		private void lblSchoolL_Click(object sender, EventArgs e)
		{
			//
			pctSchool.ImageLocation = frmMain.imgFolder_School + lblSchoolL.Text + ".jpg";
			pctSchool.Dock = DockStyle.Fill;
			pctSchool.Visible = true;
		}

		private void lblSchoolR_Click(object sender, EventArgs e)
		{
			pctSchool.ImageLocation = frmMain.imgFolder_School + lblSchoolR.Text + ".jpg";
			pctSchool.Dock = DockStyle.Fill;
			pctSchool.Visible = true;
		}

		private void pctSchool_Click(object sender, EventArgs e)
		{
			pctSchool.Visible = false;
		}

		private void pctL_Click(object sender, EventArgs e)
		{
			//
			pctWinL.Visible = true;
			pctWinR.Visible = false;

		}

		private void pctR_Click(object sender, EventArgs e)
		{
			//
			pctWinL.Visible = false;
			pctWinR.Visible = true;
		}

	}
}
