using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiSS.Projects.RPGen.Structure
{
	
	public enum Level
	{
		A=1,B=2,C=3,D=4
	}

	public  class DLevel
	{
		private Dictionary<string,float[]> value=new Dictionary<string, float[]>();

		public float[] this[string id]
		{
			get { return value[id] ?? null; }
			set { this.value[id] = value; }
		}
	}
}
