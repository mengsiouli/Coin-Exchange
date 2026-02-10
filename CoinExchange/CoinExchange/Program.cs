using CoinExchange.Presenter;
using System;
using System.Windows.Forms;

namespace CoinExchange
{
	internal static class Program
	{
		/// <summary>
		/// 應用程式的主要進入點。
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault( false );
			// 1. 先建立 View
			FrmCoinExchange view = new FrmCoinExchange();

			// 2. 建立 Presenter 並傳入 View
			// 在 Presenter 的建構子中，必須包含：view.Presenter = this;
			CoinExchangePresenter presenter = new CoinExchangePresenter( view );

			// 3. 啟動視窗 (此時 view.Presenter 已經不是 null 了)
			Application.Run( view );
		}
	}
}
