using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BiSS.Projects.RPGen.Structure
{
	public class LDChartDataSource//:IChartSeriesModel
	{
		public LDChartDataSource(IList<(NfSubjects, float)> list)
		{
			Zh = list.First(a => a.Item1 == NfSubjects.Zh).Item2;
			M = list.First(a => a.Item1 == NfSubjects.M).Item2;
			En = list.First(a => a.Item1 == NfSubjects.En).Item2;
			P = list.First(a => a.Item1 == NfSubjects.P).Item2;
			C = list.First(a => a.Item1 == NfSubjects.C).Item2;
			Po = list.First(a => a.Item1 == NfSubjects.Po).Item2;
			H = list.First(a => a.Item1 == NfSubjects.H).Item2;
			G = list.First(a => a.Item1 == NfSubjects.G).Item2;
			B = list.First(a => a.Item1 == NfSubjects.B).Item2;
		}
		private float? zh = null;
		private float? m = null;
		private float? en = null;
		private float? p = null;
		private float? c = null;
		private float? po = null;
		private float? h = null;
		private float? g = null;
		private float? b = null;

		public float? Zh { get => this.zh; set => this.zh = value; }
		public float? M { get => this.m; set => this.m = value; }
		public float? En { get => this.en; set => this.en = value; }
		public float? P { get => this.p; set => this.p = value; }
		public float? C { get => this.c; set => this.c = value; }
		public float? Po { get => this.po; set => this.po = value; }
		public float? H { get => this.h; set => this.h = value; }
		public float? G { get => this.g; set => this.g = value; }
		public float? B { get => this.b; set => this.b = value; }
		public double GetX(int xIndex)
		{
			throw new NotImplementedException();
		}

		public double[] GetY(int xIndex)
		{
			throw new NotImplementedException();
		}

		public bool GetEmpty(int xIndex)
		{
			throw new NotImplementedException();
		}

		public int Count { get; }
		public event ListChangedEventHandler Changed;
	}
}
