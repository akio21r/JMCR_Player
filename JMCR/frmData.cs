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
	public partial class frmData : Form
	{
	
		//--------------------------------------------------------------
		//

		public frmData()
		{
			InitializeComponent();
		
		//	CSVFileLoad_Meibo();
		//	CSVFileLoad_Pair();
		}

		private void frmData_Load(object sender, EventArgs e)
		{
		//	CSVFileLoad_Meibo();
		//	CSVFileLoad_Pair();
			dataGridView1.DataSource = frmMain.table;
		}


		private void lstDataPair_SelectedIndexChanged(object sender, EventArgs e)
		{
			int n = lstDataPair.SelectedIndex;
			txtL.Text = frmMain.DataPair[n, 0].ToString();
			txtR.Text = frmMain.DataPair[n, 1].ToString();
		//	SelectNoL = DataPair[n, 0];
		//	SelectNoR = DataPair[n, 1];
			frmMain.PairNoNow = n;
		}

		private void dataGridView1_SelectionChanged(object sender, EventArgs e)
		{
			if(dataGridView1.Rows.Count > 0){
				if(rdL.Checked){
					txtL.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
				//	SelectNoL = int.Parse(txtL.Text);
				}
				if(rdR.Checked){
					txtR.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
				//	SelectNoR = int.Parse(txtR.Text);
				}
			}
		}

		private void dataGridView1_DoubleClick(object sender, EventArgs e)
		{
			if(rdL.Checked){
				txtL.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
			//	SelectNoL = int.Parse(txtL.Text);
			}
			if(rdR.Checked){
				txtR.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
			//	SelectNoR = int.Parse(txtR.Text);
			}
			this.Close();
		}

		private void txtL_TextChanged(object sender, EventArgs e)
		{
			if(txtL.Text != "")
				frmMain.SelectNoL = int.Parse(txtL.Text);
		}

		private void txtR_TextChanged(object sender, EventArgs e)
		{
			if(txtR.Text != "")
				frmMain.SelectNoR = int.Parse(txtR.Text);
		}

	}
}
