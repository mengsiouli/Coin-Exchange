using CoinExchange.View;
namespace CoinExchange.Presenter
{
	public interface ICoinExchangePresenter : IPresenter<ICoinExchangeView>
	{
		void GetCoinTypes();
		void OnExchangeRequest();
	}
}
