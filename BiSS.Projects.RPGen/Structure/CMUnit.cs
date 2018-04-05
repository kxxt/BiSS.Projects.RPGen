using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.Windows.Forms.Grid;

namespace BiSS.Projects.RPGen.Structure
{
	public struct CMUnit
	{
		private double value;

		public double Value { get => this.value; set => this.value = value; }
		public static implicit operator double(CMUnit val)
		{
			return val.Value;
		}
		public static implicit operator float(CMUnit val)
		{
			return (float)val.Value;
		}
		public static explicit operator XlsSizeUnit(CMUnit val)
		{
			return val.value * 37.7358;
		}
		public static implicit operator CMUnit(double val)
		{
			return new CMUnit{ value = val };
		}
	}
}
