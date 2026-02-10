using CoinExchange.Presenter;
using System.Collections.Generic;

namespace CoinExchange.View
{
	public interface ICoinExchangeView : IView<ICoinExchangePresenter>
	{
		string SzInputAmount
		{
			get;
		}

		void GenerateCoinExchangeItems( List<decimal> coinTypes );
		List<decimal> GetSelectedCoinTypes();
		void DisplayExchangedResult( Dictionary<decimal, int> exchangedCounts );
		void ShowExchangeErrorAndUpdateUI( string szMessage );
	}

}