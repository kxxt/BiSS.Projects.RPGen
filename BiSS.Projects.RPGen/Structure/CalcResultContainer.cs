namespace BiSS.Projects.RPGen.Structure
{
	public class CalcResultContainer
	{
		#region Subjects' Analytical Data
		private float? zhAverage = null;
		private float? mAverage = null;
		private float? enAverage = null;
		private float? pAverage = null;
		private float? cAverage = null;
		private float? poAverage = null;
		private float? hAverage = null;
		private float? gAverage = null;
		private float? bAverage = null;

		private float? zhMid = null;
		private float? mMid = null;
		private float? enMid = null;
		private float? pMid = null;
		private float? cMid = null;
		private float? poMid = null;
		private float? hMid = null;
		private float? gMid = null;
		private float? bMid = null;

		private float? zhMode = null;
		private float? mMode = null;
		private float? enMode = null;
		private float? pMode = null;
		private float? cMode = null;
		private float? poMode = null;
		private float? hMode = null;
		private float? gMode = null;
		private float? bMode = null;

		private float? zhSum = null;
		private float? mSum = null;
		private float? enSum = null;
		private float? pSum = null;
		private float? cSum = null;
		private float? poSum = null;
		private float? hSum = null;
		private float? gSum = null;
		private float? bSum = null;

		public float? ZhAverage { get => this.zhAverage; set => this.zhAverage = value; }
		public float? MAverage { get => this.mAverage; set => this.mAverage = value; }
		public float? EnAverage { get => this.enAverage; set => this.enAverage = value; }
		public float? PAverage { get => this.pAverage; set => this.pAverage = value; }
		public float? CAverage { get => this.cAverage; set => this.cAverage = value; }
		public float? PoAverage { get => this.poAverage; set => this.poAverage = value; }
		public float? HAverage { get => this.hAverage; set => this.hAverage = value; }
		public float? GAverage { get => this.gAverage; set => this.gAverage = value; }
		public float? BAverage { get => this.bAverage; set => this.bAverage = value; }

		public float? ZhMid { get => this.zhMid; set => this.zhMid = value; }
		public float? MMid { get => this.mMid; set => this.mMid = value; }
		public float? EnMid { get => this.enMid; set => this.enMid = value; }
		public float? PMid { get => this.pMid; set => this.pMid = value; }
		public float? CMid { get => this.cMid; set => this.cMid = value; }
		public float? PoMid { get => this.poMid; set => this.poMid = value; }
		public float? HMid { get => this.hMid; set => this.hMid = value; }
		public float? GMid { get => this.gMid; set => this.gMid = value; }
		public float? BMid { get => this.bMid; set => this.bMid = value; }

		public float? ZhMode { get => this.zhMode; set => this.zhMode = value; }
		public float? MMode { get => this.mMode; set => this.mMode = value; }
		public float? EnMode { get => this.enMode; set => this.enMode = value; }
		public float? PMode { get => this.pMode; set => this.pMode = value; }
		public float? CMode { get => this.cMode; set => this.cMode = value; }
		public float? PoMode { get => this.poMode; set => this.poMode = value; }
		public float? HMode { get => this.hMode; set => this.hMode = value; }
		public float? GMode { get => this.gMode; set => this.gMode = value; }
		public float? BMode { get => this.bMode; set => this.bMode = value; }
		


		#endregion

		#region Overall Analytical Data

		private float? sumAverage=null;
		private float? sumMid = null;
		private float? sumMode = null;

		public float? SumAverage { get => this.sumAverage; set => this.sumAverage = value; }
		public float? SumMid { get => this.sumMid; set => this.sumMid = value; }
		public float? SumMode { get => this.sumMode; set => this.sumMode = value; }
		public float? ZhSum { get => this.zhSum; set => this.zhSum = value; }
		public float? MSum { get => this.mSum; set => this.mSum = value; }
		public float? EnSum { get => this.enSum; set => this.enSum = value; }
		public float? PSum { get => this.pSum; set => this.pSum = value; }
		public float? CSum { get => this.cSum; set => this.cSum = value; }
		public float? PoSum { get => this.poSum; set => this.poSum = value; }
		public float? HSum { get => this.hSum; set => this.hSum = value; }
		public float? GSum { get => this.gSum; set => this.gSum = value; }
		public float? BSum { get => this.bSum; set => this.bSum = value; }
		#endregion
	}
}
