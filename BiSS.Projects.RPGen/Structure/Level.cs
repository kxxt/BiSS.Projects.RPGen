using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiSS.Projects.RPGen.Structure
{
	[Flags]
	public enum Level
	{
		A=1,B=2,C=3,D=4
	}
	public static class LevelEx{
		public static string Name(this Level l)
		{
			switch (l)
			{
				case Level.A:
					return "A";
				case Level.B:
					return "B";
				case Level.C:
					return "C";
				case Level.D:
					return "D";
				default:
					return "EX_LEVEL";
			}
		}
		public static int Id(this Level l)
		{
			switch (l)
			{
				case Level.A:
					return 1;
				case Level.B:
					return 2;
				case Level.C:
					return 3;
				case Level.D:
					return 4;
				default:
					return Int32.MinValue;
			}
		}

		private static string[] cache = null;
		private static string[] cache_ = null;

		public static string[] GetOrders_ExtraIncluded_()
		{
			if (cache_ != null)
				return cache_;
			var ret = GetOrders().ToList();
			ret.Add("≤D");
			cache_ = ret.ToArray();
			return cache_;
		}
		public static string[] GetOrders()
		{
			if (cache != null)
				return cache;
			else
			{
				List<string> list = new List<string>();
				for (Level s = Level.A; s <= Level.D; s++)
				{
					list.Add(s.Name());
				}

				cache = list.ToArray();
				return cache;
			}
		}
	}
	public  class DLevel
	{
		private Dictionary<string,float[]> value=new Dictionary<string, float[]>();

		public float[] this[string id]
		{
			get { return value[id] ?? null; }
			set { this.value[id] = value; }
		}
	}
}
