﻿//======================================================================
// データ操作画面
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
	public partial class frmData : Form
	{
		//--------------------------------------------------------------
		int initNo, initL, initR;		//データ画面が表示されたときの初期値


		//--------------------------------------------------------------
		// コンストラクタ
		public frmData()
		{
			InitializeComponent();
		}

		//--------------------------------------------------------------
		// フォームが読み込まれたとき
		private void frmData_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = frmMain.table;

			//データ画面が表示されたときの初期値を記録しておく
			initNo	= frmMain.PairNoNow;
			initL	= frmMain.SelectNoL;
			initR	= frmMain.SelectNoR;
		
			lstDataPair.Items.Clear();
			for(int i=0; i<frmMain.DataPair_count; i++){
				lstDataPair.Items.Add(	(i+1).ToString("00") + " :  "
									+ frmMain.DataPair[i, 0].ToString("000") + " , "
									+ frmMain.DataPair[i, 1].ToString("000"));
			}
			lstDataPair.SelectedIndex = frmMain.PairNoNow;
			setTextBox();
		}

		//--------------------------------------------------------------
		// 対戦リストの選択行が変更された時は、TextBoxにセットすると同時に名簿も選択しておく
		private void lstDataPair_SelectedIndexChanged(object sender, EventArgs e)
		{
			int n = lstDataPair.SelectedIndex;
			if(n>=0){
				frmMain.PairNoNow = n;
				setTextBox();
			}
		}

		//--------------------------------------------------------------
		// 対戦リストの選択行が変更された時は、TextBoxにセットすると同時に名簿も選択しておく
		private void setTextBox()
		{
			int n = frmMain.PairNoNow;
			txtNo.Text = (n + 1).ToString();
			txtL.Text = frmMain.DataPair[n, 0].ToString();
			txtR.Text = frmMain.DataPair[n, 1].ToString();

			for(int i=0; i<dataGridView1.Rows.Count; i++){
				dataGridView1.Rows[i].Selected = false;
				if(frmMain.SelectNoL == frmMain.meibo[i].No){
					dataGridView1.Rows[i].Selected = true;
				}
				if(frmMain.SelectNoR == frmMain.meibo[i].No){
					dataGridView1.Rows[i].Selected = true;
				}
			}
		}

		//--------------------------------------------------------------
		// キャンセルボタンが押されたら、ゼッケンNoを元に戻す
		private void btnCancel_Click(object sender, EventArgs e)
		{
			frmMain.PairNoNow	= initNo;
			frmMain.SelectNoL	= initL;
			frmMain.SelectNoR	= initR;
			this.Close();
		}

		//--------------------------------------------------------------
		// 対戦リストをダブルクリックしたら左右を入れ替える
		private void lstDataPair_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			int n = lstDataPair.SelectedIndex;
			
			int tmp = frmMain.DataPair[n, 0];
			frmMain.DataPair[n, 0] = frmMain.DataPair[n, 1];
			frmMain.DataPair[n, 1] = tmp;
			
			lstDataPair.Items[n] = (n+1).ToString("00") + " :  "
									+ frmMain.DataPair[n, 0].ToString("000") + " , "
									+ frmMain.DataPair[n, 1].ToString("000");
			lstDataPair.SelectedIndex = n;
		}

		//--------------------------------------------------------------
		private void dataGridView1_SelectionChanged(object sender, EventArgs e)
		{
/*			if(dataGridView1.Rows.Count > 0){
				if(rdL.Checked){
					txtL.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
				//	SelectNoL = int.Parse(txtL.Text);
				}
				if(rdR.Checked){
					txtR.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
				//	SelectNoR = int.Parse(txtR.Text);
				}
			}
*/		}

		private void dataGridView1_DoubleClick(object sender, EventArgs e)
		{
/*			if(rdL.Checked){
				txtL.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
			//	SelectNoL = int.Parse(txtL.Text);
			}
			if(rdR.Checked){
				txtR.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
			//	SelectNoR = int.Parse(txtR.Text);
			}
			this.Close();
*/		}

		//--------------------------------------------------------------
		// ゼッケンNo.テキストボックスを変更したら、内部変数を更新する。
		private void txtL_TextChanged(object sender, EventArgs e)
		{
			if(txtL.Text != ""){
				frmMain.SelectNoL = int.Parse(txtL.Text);
			}
		}

		private void txtR_TextChanged(object sender, EventArgs e)
		{
			if(txtR.Text != ""){
				frmMain.SelectNoR = int.Parse(txtR.Text);
			}
		}

		//--------------------------------------------------------------
		// 対戦リストをクリックしたら、テキストボックスに値をセット
		private void btnToPair_Click(object sender, EventArgs e)
		{
			int n = lstDataPair.SelectedIndex;
			
			frmMain.DataPair[n, 0] = int.Parse(txtL.Text);
			frmMain.DataPair[n, 1] = int.Parse(txtR.Text);
			
			lstDataPair.Items[n] = (n+1).ToString("00") + " :  "
									+ frmMain.DataPair[n, 0].ToString("000") + " , "
									+ frmMain.DataPair[n, 1].ToString("000");
			lstDataPair.SelectedIndex = n;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
		}

		//--------------------------------------------------------------
		// 対戦データの書き込み
		private void btnSave_Click(object sender, EventArgs e)
		{
			// CSVファイルへの書き込み
			string line;
			System.IO.StreamWriter writer = new System.IO.StreamWriter(frmMain.filename, false, Encoding.Default);
			for(int n=0; n < frmMain.DataPair_count; n++){
				line = frmMain.DataPair[n, 0].ToString() + "," + frmMain.DataPair[n, 1].ToString();
				writer.WriteLine(line);
			}
			writer.Close();

			MessageBox.Show( frmMain.filename + "に保存しました", "CSVファイルへの対戦表保存");
		}

	}
}
