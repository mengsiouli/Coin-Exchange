using CoinExchange.Presenter;
using System;
using System.Windows.Forms;

namespace CoinExchange
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault( false );

			// initialize MVP components
			FrmCoinExchange view = new FrmCoinExchange();
			CoinExchangePresenter presenter = new CoinExchangePresenter( view );

			Application.Run( view );
		}
	}
}
