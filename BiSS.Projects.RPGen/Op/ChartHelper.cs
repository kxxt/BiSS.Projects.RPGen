using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiSS.Projects.RPGen.Op
{
	public static class ChartHelper
	{
		public static void SetPos(this IChartShape ct, double x, double y)
		{
			ct.XPos = x;
			ct.YPos = y;
		}
		public static void SetPos(this IChartShape ct, PointF point)
		{
			ct.XPos = point.X;
			ct.YPos = point.Y;
		}
		public static void SetSize(this IChart ct, double w, double h)
		{
			ct.Width = w;
			ct.Height = h;
		}
		public static void SetSize(this IChart ct, SizeF size)
		{
			ct.Width = size.Width;
			ct.Height = size.Height;
		}
		public static void SetTitleAreaStyle(this IChartShape ct)
		{
			ct.ChartTitleArea.FontName = "微软雅黑";
			ct.ChartTitleArea.Size = 18;
			ct.ChartTitleArea.Bold = false;
		}
		public static void SetLegendAreaStyle(this IChartShape ct)
		{
			var l = ct.Legend;
			l.TextArea.Bold = false;
			l.TextArea.FontName = "微软雅黑";
			l.Position = ExcelLegendPosition.Left;
			l.FrameFormat.Border.LinePattern = ExcelChartLinePattern.None;

		}
		public static void SetAllStyles(this IChartShape ct)
		{
			ct.SetLegendAreaStyle();
			ct.SetTitleAreaStyle();
			ct.SetChartAreaStyle();
		}
		public static void SetChartAreaStyle(this IChartShape ct)
		{
			var l = ct.ChartArea;
			l.Border.LinePattern = ExcelChartLinePattern.None;
			l.LineProperties.LinePattern = ExcelChartLinePattern.None;
			l.RectangleStyle = ExcelRectangleStyle.Regular;

		}
	}
}
