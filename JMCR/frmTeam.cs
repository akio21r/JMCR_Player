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
		int		MarginW				= 20;
		int		MarginTop			= 20;
		int		MarginBottom		= 20;
		int		TextNameHeightPer	= 20;
		int		TextMargin			= 20;

		public frmData frmData = new frmData();

		System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"素材\音\don-1.wav");
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
		}

		private void frmTeam_Resize(object sender, EventArgs e)
		{
			ResizeComponents();
		}

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
			txtTeam.Left		= Width - txtTeam.Width;



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
			pct1.Top			= txtTeam.Top + txtTeam.Height + 10;
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



			//pctTitle
		//	pctTitle.Left	= Center - pctTitle.Width / 2;
		//	pctTitle.Top	= 0;
		//	pctTitle.Height	= pct1.Top;


		}

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

		private void Show1()
		{
			int n, sel;
			if(txtNo1.Text == "")
				sel = 0;
			else
				sel = int.Parse(txtNo1.Text);
			for(n=0; n<frmData.meibo_count; n++){
				if(sel == frmData.meibo[n].No){
					player.Play();
					pctFace1.ImageLocation = @"データ\" + frmData.meibo[n].Image;
					lblSchool1.Text		= frmData.meibo[n].School;
					lblName1.Text		= frmData.meibo[n].Name;
					lblCar1.Text		= frmData.meibo[n].Car;
					break;
				}
			}
			if(n == frmData.meibo_count){		//データがなかったとき
				pctFace1.ImageLocation	= "";
				lblSchool1.Text			= "";
				lblName1.Text			= "";
				lblCar1.Text			= "";
			}
		}

		private void Show2()
		{
			int n, sel;
			if(txtNo2.Text == "")
				sel = 0;
			else
				sel = int.Parse(txtNo2.Text);
			for(n=0; n<frmData.meibo_count; n++){
				if(sel == frmData.meibo[n].No){
					player.Play();
					pctFace2.ImageLocation = @"データ\" + frmData.meibo[n].Image;
					lblSchool2.Text		= frmData.meibo[n].School;
					lblName2.Text		= frmData.meibo[n].Name;
					lblCar2.Text		= frmData.meibo[n].Car;
					break;
				}
			}
			if(n == frmData.meibo_count){		//データがなかったとき
				pctFace2.ImageLocation	= "";
				lblSchool2.Text			= "";
				lblName2.Text			= "";
				lblCar2.Text			= "";
			}
		}

		private void Show3()
		{
			int n, sel;
			if(txtNo3.Text == "")
				sel = 0;
			else
				sel = int.Parse(txtNo3.Text);
			for(n=0; n<frmData.meibo_count; n++){
				if(sel == frmData.meibo[n].No){
					player.Play();
					pctFace3.ImageLocation = @"データ\" + frmData.meibo[n].Image;
					lblSchool3.Text		= frmData.meibo[n].School;
					lblName3.Text		= frmData.meibo[n].Name;
					lblCar3.Text		= frmData.meibo[n].Car;
					break;
				}
			}
			if(n == frmData.meibo_count){		//データがなかったとき
				pctFace3.ImageLocation	= "";
				lblSchool3.Text			= "";
				lblName3.Text			= "";
				lblCar3.Text = "";
			}
		}

		private void frmTeam_KeyDown(object sender, KeyEventArgs e)
		{
			switch(e.KeyCode){
				case Keys.E:
					this.FormBorderStyle = FormBorderStyle.Sizable;
					this.WindowState = FormWindowState.Normal;
					break;

				case Keys.Escape:
				//	this.FormBorderStyle = FormBorderStyle.Sizable;
				//	this.WindowState = FormWindowState.Normal;
					this.Close();
					break;
			}
		}

		private void txtNo1_Leave(object sender, EventArgs e)
		{
		//	Show1();
		}

		private void txtNo2_Leave(object sender, EventArgs e)
		{
		//	Show2();
		}

		private void txtNo3_Leave(object sender, EventArgs e)
		{
		//	Show3();
		}

		private void pctTitle_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void lblSchool1_Click(object sender, EventArgs e)
		{
			pctSchool.ImageLocation = @"学校紹介\" + lblSchool1.Text + ".jpg";
			pctSchool.Dock = DockStyle.Fill;
			pctSchool.Visible = true;
		}

		private void lblSchool2_Click(object sender, EventArgs e)
		{
			pctSchool.ImageLocation = @"学校紹介\" + lblSchool2.Text + ".jpg";
			pctSchool.Dock = DockStyle.Fill;
			pctSchool.Visible = true;
		}

		private void lblSchool3_Click(object sender, EventArgs e)
		{
			pctSchool.ImageLocation = @"学校紹介\" + lblSchool3.Text + ".jpg";
			pctSchool.Dock = DockStyle.Fill;
			pctSchool.Visible = true;
		}

		private void pctSchool_Click(object sender, EventArgs e)
		{
			pctSchool.Visible = false;
		}

	}
}
