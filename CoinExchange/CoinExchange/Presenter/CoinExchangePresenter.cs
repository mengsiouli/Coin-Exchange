using CoinExchange.Model;
using CoinExchange.View;
using System.Collections.Generic;

namespace CoinExchange.Presenter
{
	public class CoinExchangePresenter : ICoinExchangePresenter
	{
		// define dependencies required for input validation and exchange calculation
		readonly ICoinExchangeView _view;
		readonly CoinInputChecker _inputChecker;
		readonly ExchangeCoin _exchanger;
		readonly CoinConfigProvider _configLoader;

		// connect the presenter to the view to enable event-driven communication
		public CoinExchangePresenter( ICoinExchangeView view )
		{
			_view = view;
			_view.Presenter = this;
			_inputChecker = new CoinInputChecker();
			_exchanger = new ExchangeCoin();
			_configLoader = new CoinConfigProvider();
		}

		public ICoinExchangeView View
		{
			get
			{
				return _view;
			}
		}

		public void OnExchangeRequest()
		{
			// get user input from the view
			string szAmount = _view.SzInputAmount;

			// validate szAmount using the input checker
			// if the input is invalid, show an error message and update the UI
			bool isValidInput = _inputChecker.IsValidDecimal( szAmount, out decimal coinAmount );
			if( !isValidInput ) {
				_view.ShowExchangeErrorAndUpdateUI( "Please input a positive integer." );
				return;
			}

			// get the selected coin types from the view and perform the exchange calculation using the exchanger
			List<decimal> selectedCoins = _view.GetSelectedCoinTypes();
			int[] nCountArray = _exchanger.Exchange( coinAmount, selectedCoins );

			// if the exchange calculation fails, show an error message and update the UI
			if( nCountArray == null || nCountArray.Length == 0 ) {
				_view.ShowExchangeErrorAndUpdateUI( "Exchange failed. Please enter an integer greater." );
				return;
			}

			// connect the exchange results with the corresponding coin types and display the results on the view
			Dictionary<decimal, int> exchangedCounts = new Dictionary<decimal, int>();
			for( int i = 0; i < selectedCoins.Count; i++ ) {
				exchangedCounts.Add( selectedCoins[ i ], nCountArray[ i ] );
			}
			_view.DisplayExchangedResult( exchangedCounts );
		}

		// populate the UI with available currency denominations from external configuration
		public void GetCoinTypes()
		{
			var coinTypes = _configLoader.GetCoinTypesFromConfig( "CoinTypes", DEFULT_COIN_TYPES );
			_view.GenerateCoinExchangeItems( coinTypes );
		}

		readonly List<decimal> DEFULT_COIN_TYPES = new List<decimal> { 50, 10, 5, 1 };
	}
}
