namespace JMCR
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
			this.lblL = new System.Windows.Forms.Label();
			this.lblR = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// lstDataPair
			// 
			this.lstDataPair.FormattingEnabled = true;
			this.lstDataPair.ItemHeight = 12;
			this.lstDataPair.Location = new System.Drawing.Point(489, 12);
			this.lstDataPair.Name = "lstDataPair";
			this.lstDataPair.Size = new System.Drawing.Size(120, 544);
			this.lstDataPair.TabIndex = 15;
			this.lstDataPair.SelectedIndexChanged += new System.EventHandler(this.lstDataPair_SelectedIndexChanged);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 49);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowTemplate.Height = 21;
			this.dataGridView1.ShowEditingIcon = false;
			this.dataGridView1.Size = new System.Drawing.Size(471, 507);
			this.dataGridView1.TabIndex = 17;
			// 
			// txtL
			// 
			this.txtL.Location = new System.Drawing.Point(12, 24);
			this.txtL.Name = "txtL";
			this.txtL.Size = new System.Drawing.Size(100, 19);
			this.txtL.TabIndex = 19;
			// 
			// txtR
			// 
			this.txtR.Location = new System.Drawing.Point(118, 24);
			this.txtR.Name = "txtR";
			this.txtR.Size = new System.Drawing.Size(100, 19);
			this.txtR.TabIndex = 20;
			// 
			// lblL
			// 
			this.lblL.AutoSize = true;
			this.lblL.Location = new System.Drawing.Point(12, 9);
			this.lblL.Name = "lblL";
			this.lblL.Size = new System.Drawing.Size(35, 12);
			this.lblL.TabIndex = 21;
			this.lblL.Text = "label1";
			// 
			// lblR
			// 
			this.lblR.AutoSize = true;
			this.lblR.Location = new System.Drawing.Point(116, 9);
			this.lblR.Name = "lblR";
			this.lblR.Size = new System.Drawing.Size(35, 12);
			this.lblR.TabIndex = 22;
			this.lblR.Text = "label1";
			// 
			// frmData
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(623, 572);
			this.Controls.Add(this.lblR);
			this.Controls.Add(this.lblL);
			this.Controls.Add(this.txtR);
			this.Controls.Add(this.txtL);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.lstDataPair);
			this.Name = "frmData";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmData";
			this.Load += new System.EventHandler(this.frmData_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.ListBox lstDataPair;
		public System.Windows.Forms.DataGridView dataGridView1;
		public System.Windows.Forms.TextBox txtL;
		public System.Windows.Forms.TextBox txtR;
		private System.Windows.Forms.Label lblL;
		private System.Windows.Forms.Label lblR;
	}
}