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
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
			pctBackImage.Controls.Add(pctKame);
			pctBackImage.Controls.Add(lblTitle);

			//全画面表示
			this.FormBorderStyle = FormBorderStyle.None;
			this.WindowState = FormWindowState.Maximized;
	}

		private void frmMain_Resize(object sender, EventArgs e)
		{
			pctKame.Left = this.ClientSize.Width - pctKame.Width;
			pctKame.Top  = this.ClientSize.Height - pctKame.Height;
		}

		private void btnYosenA_Click(object sender, EventArgs e)
		{
			frmPair f = new frmPair();
			f.lblTitle.Text = "Advanced Class 予選";
			f.ShowDialog();
		}

		private void btnKessyoA_Click(object sender, EventArgs e)
		{
			frmPair f = new frmPair();
			f.lblTitle.Text = "Advanced Class 決勝トーナメント";
			f.ShowDialog();
		}

		private void btnYosenB_Click(object sender, EventArgs e)
		{
			frmPair f = new frmPair();
			f.lblTitle.Text = "Basic Class 予選";
			f.ShowDialog();
		}

		private void btnKessyoB_Click(object sender, EventArgs e)
		{
			frmPair f = new frmPair();
			f.lblTitle.Text = "Basic Class 決勝トーナメント";
			f.ShowDialog();
		}

		private void btnKessyoC_Click(object sender, EventArgs e)
		{
			frmPair f = new frmPair();
			f.lblTitle.Text = "Camera Class";
			f.ShowDialog();
		}

		private void btnTeam_Click(object sender, EventArgs e)
		{
			frmTeam f = new frmTeam();
			f.ShowDialog();
		}

		private void pctKame_Click(object sender, EventArgs e)
		{
			pctPoster.ImageLocation = @"素材\ポスターs.png";
			pctPoster.Dock = DockStyle.Fill;
			pctPoster.Visible = true;
		}

		private void pctPoster_Click(object sender, EventArgs e)
		{
			pctPoster.Visible = false;
		}

		private void lblTitle_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	}
}
