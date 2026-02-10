using CoinExchange.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoinExchangeTest
{
	// validate function IsValidDecimal in CoinInputChecker class
	[TestClass]
	public partial class CoinInputCheckerTests
	{
		static readonly CoinInputChecker coinInputChecker = new CoinInputChecker();

		[DataRow( "0", false )]
		[DataRow( "79228162514264337593543950336", false )]
		[DataRow( "^_^", false )]
		[DataRow( "65+", false )]

		[TestMethod]
		public void IsValidDecimal_WhenInputIsNotPositiveOrExceedsDecimalMaxValuelRange_ShouldReturnFalse( string szAmount, bool isValidExpected )
		{
			bool isValidActual = coinInputChecker.IsValidDecimal( szAmount, out _ );
			Assert.AreEqual( isValidExpected, isValidActual );
		}

		[DataRow( "1", true )]
		[DataRow( "79228162514264337593543950335", true )]
		[DataRow( "2.5E+10", true )]
		[DataRow( "2026", true )]

		[TestMethod]
		public void IsValidDecimal_WhenInputIsPositiveAndBetween1AndDecimalMaxValueRange_ShouldReturnTrue( string szAmount, bool isValidExpected )
		{
			bool isValidActual = coinInputChecker.IsValidDecimal( szAmount, out _ );
			Assert.AreEqual( isValidExpected, isValidActual );
		}
	}
}