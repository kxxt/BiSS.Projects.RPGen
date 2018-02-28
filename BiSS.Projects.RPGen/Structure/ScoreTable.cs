using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace BiSS.Projects.RPGen.Structure
{
	public class ScoreTable
	{
		private Dictionary<string, ScoreModel> score;
		private CalcResultContainer toBeCalc;
		private InputDataIndicator userInput;

		public void Add(string name, ScoreModel score)
		{
			this.score.Add(name,score);
		}

	

		public ScoreTable(Dictionary<string, ScoreModel> score, CalcResultContainer toBeCalc, InputDataIndicator userInput)
		{
			this.score = score;
			this.toBeCalc = toBeCalc;
			this.userInput = userInput;
		}

		public Dictionary<string, ScoreModel> Score { get => this.score; set => this.score = value; }
		public CalcResultContainer ToBeCalc { get => this.toBeCalc; set => this.toBeCalc = value; }
		public InputDataIndicator UserInput { get => this.userInput; set => this.userInput = value; }

		public void CalcAverageTest()
		{
			float t= this.score.Values.Average((ScoreModel sm) => sm.Zh ?? 0);
			float sum=0f;
			
			foreach (ScoreModel s in score.Values) sum += s.Zh??0;
			float x = sum / score.Count;
			MessageBox.Show($"t:{t}\r\nx:{x}");
		}
		public void CalcAverage()
		{
			Dictionary<Subjects, Dictionary<ScoreIndicators,float>> tmp=new Dictionary<Subjects, Dictionary<ScoreIndicators, float>>();
			//todo
			MessageBox.Show(tmp[Subjects.Zh][ScoreIndicators.Sum].ToString());
			int zhAverage = -1;
			int zhSum = 0;
			foreach (ScoreModel s in score.Values)
			{
				tmp[Subjects.Zh][ScoreIndicators.Sum] += s.Zh??0;
				tmp[Subjects.M][ScoreIndicators.Sum] += s.M ?? 0;
				tmp[Subjects.En][ScoreIndicators.Sum] += s.En ?? 0;
				tmp[Subjects.P][ScoreIndicators.Sum] += s.P ?? 0;
				tmp[Subjects.C][ScoreIndicators.Sum] += s.C ?? 0;
				tmp[Subjects.Po][ScoreIndicators.Sum] += s.Po ?? 0;
				tmp[Subjects.H][ScoreIndicators.Sum] += s.H ?? 0;
				tmp[Subjects.G][ScoreIndicators.Sum] += s.G ?? 0;
				tmp[Subjects.B][ScoreIndicators.Sum] += s.B ?? 0;
			}
			int num = score.Values.Count;
			tmp[Subjects.Zh][ScoreIndicators.Average] = score.Values.Average(sm => sm.Zh ?? 0);
			tmp[Subjects.M][ScoreIndicators.Average] = score.Values.Average(sm => sm.M ?? 0);
			tmp[Subjects.En][ScoreIndicators.Average] = score.Values.Average(sm => sm.En ?? 0);
			tmp[Subjects.P][ScoreIndicators.Average] = score.Values.Average(sm => sm.P ?? 0);
			tmp[Subjects.C][ScoreIndicators.Average] = score.Values.Average(sm => sm.C ?? 0);
			tmp[Subjects.Po][ScoreIndicators.Average] = score.Values.Average(sm => sm.Po ?? 0);
			tmp[Subjects.H][ScoreIndicators.Average] = score.Values.Average(sm => sm.H ?? 0);
			tmp[Subjects.G][ScoreIndicators.Average] = score.Values.Average(sm => sm.G ?? 0);
			tmp[Subjects.B][ScoreIndicators.Average] = score.Values.Average(sm => sm.B ?? 0);
			//tmp[Subjects.Zh][ScoreIndicators.Average] = this.score.Values.Average(sm =>sm.Zh ?? 0);
		}
	}
}
