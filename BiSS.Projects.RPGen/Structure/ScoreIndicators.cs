using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiSS.Projects.RPGen.Structure
{
	[Flags]
	public enum ScoreIndicators
	{
		Average=0b1,
		Mid=0b10,
		Mode=0b100,
		Sum=0b1000
	}
}
