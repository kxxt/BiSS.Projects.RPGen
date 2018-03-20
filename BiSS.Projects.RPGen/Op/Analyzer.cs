using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiSS.Projects.RPGen.Structure;
using RsWork.Functions.Log;
using Syncfusion.CompoundFile.XlsIO.Net;
using Syncfusion.Data.Extensions;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.XlsIO.Implementation.PivotAnalysis;

namespace BiSS.Projects.RPGen.Op
{
	public static  class Analyzer
	{

		[Passed]
		public static int CountItemInRange<T1,T2>(this IEnumerable<T1> l, T2 low, T2 high,Func<T1,T2> selector) where T2 : IComparable<T2>
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
		[Passed]
		public static int CountItemInRange<T>(this IEnumerable<T> l, T low, T high) where T :IComparable<T> 
		{
			int cnt = 0;
			foreach (var t in l)
			{
				if (t.CompareTo(low) >= 0 && t.CompareTo(high) <= 0)
					cnt++;
			}

			return cnt;
		}

		//public static Directory<NfSubjects, Directory<Level, (float, float)>> GetSepratedRange(Dictionary<NfSubjects,float> fullScore, Dictionary<NfSubjects, Dictionary<Level, float>> spr)
		//{
			
		//}

		public static Dictionary<NfSubjects,Dictionary<Level,float>> GetSeparator(Dictionary<NfSubjects,float> fs, Dictionary<Level, float> spr)
		{
			if (spr[Level.A] > spr[Level.B] &&
			    spr[Level.B] > spr[Level.C] &&
			    spr[Level.C] > spr[Level.D])
			{
				foreach (float s in spr.Values)
				{
					if(!(0<=s&&s<1))
						throw new ArgumentOutOfRangeException(nameof(spr),"Each member of {spr} should be in Range [0,1)!");
						
				}
				var ret = new Dictionary<NfSubjects, Dictionary<Level, float>>();
				for (NfSubjects sub = NfSubjects.Zh; sub <= NfSubjects.All; sub++)
				{
					for (Level lv = Level.A; lv <= Level.D; lv++)
					{
						if(!ret.ContainsKey(sub))
							ret[sub]=new Dictionary<Level, float>();
						ret[sub][lv] = get_seprated(fs[sub], spr[lv]);
					}
				}

				return ret;
			}
			else
			{
				throw new ArgumentException("Seprators should be input ordered!A=>D,Highest=>Lowest");
			}
			
		}

		private static float get_seprated(float full,float spr)
		{
			return full * spr;
		}
		public static (object[],object[]) ReArrangeData(IList<(NfSubjects,float)> li)
		{
			IList<(NfSubjects, float)> lic=new List<(NfSubjects, float)>();
			li.ForEach(ii=>lic.Add(ii));
			IList<object> xv = new List<object>();
			IList<object> yv = new List<object>();
			for (int i = 0; i < lic.Count; i++)
			{
				if (lic[i].Item1 != NfSubjects.All)
				{
					lic[i] =( lic[i].Item1,lic[i].Item2* (Program.ScoreUnionIndicator / Program.FullScore[lic[i].Item1]));
					xv.Add(lic[i].Item1.Name());
					yv.Add(lic[i].Item2);
				}
			}
			return (xv.ToArray(), yv.ToArray());
		}
		public static (object[], object[]) ReArrangeData(IList<(NfSubjects, double)> li)
		{
			IList<(NfSubjects, double)> lic = new List<(NfSubjects, double)>();
			li.ForEach(ii => lic.Add(ii));
			IList<object> xv = new List<object>();
			IList<object> yv = new List<object>();
			for (int i = 0; i < lic.Count; i++)
			{
				if (lic[i].Item1 != NfSubjects.All)
				{
					lic[i] = (lic[i].Item1, lic[i].Item2 * (Program.ScoreUnionIndicator / Program.FullScore[lic[i].Item1]));
					xv.Add(lic[i].Item1.Name());
					yv.Add(lic[i].Item2);
				}
			}
			return (xv.ToArray(), yv.ToArray());
		}
		public static IList<(NfSubjects,float)> Average(IList<ScoreModel> li)
		{
			var ret=new List<(NfSubjects, float)>();
			ret.Add((NfSubjects.Zh,li.Average(sm=>sm.Zh??0)));
			ret.Add((NfSubjects.M, li.Average(sm => sm.M ?? 0)));
			ret.Add((NfSubjects.En, li.Average(sm => sm.En ?? 0)));
			ret.Add((NfSubjects.P, li.Average(sm => sm.P ?? 0)));
			ret.Add((NfSubjects.C, li.Average(sm => sm.C ?? 0)));
			ret.Add((NfSubjects.Po, li.Average(sm => sm.Po ?? 0)));
			ret.Add((NfSubjects.H, li.Average(sm => sm.H ?? 0)));
			ret.Add((NfSubjects.G, li.Average(sm => sm.G ?? 0)));
			ret.Add((NfSubjects.B, li.Average(sm => sm.B ?? 0)));
			ret.Add((NfSubjects.All,li.Average(sm=>sm.Sum??0)));
			return ret;
		}
		public static IList<(NfSubjects, float)> Sum(IList<ScoreModel> li)
		{
			var ret = new List<(NfSubjects, float)>();
			ret.Add((NfSubjects.Zh, li.Sum(sm => sm.Zh ?? 0)));
			ret.Add((NfSubjects.M, li.Sum(sm => sm.M ?? 0)));
			ret.Add((NfSubjects.En, li.Sum(sm => sm.En ?? 0)));
			ret.Add((NfSubjects.P, li.Sum(sm => sm.P ?? 0)));
			ret.Add((NfSubjects.C, li.Sum(sm => sm.C ?? 0)));
			ret.Add((NfSubjects.Po, li.Sum(sm => sm.Po ?? 0)));
			ret.Add((NfSubjects.H, li.Sum(sm => sm.H ?? 0)));
			ret.Add((NfSubjects.G, li.Sum(sm => sm.G ?? 0)));
			ret.Add((NfSubjects.B, li.Sum(sm => sm.B ?? 0)));
			ret.Add((NfSubjects.All, li.Sum(sm => sm.Sum ?? 0)));
			return ret;
		}
		public static IList<(NfSubjects, double)> Mid(IList<ScoreModel> li)
		{
			var ret = new List<(NfSubjects, double)>();
			ret.Add((NfSubjects.Zh, li.Median(sm => sm.Zh ?? 0)));
			ret.Add((NfSubjects.M, li.Median(sm => sm.M ?? 0)));
			ret.Add((NfSubjects.En, li.Median(sm => sm.En ?? 0)));
			ret.Add((NfSubjects.P, li.Median(sm => sm.P ?? 0)));
			ret.Add((NfSubjects.C, li.Median(sm => sm.C ?? 0)));
			ret.Add((NfSubjects.Po, li.Median(sm => sm.Po ?? 0)));
			ret.Add((NfSubjects.H, li.Median(sm => sm.H ?? 0)));
			ret.Add((NfSubjects.G, li.Median(sm => sm.G ?? 0)));
			ret.Add((NfSubjects.B, li.Median(sm => sm.B ?? 0)));
			ret.Add((NfSubjects.All, li.Median(sm => sm.Sum ?? 0)));
			return ret;
		}
		public static IList<(NfSubjects, float[])> Mode(IList<ScoreModel> li)
		{
			var ret = new List<(NfSubjects, float[])>();
			ret.Add((NfSubjects.Zh, ModeOf(li.Select(sm=>sm.Zh??0).ToArray())));
			ret.Add((NfSubjects.M, ModeOf(li.Select(sm => sm.Zh ?? 0).ToArray())));
			ret.Add((NfSubjects.En, ModeOf(li.Select(sm => sm.Zh ?? 0).ToArray())));
			ret.Add((NfSubjects.P, ModeOf(li.Select(sm => sm.Zh ?? 0).ToArray())));
			ret.Add((NfSubjects.C, ModeOf(li.Select(sm => sm.Zh ?? 0).ToArray())));
			ret.Add((NfSubjects.Po, ModeOf(li.Select(sm => sm.Zh ?? 0).ToArray())));
			ret.Add((NfSubjects.H, ModeOf(li.Select(sm => sm.Zh ?? 0).ToArray())));
			ret.Add((NfSubjects.G, ModeOf(li.Select(sm => sm.Zh ?? 0).ToArray())));
			ret.Add((NfSubjects.B, ModeOf(li.Select(sm => sm.Zh ?? 0).ToArray())));
			ret.Add((NfSubjects.All, ModeOf(li.Select(sm => sm.Zh ?? 0).ToArray())));
			return ret;
		}
		// <summary>
		/// Partitions the given list around a pivot element such that all elements on left of pivot are <= pivot
		/// and the ones at thr right are > pivot. This method can be used for sorting, N-order statistics such as
		/// as median finding algorithms.
		/// Pivot is selected ranodmly if random number generator is supplied else its selected as last element in the list.
		/// Reference: Introduction to Algorithms 3rd Edition, Corman et al, pp 171
		/// </summary>
		private static int Partition<T>(this IList<T> list, int start, int end, Random rnd = null) where T : IComparable<T>
		{
			if (rnd != null)
				list.Swap(end, rnd.Next(start, end + 1));

			var pivot = list[end];
			var lastLow = start - 1;
			for (var i = start; i < end; i++)
			{
				if (list[i].CompareTo(pivot) <= 0)
					list.Swap(i, ++lastLow);
			}
			list.Swap(end, ++lastLow);
			return lastLow;
		}

		/// <summary>
		/// Returns Nth smallest element from the list. Here n starts from 0 so that n=0 returns minimum, n=1 returns 2nd smallest element etc.
		/// Note: specified list would be mutated in the process.
		/// Reference: Introduction to Algorithms 3rd Edition, Corman et al, pp 216
		/// </summary>
		public static T NthOrderStatistic<T>(this IList<T> list, int n, Random rnd = null) where T : IComparable<T>
		{
			return NthOrderStatistic(list, n, 0, list.Count - 1, rnd);
		}
		private static T NthOrderStatistic<T>(this IList<T> list, int n, int start, int end, Random rnd) where T : IComparable<T>
		{
			while (true)
			{
				var pivotIndex = list.Partition(start, end, rnd);
				if (pivotIndex == n)
					return list[pivotIndex];

				if (n < pivotIndex)
					end = pivotIndex - 1;
				else
					start = pivotIndex + 1;
			}
		}

		public static void Swap<T>(this IList<T> list, int i, int j)
		{
			if (i == j)   //This check is not required but Partition function may make many calls so its for perf reason
				return;
			var temp = list[i];
			list[i] = list[j];
			list[j] = temp;
		}

		/// <summary>
		/// Note: specified list would be mutated in the process.
		/// </summary>
		public static T Median<T>(this IList<T> list) where T : IComparable<T>
		{
			return list.NthOrderStatistic((list.Count - 1) / 2);
		}

		public static double Median<T>(this IEnumerable<T> sequence, Func<T, double> getValue)
		{
			var list = sequence.Select(getValue).ToList();
			var mid = (list.Count - 1) / 2;
			return list.NthOrderStatistic(mid);
		}
		public static float Median(this IEnumerable<int> source)
		{
			// Create a copy of the input, and sort the copy
			int[] temp = source.ToArray();
			Array.Sort(temp);

			int count = temp.Length;
			if (count == 0)
			{
				throw new InvalidOperationException("Empty collection");
			}
			else if (count % 2 == 0)
			{
				// count is even, average two middle elements
				int a = temp[count / 2 - 1];
				int b = temp[count / 2];
				return (a + b) / 2f;
			}
			else
			{
				// count is odd, return the middle element
				return temp[count / 2];
			}
		}
		/// <summary>
		/// 结构：用于统计每个数出现的次数
		/// </summary>
		struct Stats
		{
			//数字，出现的次数
			public float Number;
			public int Count;
			//构造函数
			public Stats(float n, int c)
			{
				Number = n;
				Count = c;
			}
		}

		/// <summary>
		/// 计算数组的众数
		/// </summary>
		/// <param name="array">数组</param>
		/// <param name="threshold">数量阈值，众数数量若多于次数则认为没有众数</param>
		/// <returns></returns>
		private static float[] ModeOf(float[] array, int threshold = 5)
		{
			//数组排序-统计各元素数量-按各元素数量排序-再统计最多的元素

			//1.输入合法性检验
			if (array == null || array.Length == 0 || threshold < 1)
			{
				return new float[] { };
			}

			//2.制作数组副本，后面的操作将不修改数组本身
			float[] tempArray = new float[array.Length];
			array.CopyTo(tempArray, 0);

			//3.数组排序
			float temp;
			for (int i = 0; i < tempArray.Length; i++)
			{
				for (int j = i; j < tempArray.Length; j++)
				{
					if (tempArray[i] < tempArray[j])
					{
						temp = tempArray[i];
						tempArray[i] = tempArray[j];
						tempArray[j] = temp;
					}
				}
			}

			//4.统计不同的元素数
			int counter = 1;
			for (int i = 1; i < tempArray.Length; i++)
			{
				if (tempArray[i] != tempArray[i - 1])
				{
					counter++;
				}
			}

			//5.统计各个元素数量
			int flag = 0;
			Stats[] statsArray = new Stats[counter];
			statsArray[flag].Number = tempArray[0];
			statsArray[flag].Count = 1;
			for (int i = 1; i < tempArray.Length; i++)
			{
				if (tempArray[i] == statsArray[flag].Number)
				{
					statsArray[flag].Count++;
				}
				else
				{
					flag++;
					statsArray[flag].Number = tempArray[i];
					statsArray[flag].Count = 1;
				}
			}

			//6.按元素在原数组内数量（Count属性）降序排列
			//  数量相等的元素则按大小升序排列
			for (int i = 0; i < statsArray.Length; i++)
			{
				for (int j = i; j < statsArray.Length; j++)
				{
					if (statsArray[i].Count < statsArray[j].Count ||
					    (statsArray[i].Count == statsArray[j].Count &&
					     statsArray[i].Number > statsArray[j].Number))
					{

						temp = statsArray[i].Number;
						statsArray[i].Number = statsArray[j].Number;
						statsArray[j].Number = temp;

						temp = statsArray[i].Count;
						statsArray[i].Count = statsArray[j].Count;
						statsArray[j].Count = (int)temp;
					}
				}
			}

			//7.统计众数数量
			int count = 1;
			if (statsArray.Length > threshold &&
			    statsArray[threshold].Count == statsArray[0].Count)
			{
				//众数多余阈值数量，则认为没有众数
				return new float[] { };
			}
			else
			{
				for (int i = 1; i < statsArray.Length && i < threshold; i++)
				{
					if (statsArray[i].Count == statsArray[i - 1].Count)
					{
						count++;
					}
					else break;
				}
			}

			//8.生成返回众数数组
			float[] result = new float[count];
			for (int i = 0; i < count; i++)
			{
				result[i] = statsArray[i].Number;
			}

			return result;
		}
		/// <summary>
		/// 获得高程的众数
		/// </summary>
		/// <param name="elevationList">传入list<int>数据</param>
		/// <returns></returns>
		private static int? GetElevationMode(List<int> elevationList)
		{
			try
			{
				int count;
				bool flag = false;
				Dictionary<int, int> dictionary = new Dictionary<int, int>();
				for (int i = 0; i < elevationList.Count; i++)
				{
					if (dictionary.TryGetValue(elevationList[i], out count))
					{
						flag = true;
						dictionary[elevationList[i]]++;
					}
					else
						dictionary.Add(elevationList[i], 1);
				}
				//如果没有众数，返回空
				if (!flag)
					return null;
				int max = 0;
				int position = 0;
				int[] modeArray = new int[elevationList.Count];//众数数组
				//遍历hash表
				foreach (KeyValuePair<int, int> myKey in dictionary)
				{
					if (myKey.Value > max)
					{
						max = myKey.Value;
						position = 0;
						modeArray[0] = myKey.Key;
					}
					else if (myKey.Value == max)
						modeArray[++position] = myKey.Key;
				}
				Array.Resize(ref modeArray, position + 1);
				int mode = 0;
				//如果众数不唯一，求平均数
				if (modeArray.Length > 1)
				{
					for (int i = 0; i < modeArray.Length; i++)
					{
						mode += modeArray[i];
					}
					float elevationMode = mode / modeArray.Length;
				}
				//如果众数唯一，返回众数
				else
				{
					mode = modeArray[0];
				}
				return mode;
			}
			catch (Exception ex)
			{
				Program.Log(Logger.GetExceptionInfo(ex));
				return 0;
			}
		}
	}
}
