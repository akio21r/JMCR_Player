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
		public frmData frmData = new frmData();

		public frmTeam()
		{
			InitializeComponent();
		}

		private void txtNo1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == '\r'){
				int n;
				if(txtNo1.Text == "") return;
				int sel = int.Parse(txtNo1.Text);
				for(n=0; n<frmData.meibo_count; n++){
					if(sel == frmData.meibo[n].No){
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
		}

		private void txtNo2_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == '\r'){
				int n;
				if(txtNo2.Text == "") return;
				int sel = int.Parse(txtNo2.Text);
				for(n=0; n<frmData.meibo_count; n++){
					if(sel == frmData.meibo[n].No){
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
		}

		private void txtNo3_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == '\r'){
				int n;
				if(txtNo3.Text == "") return;
				int sel = int.Parse(txtNo3.Text);
				for(n=0; n<frmData.meibo_count; n++){
					if(sel == frmData.meibo[n].No){
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
		}

	}
}
