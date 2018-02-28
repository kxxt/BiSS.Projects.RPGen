using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiSS.Projects.RPGen.Structure
{
	[Flags]
	public enum Subjects
	{
		Zh=0b0,
		M =0b1,
		En=0b10,
		P =0b100,
		C =0b1000,
		Po=0b10000,
		H =0b100000,
		G =0b1000000,
		B =0b10000000
	}
}
