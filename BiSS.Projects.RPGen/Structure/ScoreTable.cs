using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;
using static BiSS.Projects.RPGen.Op.BiSSMath;

namespace BiSS.Projects.RPGen.Structure
{
	public class ScoreTable
	{
		private Dictionary<string, ScoreModel> score;
	 	private Dictionary<Subjects, Dictionary<ScoreIndicators, float>> calcResult = new Dictionary<Subjects, Dictionary<ScoreIndicators, float>>();
		private InputDataIndicator userInput;

		public void Add(string name, ScoreModel score)
		{
			if(!Score.ContainsKey(name))
			this.score.Add(name,score);
		}

		public IList<DisplayObject> Export()
		{
			var ret=new List<DisplayObject>();
			int i = 1;
			foreach (var s in score)
			{
				ret.Add(new DisplayObject(i++,s.Key,s.Value));
			}
			return ret;
		}
		public string[,] ToStringArray()
		{
			var t=new string[score.Count,score.Count];
			int index = 0;
			//t[0, 0] = "*";
			//t[0, 1] = "姓名";
			//t[0, 2] = "语文";
			//t[0, 3] = "数学";
			//t[0, 4] = "英语";
			//t[0, 5] = "物理";
			//t[0, 6] = "化学";
			//t[0, 7] = "政治";
			//t[0, 8] = "历史";
			//t[0, 9] = "地理";
			//t[0, 10] = "生物";
			t[0, 0] = "id";
			t[1, 0] = "姓名";
			t[2, 0] = "语文";
			t[3, 0] = "数学";
			t[4, 00] = "英语";
			t[5, 0] = "物理";
			t[6, 0] = "化学";
			t[7, 0] = "政治";
			t[8, 0] = "历史";
			t[9, 0] = "地理";
			t[10, 0] = "生物";
			//foreach (var s in score)
			//{
			//	t[0,]
			//}
			return t;
		}
		public ScoreTable(Dictionary<string, ScoreModel> score, InputDataIndicator userInput)
		{
			this.score = score;
			this.userInput = userInput;
		}

		public Dictionary<string, ScoreModel> Score { get => this.score; set => this.score = value; }
		public InputDataIndicator UserInput { get => this.userInput; set => this.userInput = value; }
		public Dictionary<Subjects, Dictionary<ScoreIndicators, float>> CalcResult { get => this.calcResult; }

		public void CalcAverageTest()
		{
			float t= this.score.Values.Average((ScoreModel sm) => sm.Zh ?? 0);
			
			float sum=0f;
			
			foreach (ScoreModel s in score.Values) sum += s.Zh??0;
			float x = sum / score.Count;
			MessageBox.Show($"t:{t}\r\nx:{x}");
		}

		public void GetRank()
		{
			
		}
		public void CalcAverage()
		{
			
			//todo
			
			int zhAverage = -1;
			int zhSum = 0;
			//IList<float> Zh=new List<float>(); 
			MessageBox.Show(score.Values.Count.ToString()+$"\r\n{score}");
			foreach (var s in score)
			{
				calcResult[Subjects.Zh][ScoreIndicators.Sum] += s.Value.Zh ?? 0;
				calcResult[Subjects.M][ScoreIndicators.Sum] += s.Value.M ?? 0;
				calcResult[Subjects.En][ScoreIndicators.Sum] += s.Value.En ?? 0;
				calcResult[Subjects.P][ScoreIndicators.Sum] += s.Value.P ?? 0;
				calcResult[Subjects.C][ScoreIndicators.Sum] += s.Value.C ?? 0;
				calcResult[Subjects.Po][ScoreIndicators.Sum] += s.Value.Po ?? 0;
				calcResult[Subjects.H][ScoreIndicators.Sum] += s.Value.H ?? 0;
				calcResult[Subjects.G][ScoreIndicators.Sum] += s.Value.G ?? 0;
				calcResult[Subjects.B][ScoreIndicators.Sum] += s.Value.B ?? 0;
				//Zh.Add(s.Zh??throw new NotSupportedException("Null Value is not supported for calcing mode."));
			}
			calcResult[Subjects.All][ScoreIndicators.Sum] =
				calcResult[Subjects.Zh][ScoreIndicators.Sum] +
				calcResult[Subjects.M][ScoreIndicators.Sum] +
				calcResult[Subjects.En][ScoreIndicators.Sum] +
				calcResult[Subjects.P][ScoreIndicators.Sum] +
				calcResult[Subjects.H][ScoreIndicators.Sum] +
				calcResult[Subjects.Po][ScoreIndicators.Sum] +
				calcResult[Subjects.H][ScoreIndicators.Sum] +
				calcResult[Subjects.G][ScoreIndicators.Sum] +
				calcResult[Subjects.B][ScoreIndicators.Sum];
			calcResult[Subjects.All][ScoreIndicators.Average] = calcResult[Subjects.All][ScoreIndicators.Sum] / Score.Count;

			calcResult[Subjects.Zh][ScoreIndicators.Average] = score.Values.Average(sm => sm.Zh ?? 0);
			calcResult[Subjects.M][ScoreIndicators.Average] = score.Values.Average(sm => sm.M ?? 0);
			calcResult[Subjects.En][ScoreIndicators.Average] = score.Values.Average(sm => sm.En ?? 0);
			calcResult[Subjects.P][ScoreIndicators.Average] = score.Values.Average(sm => sm.P ?? 0);
			calcResult[Subjects.C][ScoreIndicators.Average] = score.Values.Average(sm => sm.C ?? 0);
			calcResult[Subjects.Po][ScoreIndicators.Average] = score.Values.Average(sm => sm.Po ?? 0);
			calcResult[Subjects.H][ScoreIndicators.Average] = score.Values.Average(sm => sm.H ?? 0);
			calcResult[Subjects.G][ScoreIndicators.Average] = score.Values.Average(sm => sm.G ?? 0);
			calcResult[Subjects.B][ScoreIndicators.Average] = score.Values.Average(sm => sm.B ?? 0);
			//calcResult[Subjects.Zh][ScoreIndicators.Average] = this.score.Values.Average(sm =>sm.Zh ?? 0);

			//calcResult[Subjects.Zh][ScoreIndicators.Mode] = Zh.QueryMode() ?? -1;
			//MessageBox.Show($"Zh-Mode:{calcResult[Subjects.Zh][ScoreIndicators.Mode]}");



		}

	}
}
/*foreach (var s in score.Values)
			{
				calcResult[Subjects.Zh][ScoreIndicators.Sum] += s.Zh??0;
				calcResult[Subjects.M][ScoreIndicators.Sum] += s.M ?? 0;
				calcResult[Subjects.En][ScoreIndicators.Sum] += s.En ?? 0;
				calcResult[Subjects.P][ScoreIndicators.Sum] += s.P ?? 0;
				calcResult[Subjects.C][ScoreIndicators.Sum] += s.C ?? 0;
				calcResult[Subjects.Po][ScoreIndicators.Sum] += s.Po ?? 0;
				calcResult[Subjects.H][ScoreIndicators.Sum] += s.H ?? 0;
				calcResult[Subjects.G][ScoreIndicators.Sum] += s.G ?? 0;
				calcResult[Subjects.B][ScoreIndicators.Sum] += s.B ?? 0;
				//Zh.Add(s.Zh??throw new NotSupportedException("Null Value is not supported for calcing mode."));
			}*/
