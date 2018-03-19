using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiSS.Projects.RPGen.Structure
{
	[AttributeUsage(AttributeTargets.All,AllowMultiple = true,Inherited = true)]
	public class Passed:Attribute
	{
		private bool passed = false;
		public Passed(bool passed=true)
		{
			this.passed = passed;
		}
		public bool IsPassed { get => this.passed; set => this.passed = value; }
	}
}
