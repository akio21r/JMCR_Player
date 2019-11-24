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
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.lstDataMeibo = new System.Windows.Forms.ListBox();
			this.txtLeft = new System.Windows.Forms.TextBox();
			this.txtRight = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// lstDataPair
			// 
			this.lstDataPair.FormattingEnabled = true;
			this.lstDataPair.ItemHeight = 12;
			this.lstDataPair.Location = new System.Drawing.Point(513, 22);
			this.lstDataPair.Name = "lstDataPair";
			this.lstDataPair.Size = new System.Drawing.Size(120, 184);
			this.lstDataPair.TabIndex = 15;
			this.lstDataPair.SelectedIndexChanged += new System.EventHandler(this.lstDataPair_SelectedIndexChanged);
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(59, 268);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowTemplate.Height = 21;
			this.dataGridView2.Size = new System.Drawing.Size(138, 150);
			this.dataGridView2.TabIndex = 18;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(272, 284);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowTemplate.Height = 21;
			this.dataGridView1.ShowEditingIcon = false;
			this.dataGridView1.Size = new System.Drawing.Size(471, 150);
			this.dataGridView1.TabIndex = 17;
			// 
			// lstDataMeibo
			// 
			this.lstDataMeibo.FormattingEnabled = true;
			this.lstDataMeibo.ItemHeight = 12;
			this.lstDataMeibo.Location = new System.Drawing.Point(49, 73);
			this.lstDataMeibo.Name = "lstDataMeibo";
			this.lstDataMeibo.Size = new System.Drawing.Size(415, 124);
			this.lstDataMeibo.TabIndex = 16;
			this.lstDataMeibo.SelectedIndexChanged += new System.EventHandler(this.lstDataMeibo_SelectedIndexChanged);
			// 
			// txtLeft
			// 
			this.txtLeft.Location = new System.Drawing.Point(35, 23);
			this.txtLeft.Name = "txtLeft";
			this.txtLeft.Size = new System.Drawing.Size(100, 19);
			this.txtLeft.TabIndex = 19;
			// 
			// txtRight
			// 
			this.txtRight.Location = new System.Drawing.Point(185, 27);
			this.txtRight.Name = "txtRight";
			this.txtRight.Size = new System.Drawing.Size(100, 19);
			this.txtRight.TabIndex = 20;
			// 
			// frmData
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(926, 572);
			this.Controls.Add(this.txtRight);
			this.Controls.Add(this.txtLeft);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.lstDataMeibo);
			this.Controls.Add(this.lstDataPair);
			this.Name = "frmData";
			this.Text = "frmData";
			this.Load += new System.EventHandler(this.frmData_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.ListBox lstDataMeibo;
		public System.Windows.Forms.ListBox lstDataPair;
		public System.Windows.Forms.DataGridView dataGridView2;
		public System.Windows.Forms.DataGridView dataGridView1;
		public System.Windows.Forms.TextBox txtLeft;
		public System.Windows.Forms.TextBox txtRight;
	}
}