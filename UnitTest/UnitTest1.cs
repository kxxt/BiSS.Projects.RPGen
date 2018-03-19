using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
	[TestClass]
	public static class UnitTest
	{
		[TestMethod]
		public static int CountItemInRange<T1, T2>(this IEnumerable<T1> l, T2 low, T2 high, Func<T1, T2> selector) where T2 : IComparable<T2>
		{
			int cnt = 0;
			foreach (var t in l)
			{
				var x = selector(t);
				if (x.CompareTo(low) >= 0 && x.CompareTo(high) <= 0)
					cnt++;
			}

			return cnt;
		}
		[TestMethod]
		public static int CountItemInRange<T>(this IEnumerable<T> l, T low, T high) where T : IComparable<T>
		{
			int cnt = 0;
			foreach (var t in l)
			{
				if (t.CompareTo(low) >= 0 && t.CompareTo(high) <= 0)
					cnt++;
			}

			return cnt;
		}
	}
}
