namespace CoinExchange.Presenter
{
	public interface IPresenter<TView>
	{
		TView View
		{
			get;
		}
	}
}
