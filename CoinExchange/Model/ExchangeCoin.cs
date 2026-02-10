using System.Collections.Generic;

namespace CoinExchange.Model
{
	public partial class ExchangeCoin
	{
		// calculate the count of each coin type
		public int[] Exchange( decimal coinAmount, List<decimal> coinValList )
		{
			int[] nCountArray = new int[ coinValList.Count ];
			for( int i = 0; i < coinValList.Count && coinAmount > 0; i++ ) {
				decimal currentCoin = coinValList[ i ];
				nCountArray[ i ] = (int)( coinAmount / currentCoin );
				coinAmount %= currentCoin;

				// if it is the last coin type and there is still amountleft,return empty array
				if( i == coinValList.Count - 1 && coinAmount > 0 ) {
					return new int[ 0 ];
				}
			}
			return nCountArray;
		}
	}
}
