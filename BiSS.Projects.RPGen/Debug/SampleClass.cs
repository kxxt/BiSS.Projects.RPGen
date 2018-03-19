using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiSS.Projects.RPGen.Op;

//using MathNet;
//using MathNet.Numerics;
//using MathNet.Numerics.Statistics;
namespace BiSS.Projects.RPGen.Debug
{
	public class SampleClass
	{
		private int age;
		private String name;
		private string description;
		private Rectangle rect;

		public SampleClass(Rectangle? rect,int age=10, string name="123134", string description="NOOO")
		{
			this.Age = age;
			this.Name = name;
			this.Description = description;
			this.Rect = rect?? new Rectangle(1,1,0,4);
		}

		public int Age { get => this.age; set => this.age = value; }
		public string Name { get => this.name; set => this.name = value; }
		public string Description { get => this.description; set => this.description = value; }
		public Rectangle Rect { get => this.rect; set => this.rect = value; }

		public static void TestFunctions()
		{
			//Statistics.Entropy(new List<double>() {12, 3, 124, 3, 24, 325, 34, 423, 5, 435, 23, 4356});
		}

		public static object TestAnalyzerCount(int test)
		{
			switch (test)
			{
				case 1:
					return new[] { 1, 23, 34, 354, 456, 456, 345 }.CountItemInRange(1, 100);
				case 2:
					return new[] {(1, 2), (23, 34), (-12, 23), (-122, 432)}.CountItemInRange(-10000, 0, (tuple => tuple.Item1));
				case 3:
					return new[] {11f, 2.324f, 0.234f, 123.13f, 123.4f, 1243.234234f}.CountItemInRange(0, 100);
				case 4:
					return new[] {(1, 2, 1), (2, 3, 4), (23, 23, 34), (12, 34, 4)}.CountItemInRange(0, 20, it => it.Item2);
			}

			return "233333333333";
		}
	}
}
