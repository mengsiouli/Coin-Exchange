namespace CoinExchange
{
	partial class FrmCoinExchange
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCoinExchange));
			this.m_btnExchange = new System.Windows.Forms.Button();
			this.m_txbCoinAmount = new System.Windows.Forms.TextBox();
			this.m_lblCoinInputHint = new System.Windows.Forms.Label();
			this.m_gbxCoinItem = new System.Windows.Forms.GroupBox();
			this.m_flpCoinItem = new System.Windows.Forms.FlowLayoutPanel();
			this.m_gbxCoinItem.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_btnExchange
			// 
			resources.ApplyResources(this.m_btnExchange, "m_btnExchange");
			this.m_btnExchange.Name = "m_btnExchange";
			this.m_btnExchange.UseVisualStyleBackColor = true;
			this.m_btnExchange.Click += new System.EventHandler(this.m_btnExchange_Click);
			// 
			// m_txbCoinAmount
			// 
			resources.ApplyResources(this.m_txbCoinAmount, "m_txbCoinAmount");
			this.m_txbCoinAmount.Name = "m_txbCoinAmount";
			this.m_txbCoinAmount.TextChanged += new System.EventHandler(this.m_txbCoinAmount_TextChanged);
			this.m_txbCoinAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_EnterToNext_KeyDown);
			// 
			// m_lblCoinInputHint
			// 
			resources.ApplyResources(this.m_lblCoinInputHint, "m_lblCoinInputHint");
			this.m_lblCoinInputHint.Name = "m_lblCoinInputHint";
			// 
			// m_gbxCoinItem
			// 
			resources.ApplyResources(this.m_gbxCoinItem, "m_gbxCoinItem");
			this.m_gbxCoinItem.Controls.Add(this.m_flpCoinItem);
			this.m_gbxCoinItem.Name = "m_gbxCoinItem";
			this.m_gbxCoinItem.TabStop = false;
			// 
			// m_flpCoinItem
			// 
			resources.ApplyResources(this.m_flpCoinItem, "m_flpCoinItem");
			this.m_flpCoinItem.Name = "m_flpCoinItem";
			// 
			// FrmCoinExchange
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.m_gbxCoinItem);
			this.Controls.Add(this.m_lblCoinInputHint);
			this.Controls.Add(this.m_txbCoinAmount);
			this.Controls.Add(this.m_btnExchange);
			this.Name = "FrmCoinExchange";
			this.Load += new System.EventHandler(this.FrmCoinExchange_Load);
			this.m_gbxCoinItem.ResumeLayout(false);
			this.m_gbxCoinItem.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button m_btnExchange;
		private System.Windows.Forms.TextBox m_txbCoinAmount;
		private System.Windows.Forms.Label m_lblCoinInputHint;
		private System.Windows.Forms.GroupBox m_gbxCoinItem;
		private System.Windows.Forms.FlowLayoutPanel m_flpCoinItem;
	}
}

