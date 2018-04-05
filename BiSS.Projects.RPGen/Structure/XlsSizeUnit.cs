using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiSS.Projects.RPGen.Structure
{
	public struct XlsSizeUnit
	{
		private double value;

		public double Value { get => this.value; set => this.value = value; }
		public static implicit operator double(XlsSizeUnit val)
		{
			return val.Value;
		}
		public static implicit operator float(XlsSizeUnit val)
		{
			return (float)val.Value;
		}
		public static implicit operator XlsSizeUnit(double val)
		{
			return new XlsSizeUnit {value = val};
		}
		public static explicit operator CMUnit(XlsSizeUnit val)
		{
			return (CMUnit)(val.value /37.7358);
		}
	}
}
