using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiSS.Projects.RPGen.ExcelLayout
{
	public struct ChartLayout
	{
		private double x,y;
		private double w, h;

		public double X { get => this.x; set => this.x = value; }
		public double Y { get => this.y; set => this.y = value; }
		public double W { get => this.w; set => this.w = value; }
		public double H { get => this.h; set => this.h = value; }
	}
}
