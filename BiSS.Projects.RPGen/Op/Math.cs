using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiSS.Projects.RPGen.Op
{
	public static class BiSSMath
	{
		public static float? QueryMode(this IEnumerable<float> values)
		{
			return 
				values
					.GroupBy(x => x)
					.OrderByDescending(x => x.Count()).ThenBy(x => x.Key)
					.Select(x => (float?)x.Key)
					.FirstOrDefault();

		}
	}
}
