using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiSS.Projects.RPGen.Structure
{
	[Flags]
	public enum Subjects
	{
		Zh =0b0,
		M  =0b1,
		En =0b10,
		P  =0b100,
		C  =0b1000,
		Po =0b10000,
		H  =0b100000,
		G  =0b1000000,
		B  =0b10000000,
		All=0b11111111
	}
	[Flags]
	public enum NfSubjects
	{
		Zh = 0,
		M = 1,
		En = 2,
		P = 3,
		C = 4,
		Po = 5,
		H = 6,
		G = 7,
		B = 8,
		All = 9
	}

	public static class SubjectsEx
	{
		public static string Name(this NfSubjects sub)
		{
			switch (sub)
			{
				case NfSubjects.Zh:
					return "语文";
				case NfSubjects.M:
					return "数学";
				case NfSubjects.En:
					return "英语";
				case NfSubjects.P:
					return "物理";
				case NfSubjects.C:
					return "化学";
				case NfSubjects.Po:
					return "政治";
				case NfSubjects.H:
					return "历史";
				case NfSubjects.G:
					return "地理";
				case NfSubjects.B:
					return "生物";
				case NfSubjects.All:
					return "总分";
				default:
					return "Undefined";
			}
		}

		private static string[] cache=null;
		public static string[] GetOrders()
		{
			if (cache != null)
				return cache;
			else
			{
				List<string> list=new List<string>();
				for (NfSubjects s=NfSubjects.Zh;s<=NfSubjects.All;s++)
				{
					list.Add(s.Name());
				}

				cache = list.ToArray();
				return cache;
			}
		}
	}
}
