using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiSS.Projects.RPGen.Windows;
using Spire.DataExport.EventArgs;
using Spire.XLS;
using Spire.Presentation;
using Spire.Presentation.Collections;
using Spire.Presentation.Drawing;
using Spire.Xls;
using FileFormat = Spire.Presentation.FileFormat;

namespace BiSS.Projects.RPGen
{
	static class Program
	{
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static int Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
//#region TEST
//			Workbook t=new Workbook();
//			t.Version=ExcelVersion.Version2013;
//			t.SaveToFile("test.xlsx");
//			Presentation ppt=new Presentation();
//			ppt.Slides[0].SlideBackground.Type=BackgroundType.Custom;
//			ppt.Slides[0].SlideBackground.Fill.FillType=FillFormatType.Solid;
//			ppt.Slides[0].SlideBackground.Fill.SolidColor.Color = Color.Aqua;
//			FileStream fs=new FileStream("ppt.pptx",FileMode.Create);
//			ppt.SaveToFile(fs, FileFormat.Pptx2010);
			
//#endregion
			
			Application.Run(new SplashWindow());
			Application.Run(new MainForm());
			return 0;
		}
	}
}
