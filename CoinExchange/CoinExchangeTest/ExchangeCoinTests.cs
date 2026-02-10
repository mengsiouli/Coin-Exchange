using CoinExchange.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CoinExchangeTest
{
	[TestClass]
	public class ExchangeCoinTests
	{
		readonly static ExchangeCoin exchanger = new ExchangeCoin();

		static IEnumerable<object[]> GetTestCases_WhenCannotBeFullyExchanged()
		{
			yield return new object[] { 222.8m, new List<decimal> { 50, 10, 5, 1 }, Array.Empty<int>() };
			yield return new object[] { 88.88m, new List<decimal> { 10, 5, 1 }, Array.Empty<int>() };
		}

		[TestMethod]
		[DynamicData( nameof( GetTestCases_WhenCannotBeFullyExchanged ), DynamicDataSourceType.Method )]
		public void Exchange_WhenAmountCannotBeFullyExchanged_ShouldReturnEmptyArray( decimal amount, List<decimal> coinTypes, int[] nExchangedArrayExpected )
		{
			int[] nExchangedCountArray = exchanger.Exchange( amount, coinTypes );
			CollectionAssert.AreEqual( nExchangedArrayExpected, nExchangedCountArray );
		}

		static IEnumerable<object[]> GetTestCases_WhenCanBeFullyExchanged()
		{
			yield return new object[] { 527m, new List<decimal> { 50, 10, 5, 1 }, new int[] { 10, 2, 1, 2 } };
			yield return new object[] { 48m, new List<decimal> { 10, 5, 1 }, new int[] { 4, 1, 3 } };
		}

		[TestMethod]
		[DynamicData( nameof( GetTestCases_WhenCanBeFullyExchanged ), DynamicDataSourceType.Method )]
		public void Exchange_WhenAmountCanBeFullyExchanged_ShouldReturnCorrectCountArray( decimal amount, List<decimal> coinTypes, int[] nExchangedArrayExpected )
		{
			int[] nExchangedCountArray = exchanger.Exchange( amount, coinTypes );
			CollectionAssert.AreEqual( nExchangedArrayExpected, nExchangedCountArray );
		}
	}
}