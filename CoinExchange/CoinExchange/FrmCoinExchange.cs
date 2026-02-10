using CoinExchange.Presenter;
using CoinExchange.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CoinExchange
{
	public partial class FrmCoinExchange : Form, ICoinExchangeView
	{
		public ICoinExchangePresenter Presenter
		{
			get; set;
		}

		public FrmCoinExchange()
		{
			InitializeComponent();
		}

		#region ICoinExchangeView 

		public string SzInputAmount
		{
			get
			{
				return m_txbCoinAmount.Text;
			}
		}

		public void GenerateCoinExchangeItems( List<decimal> coinTypes )
		{
			m_flpCoinItem.Controls.Clear();
			m_coinItems.Clear();

			foreach( decimal coinType in coinTypes ) {
				UclCoinExchangeItem exchangeItem = new UclCoinExchangeItem( coinType )
				{
					IsMinCoin = coinType == coinTypes.Min(),
					Name = $"exchangeItem{coinType}"
				};
				m_flpCoinItem.Controls.Add( exchangeItem );
				m_coinItems.Add( exchangeItem );
			}
		}

		public List<decimal> GetSelectedCoinTypes()
		{
			return m_coinItems
				.Where( item => item.IsSelected || item.IsMinCoin )
				.Select( item => item.CoinValue )
				.ToList();
		}

		public void DisplayExchangedResult( Dictionary<decimal, int> exchangedCounts )
		{
			foreach( var item in m_coinItems ) {
				if( exchangedCounts.ContainsKey( item.CoinValue ) ) {
					item.SzCoinAmount = exchangedCounts[ item.CoinValue ].ToString();
				}
				else {
					item.SzCoinAmount = string.Empty;
				}
			}
		}

		public void ShowExchangeErrorAndUpdateUI( string szMessage )
		{
			MessageBox.Show( szMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
			m_txbCoinAmount.Text = string.Empty;
		}

		// clear all coin amount textboxes
		void ClearDisplay()
		{
			foreach( UclCoinExchangeItem item in m_coinItems ) {
				item.ClearCoinAmount();
			}
		}
		#endregion

		#region UI 事件轉發
		void m_txbCoinAmount_TextChanged( object sender, EventArgs e )
		{
			ClearDisplay();
		}

		void m_btnExchange_Click( object sender, EventArgs e )
		{
			Presenter.OnExchangeRequest();
		}

		void FrmCoinExchange_Load( object sender, EventArgs e )
		{
			Presenter.GetCoinTypes();
		}
		#endregion

		//  press enter to move focus to the next input field
		void TextBox_EnterToNext_KeyDown( object sender, KeyEventArgs e )
		{
			if( e.KeyCode != Keys.Enter ) {
				return;
			}
			e.Handled = true;
			e.SuppressKeyPress = true;
			this.SelectNextControl( sender as Control, true, true, true, true );
		}

		// structure to hold coin item information
		List<UclCoinExchangeItem> m_coinItems = new List<UclCoinExchangeItem>();
	}
}
