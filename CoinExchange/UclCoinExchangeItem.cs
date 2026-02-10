using System.Windows.Forms;

namespace CoinExchange
{
	public partial class UclCoinExchangeItem : UserControl
	{
		public decimal CoinValue
		{
			get; set;
		}

		public UclCoinExchangeItem( decimal coinType )
		{
			InitializeComponent();

			CoinValue = coinType;
			m_chkCoinItem.Text = $"${coinType}";
			m_lblCoinItem.Text = $"${coinType}";
		}

		// if it is min coin, hide the checkbox and show the label
		public bool IsMinCoin
		{
			get
			{
				return m_isMinCoin;
			}
			set
			{
				m_isMinCoin = value;
				m_lblCoinItem.Visible = value;
				m_chkCoinItem.Visible = !value;
			}
		}

		// if the checkbox is selected
		public bool IsSelected
		{
			get
			{
				return m_chkCoinItem.Checked;
			}
		}

		// display the coin count in the textbox
		public string SzCoinAmount
		{
			get
			{
				return m_txbCoinItem.Text;
			}
			set
			{
				m_txbCoinItem.Text = value;
			}
		}

		// clear the coin count in the textbox
		public void ClearCoinAmount()
		{
			m_txbCoinItem.Text = string.Empty;
		}

		bool m_isMinCoin;
	}
}
