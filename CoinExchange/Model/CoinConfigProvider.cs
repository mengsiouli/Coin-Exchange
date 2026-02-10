using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace CoinExchange.Model
{
	public class CoinConfigProvider
	{
		// take the coin types from the config file and generate the coin exchange items on the view,
		// if there is an error loading the config, use the default coin types to generate the items
		public List<decimal> GetCoinTypesFromConfig( string key, List<decimal> defaultValue )
		{
			string szCoinTypes = ConfigurationManager.AppSettings[ key ];

			// parse szcointype into a list of decimals
			try {
				return szCoinTypes.Split( ',' )
			.Select( s => decimal.Parse( s.Trim() ) )
			.OrderByDescending( x => x )
			.ToList();
			}
			catch( Exception ) {
				MessageBox.Show( "Read failed. The system loads the default coin types (50, 10, 5, 1).", "Warm" );
				return defaultValue;
			}
		}
	}
}
