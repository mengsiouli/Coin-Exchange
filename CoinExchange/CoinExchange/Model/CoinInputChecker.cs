using System.Globalization;

namespace CoinExchange.Model
{
	public partial class CoinInputChecker
	{
		// validate whether szInput is an decimal within the allowed range
		public bool IsValidDecimal( string szAmount, out decimal coinAmount )
		{
			bool isValid = decimal.TryParse( szAmount, NumberStyles.Float, CultureInfo.InvariantCulture, out coinAmount );
			return isValid && coinAmount > 0;
		}
	}
}