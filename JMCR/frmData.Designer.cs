﻿namespace JMCR
{
	partial class frmData
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.lstDataPair = new System.Windows.Forms.ListBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtL = new System.Windows.Forms.TextBox();
			this.txtR = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rdR = new System.Windows.Forms.RadioButton();
			this.rdL = new System.Windows.Forms.RadioButton();
			this.btnOK = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnAdvanced = new System.Windows.Forms.Button();
			this.btnBasic = new System.Windows.Forms.Button();
			this.btnCamera = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// lstDataPair
			// 
			this.lstDataPair.Dock = System.Windows.Forms.DockStyle.Right;
			this.lstDataPair.FormattingEnabled = true;
			this.lstDataPair.ItemHeight = 12;
			this.lstDataPair.Location = new System.Drawing.Point(560, 0);
			this.lstDataPair.Name = "lstDataPair";
			this.lstDataPair.Size = new System.Drawing.Size(87, 563);
			this.lstDataPair.TabIndex = 15;
			this.lstDataPair.SelectedIndexChanged += new System.EventHandler(this.lstDataPair_SelectedIndexChanged);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 21;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.ShowEditingIcon = false;
			this.dataGridView1.Size = new System.Drawing.Size(560, 464);
			this.dataGridView1.TabIndex = 17;
			this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
			this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
			// 
			// txtL
			// 
			this.txtL.BackColor = System.Drawing.Color.Teal;
			this.txtL.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.txtL.ForeColor = System.Drawing.Color.White;
			this.txtL.Location = new System.Drawing.Point(35, 12);
			this.txtL.Name = "txtL";
			this.txtL.Size = new System.Drawing.Size(98, 31);
			this.txtL.TabIndex = 19;
			this.txtL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtL.TextChanged += new System.EventHandler(this.txtL_TextChanged);
			// 
			// txtR
			// 
			this.txtR.BackColor = System.Drawing.Color.Teal;
			this.txtR.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.txtR.ForeColor = System.Drawing.Color.White;
			this.txtR.Location = new System.Drawing.Point(179, 12);
			this.txtR.Name = "txtR";
			this.txtR.Size = new System.Drawing.Size(98, 31);
			this.txtR.TabIndex = 20;
			this.txtR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtR.TextChanged += new System.EventHandler(this.txtR_TextChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnCamera);
			this.panel1.Controls.Add(this.btnBasic);
			this.panel1.Controls.Add(this.btnAdvanced);
			this.panel1.Controls.Add(this.rdR);
			this.panel1.Controls.Add(this.rdL);
			this.panel1.Controls.Add(this.btnOK);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txtL);
			this.panel1.Controls.Add(this.txtR);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(560, 99);
			this.panel1.TabIndex = 23;
			// 
			// rdR
			// 
			this.rdR.AutoSize = true;
			this.rdR.Location = new System.Drawing.Point(179, 49);
			this.rdR.Name = "rdR";
			this.rdR.Size = new System.Drawing.Size(57, 16);
			this.rdR.TabIndex = 27;
			this.rdR.TabStop = true;
			this.rdR.Text = "↑右へ";
			this.rdR.UseVisualStyleBackColor = true;
			// 
			// rdL
			// 
			this.rdL.AutoSize = true;
			this.rdL.Checked = true;
			this.rdL.Location = new System.Drawing.Point(35, 49);
			this.rdL.Name = "rdL";
			this.rdL.Size = new System.Drawing.Size(57, 16);
			this.rdL.TabIndex = 26;
			this.rdL.TabStop = true;
			this.rdL.Text = "↑左へ";
			this.rdL.UseVisualStyleBackColor = true;
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(283, 3);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(103, 62);
			this.btnOK.TabIndex = 25;
			this.btnOK.Text = "選択";
			this.btnOK.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(156, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(17, 12);
			this.label2.TabIndex = 24;
			this.label2.Text = "右";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(17, 12);
			this.label1.TabIndex = 23;
			this.label1.Text = "左";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.dataGridView1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 99);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(560, 464);
			this.panel2.TabIndex = 24;
			// 
			// btnAdvanced
			// 
			this.btnAdvanced.Location = new System.Drawing.Point(407, 11);
			this.btnAdvanced.Name = "btnAdvanced";
			this.btnAdvanced.Size = new System.Drawing.Size(75, 23);
			this.btnAdvanced.TabIndex = 28;
			this.btnAdvanced.Text = "Advanced";
			this.btnAdvanced.UseVisualStyleBackColor = true;
			// 
			// btnBasic
			// 
			this.btnBasic.Location = new System.Drawing.Point(407, 40);
			this.btnBasic.Name = "btnBasic";
			this.btnBasic.Size = new System.Drawing.Size(75, 23);
			this.btnBasic.TabIndex = 29;
			this.btnBasic.Text = "Basic";
			this.btnBasic.UseVisualStyleBackColor = true;
			// 
			// btnCamera
			// 
			this.btnCamera.Location = new System.Drawing.Point(407, 69);
			this.btnCamera.Name = "btnCamera";
			this.btnCamera.Size = new System.Drawing.Size(75, 23);
			this.btnCamera.TabIndex = 30;
			this.btnCamera.Text = "Camera";
			this.btnCamera.UseVisualStyleBackColor = true;
			// 
			// frmData
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(647, 563);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lstDataPair);
			this.Name = "frmData";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmData";
			this.Load += new System.EventHandler(this.frmData_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.ListBox lstDataPair;
		public System.Windows.Forms.DataGridView dataGridView1;
		public System.Windows.Forms.TextBox txtL;
		public System.Windows.Forms.TextBox txtR;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnOK;
		public System.Windows.Forms.RadioButton rdR;
		public System.Windows.Forms.RadioButton rdL;
		private System.Windows.Forms.Button btnBasic;
		private System.Windows.Forms.Button btnAdvanced;
		private System.Windows.Forms.Button btnCamera;
	}
}