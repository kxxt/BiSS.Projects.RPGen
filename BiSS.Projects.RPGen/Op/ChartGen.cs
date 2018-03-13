using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.Presentation;
using Syncfusion.XlsIO;

namespace BiSS.Projects.RPGen.Op
{
	public static class ChartGen
	{
		private static IPresentation ip;
		private static ISlide slide;

		static ChartGen()
		{
			ip = Presentation.Create();
			slide=ip.Slides.Add(SlideLayoutType.Blank);
		}

		public static void GenChart(IChartShape ct,object[] x,object[] y,string name,ExcelChartType type)
		{
			var s=ct.Series.Add(name, type);
			s.EnteredDirectlyValues = y;
			s.EnteredDirectlyCategoryLabels = x;
			
		}
	}
}
