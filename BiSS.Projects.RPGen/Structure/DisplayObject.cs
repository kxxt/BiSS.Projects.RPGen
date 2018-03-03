using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BiSS.Projects.RPGen.Structure
{
	public class DisplayObject:ScoreModel
	{
		private int id;
		private string name;
		public DisplayObject(int id,string name,int? sumRank,int? sumGradeRank,
							float? zh, float? m, float? en, float? p, float? c, float? po, float? h, float? g, float? b,
							int? zhRank, int? mRank, int? enRank, int? pRank, int? cRank, int? poRank, int? hRank, int? gRank, int? bRank,
							int? zhGradeRank, int? mGradeRank, int? enGradeRank, int? pGradeRank, int? cGradeRank, int? poGradeRank, int? hGradeRank, int? gGradeRank, int? bGradeRank
							) : 
			base(sumRank,sumGradeRank,
				zh, m, en, p, c, po, h, g, b, 
				zhRank, mRank, enRank, pRank, cRank, poRank, hRank, gRank, bRank,
				zhGradeRank,mGradeRank,  enGradeRank,  pGradeRank,  cGradeRank, poGradeRank, hGradeRank, gGradeRank, bGradeRank)
		{
			this.id = id;
			this.name = name;
		}

		public DisplayObject(int id, string name, ScoreModel sm):base(sm.ZhGradeRank,sm.MGradeRank,sm.EnGradeRank,sm.PGradeRank,sm.CGradeRank,sm.PoGradeRank,sm.HGradeRank,sm.GGradeRank,sm.BGradeRank)
		{
			this.id = id;
			this.name = name;
			this.zh =sm. Zh;
			this.m = sm.M;
			this.en = sm.En;
			this.p = sm.P;
			this.c = sm.C;
			this.po = sm.Po;
			this.h = sm.H;
			this.g = sm.G;
			this.b = sm.B;
			this.zhRank = sm.ZhRank;
			this.mRank = sm.MRank;
			this.enRank = sm.EnRank;
			this.pRank = sm.PRank;
			this.cRank = sm.CRank;
			this.poRank = sm.PoRank;
			this.hRank = sm.HRank;
			this.gRank = sm.GRank;
			this.bRank = sm.BRank;
			this.sumRank = sm.SumRank;
			this.sumGradeRank = sm.SumGradeRank;
		}
		public int Id { get => this.id; set => this.id = value; }
		public string Name { get => this.name; set => this.name = value; }
	}
}
