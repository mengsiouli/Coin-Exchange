namespace CoinExchange
{
	partial class UclCoinExchangeItem
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

		#region 元件設計工具產生的程式碼

		/// <summary> 
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.m_chkCoinItem = new System.Windows.Forms.CheckBox();
			this.m_txbCoinItem = new System.Windows.Forms.TextBox();
			this.m_lblCoinItem = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// m_chkCoinItem
			// 
			this.m_chkCoinItem.AutoSize = true;
			this.m_chkCoinItem.Location = new System.Drawing.Point( 11, 9 );
			this.m_chkCoinItem.Name = "m_chkCoinItem";
			this.m_chkCoinItem.Size = new System.Drawing.Size( 111, 34 );
			this.m_chkCoinItem.TabIndex = 0;
			this.m_chkCoinItem.Text = "$Coin";
			this.m_chkCoinItem.UseVisualStyleBackColor = true;
			// 
			// m_txbCoinItem
			// 
			this.m_txbCoinItem.Location = new System.Drawing.Point( 8, 48 );
			this.m_txbCoinItem.Name = "m_txbCoinItem";
			this.m_txbCoinItem.ReadOnly = true;
			this.m_txbCoinItem.Size = new System.Drawing.Size( 110, 39 );
			this.m_txbCoinItem.TabIndex = 1;
			// 
			// m_lblCoinItem
			// 
			this.m_lblCoinItem.AutoSize = true;
			this.m_lblCoinItem.Location = new System.Drawing.Point( 6, 10 );
			this.m_lblCoinItem.Name = "m_lblCoinItem";
			this.m_lblCoinItem.Size = new System.Drawing.Size( 79, 30 );
			this.m_lblCoinItem.TabIndex = 2;
			this.m_lblCoinItem.Text = "$Coin";
			// 
			// UclCoinExchangeItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 14F, 30F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add( this.m_lblCoinItem );
			this.Controls.Add( this.m_txbCoinItem );
			this.Controls.Add( this.m_chkCoinItem );
			this.Font = new System.Drawing.Font( "微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 136 ) ) );
			this.Margin = new System.Windows.Forms.Padding( 3, 4, 3, 4 );
			this.Name = "UclCoinExchangeItem";
			this.Size = new System.Drawing.Size( 121, 93 );
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox m_chkCoinItem;
		private System.Windows.Forms.TextBox m_txbCoinItem;
		private System.Windows.Forms.Label m_lblCoinItem;
	}
}
