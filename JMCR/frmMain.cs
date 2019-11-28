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
		}

		private void btnTournament_Click(object sender, EventArgs e)
		{
			frmPair f = new frmPair();
			f.ShowDialog();
		}

		private void btnTeam_Click(object sender, EventArgs e)
		{
			frmTeam f = new frmTeam();
			f.ShowDialog();
		}

	}
}
