using CoinExchange.View;
using System.Collections.Generic;
namespace CoinExchange.Presenter
{
	public interface ICoinExchangePresenter : IPresenter<ICoinExchangeView>
	{
		void GetCoinTypes();
		void OnExchangeRequest();
	}
}
