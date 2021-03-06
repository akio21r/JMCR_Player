﻿//======================================================================
// 地区対抗団体戦の出走者表示画面
//======================================================================
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
	public partial class frmTeam : Form
	{
		//--------------------------------------------------------------
		// 各種変数
		int		MarginW				= 20;
		int		MarginTop			= 20;
		int		MarginBottom		= 20;
		int		TextNameHeightPer	= 20;
		int		TextMargin			= 20;

		int NoArea = 0;			// エリアNo.	1:北海道 ～ 9:九州
		bool Course = false;	// false = 1コース, true = 2コース
		public frmData frmData = new frmData();

		System.Media.SoundPlayer player = new System.Media.SoundPlayer(frmMain.wavFileName_Don);

		//--------------------------------------------------------------
		// コンストラクタ
		public frmTeam()
		{
			InitializeComponent();
			this.FormBorderStyle = FormBorderStyle.None;
			this.WindowState = FormWindowState.Maximized;

			pctBackImage.Controls.Add(pctTitle);
			pctBackImage.Controls.Add(pct1);
			pctBackImage.Controls.Add(pct2);
			pctBackImage.Controls.Add(pct3);
			pctBackImage.Controls.Add(pctFace1);
			pctBackImage.Controls.Add(pctFace2);
			pctBackImage.Controls.Add(pctFace3);
			pctBackImage.Controls.Add(lblCourse);
		}

		//--------------------------------------------------------------
		private void frmTeam_Resize(object sender, EventArgs e)
		{
			ResizeComponents();
		}

		//--------------------------------------------------------------
		// 画面リサイズ時の配置調整
		private void ResizeComponents()
		{
			int Width			= ClientSize.Width;
			int Height			= ClientSize.Height;
			int Center			= ClientSize.Width / 2;
			int Width3			= ClientSize.Width / 3 - MarginW * 2;
			int Left1			= MarginW;
			int Left2			= ClientSize.Width / 3 + MarginW;
			int Left3			= ClientSize.Width * 2 / 3 + MarginW;
			int TextHeight		= TextNameHeightPer * ClientSize.Height / 100;
			int TextTop			= ClientSize.Height - MarginBottom - TextHeight + TextMargin;

			int FontHeight		= ClientSize.Height / 20;
			Font fnt			= new Font("HG正楷書体-PRO", FontHeight, FontStyle.Regular, GraphicsUnit.Pixel);
			Font fntS			= new Font("HG正楷書体-PRO", FontHeight*3/4, FontStyle.Regular, GraphicsUnit.Pixel);
			Font fntL			= new Font("HG正楷書体-PRO", FontHeight*4/3, FontStyle.Regular, GraphicsUnit.Pixel);

			lblSchool1.Font		= lblSchool2.Font	= lblSchool3.Font	= fntS;
			lblName1.Font		= lblName2.Font		= lblName3.Font		= fntL;
			lblCar1.Font		= lblCar2.Font		= lblCar3.Font		= fnt;
			txtNo1.Font			= txtNo2.Font		= txtNo3.Font		= fnt;

			//txtTeam
			txtArea.Left		= Width - txtArea.Width;
			lstArea.Left		= Width - lstArea.Width;



			//lblCar
			lblCar1.Left		= Left1;
			lblCar2.Left		= Left2;
			lblCar3.Left		= Left3;
			lblCar1.Top			= ClientSize.Height - MarginBottom - lblCar1.Height;
			lblCar2.Top			= lblCar1.Top;
			lblCar3.Top			= lblCar1.Top;

			//lblName
			lblName1.Left		= Left1;
			lblName2.Left		= Left2;
			lblName3.Left		= Left3;
			lblName1.Top		= lblCar1.Top - TextMargin - lblName1.Height;
			lblName2.Top		= lblName1.Top;
			lblName3.Top		= lblName1.Top;

			//lblSchool
			lblSchool1.Left		= Left1;
			lblSchool2.Left		= Left2;
			lblSchool3.Left		= Left3;
			lblSchool1.Top		= lblName1.Top - TextMargin - lblSchool1.Height;
			lblSchool2.Top		= lblSchool1.Top;
			lblSchool3.Top		= lblSchool1.Top;

			//pct1-3
			pct1.Left			= Left1;
			pct2.Left			= Left2;
			pct3.Left			= Left3;
			pct1.Top			= txtArea.Top + txtArea.Height + 10;
			pct2.Top			= pct1.Top;
			pct3.Top			= pct1.Top;

			//txtNo
			txtNo1.Left			= pct1.Left + pct1.Width;
			txtNo2.Left			= pct2.Left + pct2.Width;
			txtNo3.Left			= pct3.Left + pct3.Width;
			txtNo1.Top			= pct1.Top + pct1.Height / 2 - txtNo1.Height / 2;
			txtNo2.Top			= txtNo1.Top;
			txtNo3.Top			= txtNo1.Top;

			//pctFace
			pctFace1.Left		= Left1;
			pctFace2.Left		= Left2;
			pctFace3.Left		= Left3;
			pctFace1.Width		= Width3;
			pctFace2.Width		= Width3;
			pctFace3.Width		= Width3;
			pctFace1.Top		= txtNo1.Top + txtNo1.Height + 5;
			pctFace2.Top		= pctFace1.Top;
			pctFace3.Top		= pctFace1.Top;
			pctFace1.Height		= lblSchool1.Top - TextMargin - pctFace1.Top;
			pctFace2.Height		= pctFace1.Height;
			pctFace3.Height		= pctFace1.Height;

			//Win
			pctFace1.Controls.Add(pctWin1);
			pctFace2.Controls.Add(pctWin2);
			pctFace3.Controls.Add(pctWin3);
			pctWin1.Left		= pctFace1.Width/2 - pctWin1.Width/2;
			pctWin1.Top			= pctFace1.Height/2 - pctWin1.Height/2;
			pctWin2.Left		= pctFace2.Width/2 - pctWin2.Width/2;
			pctWin2.Top			= pctFace2.Height/2 - pctWin2.Height/2;
			pctWin3.Left		= pctFace3.Width/2 - pctWin3.Width/2;
			pctWin3.Top			= pctFace3.Height/2 - pctWin3.Height/2;
		}

		//--------------------------------------------------------------
		// ゼッケンNo.テキストボックスでキーが押された時
		private void txtNo1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)Keys.Enter){
				Show1();
				e.Handled = true;
			}
			if(e.KeyChar == (char)Keys.Escape){
				e.Handled = true;
			}
		}

		private void txtNo2_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)Keys.Enter){
				Show2();
				e.Handled = true;
			}
			if(e.KeyChar == (char)Keys.Escape){
				e.Handled = true;
			}
		}

		private void txtNo3_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)Keys.Enter){
				Show3();
				e.Handled = true;
			}
			if(e.KeyChar == (char)Keys.Escape){
				e.Handled = true;
			}
		}

		//--------------------------------------------------------------
		// 先鋒表示
		private void Show1()
		{
			int n, sel;
			if(txtNo1.Text == "")
				sel = 0;
			else
				sel = int.Parse(txtNo1.Text);
			for(n=0; n<frmMain.meibo_count; n++){
				if(sel == frmMain.meibo[n].No){
					player.Play();
					pctFace1.ImageLocation = frmMain.imgFolder_Face + frmMain.meibo[n].Image;
					lblSchool1.Text		= frmMain.meibo[n].School;
					lblName1.Text		= frmMain.meibo[n].Name;
					lblCar1.Text		= frmMain.meibo[n].Car;
					break;
				}
			}
			if(n == frmMain.meibo_count){		//データがなかったとき
				pctFace1.ImageLocation	= "";
				lblSchool1.Text			= "";
				lblName1.Text			= "";
				lblCar1.Text			= "";
			}
		}

		// 中堅表示
		private void Show2()
		{
			int n, sel;
			if(txtNo2.Text == "")
				sel = 0;
			else
				sel = int.Parse(txtNo2.Text);
			for(n=0; n<frmMain.meibo_count; n++){
				if(sel == frmMain.meibo[n].No){
					player.Play();
					pctFace2.ImageLocation = frmMain.imgFolder_Face + frmMain.meibo[n].Image;
					lblSchool2.Text		= frmMain.meibo[n].School;
					lblName2.Text		= frmMain.meibo[n].Name;
					lblCar2.Text		= frmMain.meibo[n].Car;
					break;
				}
			}
			if(n == frmMain.meibo_count){		//データがなかったとき
				pctFace2.ImageLocation	= "";
				lblSchool2.Text			= "";
				lblName2.Text			= "";
				lblCar2.Text			= "";
			}
		}

		// 大将表示
		private void Show3()
		{
			int n, sel;
			if(txtNo3.Text == "")
				sel = 0;
			else
				sel = int.Parse(txtNo3.Text);
			for(n=0; n<frmMain.meibo_count; n++){
				if(sel == frmMain.meibo[n].No){
					player.Play();
					pctFace3.ImageLocation = frmMain.imgFolder_Face + frmMain.meibo[n].Image;
					lblSchool3.Text		= frmMain.meibo[n].School;
					lblName3.Text		= frmMain.meibo[n].Name;
					lblCar3.Text		= frmMain.meibo[n].Car;
					break;
				}
			}
			if(n == frmMain.meibo_count){		//データがなかったとき
				pctFace3.ImageLocation	= "";
				lblSchool3.Text			= "";
				lblName3.Text			= "";
				lblCar3.Text = "";
			}
		}

		//--------------------------------------------------------------
		// キーが押されたとき
		private void frmTeam_KeyDown(object sender, KeyEventArgs e)
		{
			switch(e.KeyCode){
				case Keys.E:
					this.FormBorderStyle = FormBorderStyle.Sizable;
					this.WindowState = FormWindowState.Normal;
					break;

				case Keys.Escape:
					this.Close();
					break;
			}
		}

		//--------------------------------------------------------------
		// タイトル画面クリックで閉じる
		private void pctTitle_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		//--------------------------------------------------------------
		// 学校名クリックで学校紹介画像表示
		private void lblSchool1_Click(object sender, EventArgs e)
		{
			pctSchool.ImageLocation = frmMain.imgFolder_School + lblSchool1.Text + ".jpg";
			pctSchool.Dock = DockStyle.Fill;
			pctSchool.Visible = true;
		}

		private void lblSchool2_Click(object sender, EventArgs e)
		{
			pctSchool.ImageLocation = frmMain.imgFolder_School + lblSchool2.Text + ".jpg";
			pctSchool.Dock = DockStyle.Fill;
			pctSchool.Visible = true;
		}

		private void lblSchool3_Click(object sender, EventArgs e)
		{
			pctSchool.ImageLocation = frmMain.imgFolder_School + lblSchool3.Text + ".jpg";
			pctSchool.Dock = DockStyle.Fill;
			pctSchool.Visible = true;
		}

		//--------------------------------------------------------------
		// 学校紹介画像クリックで閉じる
		private void pctSchool_Click(object sender, EventArgs e)
		{
			pctSchool.Visible = false;
		}

		//--------------------------------------------------------------
		// 地区名クリックで地区名選択リストボックス表示
		private void txtArea_Click(object sender, EventArgs e)
		{
			lstArea.Visible = true;
		}

		//--------------------------------------------------------------
		// 地区名選択リストボックス
		private void lstArea_SelectedIndexChanged(object sender, EventArgs e)
		{
			NoArea = lstArea.SelectedIndex + 1;
			txtArea.Text = lstArea.SelectedItem.ToString();
			lstArea.Visible = false;

			txtNo1.Text = frmMain.tableTeam[NoArea,0].ToString();
			txtNo2.Text = frmMain.tableTeam[NoArea,1].ToString();
			txtNo3.Text = frmMain.tableTeam[NoArea,2].ToString();
			Show1();
			Show2();
			Show3();
			pctWin1.Visible = false;
			pctWin2.Visible = false;
			pctWin3.Visible = false;
		}

		//--------------------------------------------------------------
		// 個人写真クリックで「WIN」の表示／非表示切り替え
		private void pctFace1_Click(object sender, EventArgs e)
		{
			pctWin1.Visible = !pctWin1.Visible;
		}

		private void pctFace2_Click(object sender, EventArgs e)
		{
			pctWin2.Visible = !pctWin2.Visible;
		}

		private void pctFace3_Click(object sender, EventArgs e)
		{
			pctWin3.Visible = !pctWin3.Visible;
		}

		//--------------------------------------------------------------
		// 「WIN」クリックで非表示
		private void pctWin1_Click(object sender, EventArgs e)
		{
			pctWin1.Visible = false;
		}

		private void pctWin2_Click(object sender, EventArgs e)
		{
			pctWin2.Visible = false;
		}

		private void pctWin3_Click(object sender, EventArgs e)
		{
			pctWin3.Visible = false;
		}

		//--------------------------------------------------------------
		// １コース／２コースの切り替え
		private void lblCourse_Click(object sender, EventArgs e)
		{
			if(Course){			// false = 1コース, true = 2コース
				Course = false;
				lblCourse.BackColor = Color.Blue;
				lblCourse.Text = "１コース";
			}
			else{
				Course = true;
				lblCourse.BackColor = Color.Red;
				lblCourse.Text = "２コース";
			}

		}
	}
}
