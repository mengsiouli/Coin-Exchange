using CoinExchange.Presenter;
using CoinExchange.View;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CoinExchangeTest
{
	[TestClass]
	public class CoinExchangePresenterTests
	{
		[TestMethod]
		public void OnExchangeRequest_WhenInputIsInvalid_ShouldShowSpecificErrorMessage()
		{
			// create a mock View and the Presenter to be tested
			var mockView = new Mock<ICoinExchangeView>();
			var presenter = new CoinExchangePresenter( mockView.Object );

			// simulate user input of non-digital text
			mockView.Setup( v => v.SzInputAmount ).Returns( AMOUNT_INPUT_INVALID );

			// execute the presenter logic
			presenter.OnExchangeRequest();

			// ensure the view's error method is called with the expected message
			mockView.Verify( v => v.ShowExchangeErrorAndUpdateUI( EXPECTED_ERROR_MESSAGE ), Times.Once() );
		}

		const string AMOUNT_INPUT_INVALID = "B&B";
		const string EXPECTED_ERROR_MESSAGE = "Please input a positive integer.";
	}
}
