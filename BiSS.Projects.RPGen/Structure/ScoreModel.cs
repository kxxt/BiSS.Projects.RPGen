using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spire.Doc;

namespace BiSS.Projects.RPGen.Structure
{
	public class ScoreModel
	{
		private float? zh = null;
		private float? m = null;
		private float? en = null;
		private float? p = null;
		private float? c = null;
		private float? po = null;
		private float? h = null;
		private float? g = null;
		private float? b = null;

		private int? zhRank = null;
		private int? mRank = null;
		private int? enRank = null;
		private int? pRank = null;
		private int? cRank = null;
		private int? poRank = null;
		private int? hRank = null;
		private int? gRank = null;
		private int? bRank = null;

		private int? zhGradeRank = null;
		private int? mGradeRank = null;
		private int? enGradeRank = null;
		private int? pGradeRank = null;
		private int? cGradeRank = null;
		private int? poGradeRank = null;
		private int? hGradeRank = null;
		private int? gGradeRank = null;
		private int? bGradeRank = null;

		private int? sumRank = null;
		private int? sumGradeRank = null;

		public float? Zh { get => this.zh; set => this.zh = value; }
		public float? M { get => this.m; set => this.m = value; }
		public float? En { get => this.en; set => this.en = value; }
		public float? P { get => this.p; set => this.p = value; }
		public float? C { get => this.c; set => this.c = value; }
		public float? Po { get => this.po; set => this.po = value; }
		public float? H { get => this.h; set => this.h = value; }
		public float? G { get => this.g; set => this.g = value; }
		public float? B { get => this.b; set => this.b = value; }
		private float? sum=null;

		public ScoreModel(float? zh, float? m, float? en, float? p, float? c, float? po, float? h, float? g, float? b, int? zhRank, int? mRank, int? enRank, int? pRank, int? cRank, int? poRank, int? hRank, int? gRank, int? bRank)
		{
			this.zh = zh;
			this.m = m;
			this.en = en;
			this.p = p;
			this.c = c;
			this.po = po;
			this.h = h;
			this.g = g;
			this.b = b;
			this.zhRank = zhRank;
			this.mRank = mRank;
			this.enRank = enRank;
			this.pRank = pRank;
			this.cRank = cRank;
			this.poRank = poRank;
			this.hRank = hRank;
			this.gRank = gRank;
			this.bRank = bRank;
		}

		public float? Sum {
			get
			{
				if (sum != null) return this.sum;
				else {
					sum =(zh + m + en + p + c + po + h + g + b);
					return sum;
				}
			}
		}

		public int? ZhRank { get => this.zhRank; set => this.zhRank = value; }
		public int? MRank { get => this.mRank; set => this.mRank = value; }
		public int? EnRank { get => this.enRank; set => this.enRank = value; }
		public int? PRank { get => this.pRank; set => this.pRank = value; }
		public int? CRank { get => this.cRank; set => this.cRank = value; }
		public int? PoRank { get => this.poRank; set => this.poRank = value; }
		public int? HRank { get => this.hRank; set => this.hRank = value; }
		public int? GRank { get => this.gRank; set => this.gRank = value; }
		public int? BRank { get => this.bRank; set => this.bRank = value; }
		public int? ZhGradeRank { get => this.zhGradeRank; set => this.zhGradeRank = value; }
		public int? MGradeRank { get => this.mGradeRank; set => this.mGradeRank = value; }
		public int? EnGradeRank { get => this.enGradeRank; set => this.enGradeRank = value; }
		public int? PGradeRank { get => this.pGradeRank; set => this.pGradeRank = value; }
		public int? CGradeRank { get => this.cGradeRank; set => this.cGradeRank = value; }
		public int? PoGradeRank { get => this.poGradeRank; set => this.poGradeRank = value; }
		public int? HGradeRank { get => this.hGradeRank; set => this.hGradeRank = value; }
		public int? GGradeRank { get => this.gGradeRank; set => this.gGradeRank = value; }
		public int? BGradeRank { get => this.bGradeRank; set => this.bGradeRank = value; }
	}
}
