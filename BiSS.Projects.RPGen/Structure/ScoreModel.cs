using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spire.Doc;

namespace BiSS.Projects.RPGen.Structure
{
	public class ScoreModel
	{
		private int id;
		protected float? zh = null;
		protected float? m = null;
		protected float? en = null;
		protected float? p = null;
		protected float? c = null;
		protected float? po = null;
		protected float? h = null;
		protected float? g = null;
		protected float? b = null;

		protected int? zhRank = null;
		protected int? mRank = null;
		protected int? enRank = null;
		protected int? pRank = null;
		protected int? cRank = null;
		protected int? poRank = null;
		protected int? hRank = null;
		protected int? gRank = null;
		protected int? bRank = null;

		protected int? zhGradeRank = null;
		protected int? mGradeRank = null;
		protected int? enGradeRank = null;
		protected int? pGradeRank = null;
		protected int? cGradeRank = null;
		protected int? poGradeRank = null;
		protected int? hGradeRank = null;
		protected int? gGradeRank = null;
		protected int? bGradeRank = null;

		protected int? sumRank = null;
		protected int? sumGradeRank = null;
		[DisplayName("语文")]
		public float? Zh { get => this.zh; set => this.zh = value; }
		[DisplayName("数学")]
		public float? M { get => this.m; set => this.m = value; }
		[DisplayName("英语")]
		public float? En { get => this.en; set => this.en = value; }
		[DisplayName("物理")]
		public float? P { get => this.p; set => this.p = value; }
		[DisplayName("化学")]
		public float? C { get => this.c; set => this.c = value; }
		[DisplayName("政治")]
		public float? Po { get => this.po; set => this.po = value; }
		[DisplayName("历史")]
		public float? H { get => this.h; set => this.h = value; }
		[DisplayName("地理")]
		public float? G { get => this.g; set => this.g = value; }
		[DisplayName("生物")]
		public float? B { get => this.b; set => this.b = value; }
		
		protected float? sum=null;
		public ScoreModel()
		{ }
		public ScoreModel(int? sumRank,int? sumGradeRank,
			float? zh, float? m, float? en, float? p, float? c, float? po, float? h, float? g, float? b, 
			int? zhRank, int? mRank, int? enRank, int? pRank, int? cRank, int? poRank, int? hRank, int? gRank, int? bRank,
			int? zhGradeRank, int? mGradeRank, int? enGradeRank, int? pGradeRank, int? cGradeRank, int? poGradeRank, int? hGradeRank, int? gGradeRank, int? bGradeRank)
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
			this.sumRank = sumRank;

			this.sumGradeRank = sumGradeRank;
			this.zhGradeRank = zhGradeRank;
			this.mGradeRank = mGradeRank;
			this.enGradeRank = enGradeRank;
			this.pGradeRank = pGradeRank;
			this.cGradeRank = cGradeRank;
			this.poGradeRank = poGradeRank;
			this.hGradeRank = hGradeRank;
			this.gGradeRank = gGradeRank;
			this.bGradeRank = bGradeRank;
		}
		[DisplayName("总分")]
		public float? Sum {
			get
			{
				if (sum != null) return this.sum;
				else {
					sum =(zh + m + en + p + c + po + h + g + b);
					return sum;
				}
			}
			set { sum = value; }
		}

		protected ScoreModel(int? zhGradeRank, int? mGradeRank, int? enGradeRank, int? pGradeRank, int? cGradeRank, int? poGradeRank, int? hGradeRank, int? gGradeRank, int? bGradeRank)
		{
			this.zhGradeRank = zhGradeRank;
			this.mGradeRank = mGradeRank;
			this.enGradeRank = enGradeRank;
			this.pGradeRank = pGradeRank;
			this.cGradeRank = cGradeRank;
			this.poGradeRank = poGradeRank;
			this.hGradeRank = hGradeRank;
			this.gGradeRank = gGradeRank;
			this.bGradeRank = bGradeRank;
		}
		[DisplayName("语文班名次")]
		public int? ZhRank { get => this.zhRank; set => this.zhRank = value; }
		[DisplayName("数学班名次")]
		public int? MRank { get => this.mRank; set => this.mRank = value; }
		[DisplayName("英语班名次")]
		public int? EnRank { get => this.enRank; set => this.enRank = value; }
		[DisplayName("物理班名次")]
		public int? PRank { get => this.pRank; set => this.pRank = value; }
		[DisplayName("化学班名次")]
		public int? CRank { get => this.cRank; set => this.cRank = value; }
		[DisplayName("政治班名次")]
		public int? PoRank { get => this.poRank; set => this.poRank = value; }
		[DisplayName("历史班名次")]
		public int? HRank { get => this.hRank; set => this.hRank = value; }
		[DisplayName("地理班名次")]
		public int? GRank { get => this.gRank; set => this.gRank = value; }
		[DisplayName("生物班名次")]
		public int? BRank { get => this.bRank; set => this.bRank = value; }
		[DisplayName("语文级名次")]
		public int? ZhGradeRank { get => this.zhGradeRank; set => this.zhGradeRank = value; }
		[DisplayName("数学级名次")]
		public int? MGradeRank { get => this.mGradeRank; set => this.mGradeRank = value; }
		[DisplayName("英语级名次")]
		public int? EnGradeRank { get => this.enGradeRank; set => this.enGradeRank = value; }
		[DisplayName("物理级名次")]
		public int? PGradeRank { get => this.pGradeRank; set => this.pGradeRank = value; }
		[DisplayName("化学级名次")]
		public int? CGradeRank { get => this.cGradeRank; set => this.cGradeRank = value; }
		[DisplayName("政治级名次")]
		public int? PoGradeRank { get => this.poGradeRank; set => this.poGradeRank = value; }
		[DisplayName("历史级名次")]
		public int? HGradeRank { get => this.hGradeRank; set => this.hGradeRank = value; }
		[DisplayName("地理级名次")]
		public int? GGradeRank { get => this.gGradeRank; set => this.gGradeRank = value; }
		[DisplayName("生物级名次")]
		public int? BGradeRank { get => this.bGradeRank; set => this.bGradeRank = value; }
		[DisplayName("总班名次")]
		public int? SumRank { get => this.sumRank; set => this.sumRank = value; }
		[DisplayName("总级名称")]
		public int? SumGradeRank { get => this.sumGradeRank; set => this.sumGradeRank = value; }
		[DisplayName("学生ID/考号")]
		public int Id { get => this.id; set => this.id = value; }
		public override string ToString()
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}
	}
}
