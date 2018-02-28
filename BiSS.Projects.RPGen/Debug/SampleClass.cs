using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet;
using MathNet.Numerics;
using MathNet.Numerics.Statistics;
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
			Statistics.Entropy(new List<double>() {12, 3, 124, 3, 24, 325, 34, 423, 5, 435, 23, 4356});
		}

	}
}
