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
using MetroFramework.Fonts;
using System.Reflection;

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
#if DEBUG
			DebugEnabled = true;
#endif
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
            //MetroFramework.Fonts.FontResolver fontResolver = new FontResolver();
            //fontResolver.ResolveFont("微软雅黑", 12, FontStyle.Regular, GraphicsUnit.Pixel);
           // BindingFlags bf = BindingFlags.Static | BindingFlags.NonPublic;
            //typeof(MetroFramework.MetroFonts).GetField("", bf).SetValue();
			LogWindow=new LogWindow();
            LogWindow.Visible = false;
            frm = new MainForm();
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
            Log("App Started,displaying the SplashWindow.");
			Application.Run(new SplashWindow());
			Application.Run(frm);
			return 0;
		}
        public static void Log(string str)
        {
            Logs += str+"\r\n";
        }
		public static void ShowLogWindow()
		{
            Log("ShowLogWindow.");
			LogWindow.Visible=true;
		}
		private static bool debugEnabled=true;//todo

		public static bool DebugEnabled { get => debugEnabled; set => debugEnabled = value; }
		public static string Logs { get => log; set{ log = value;
            if(LogWindow!=null)
            {
                LogWindow.metroTextBox1.Text = log;
                    
            }
                if (frm != null)
                    frm.UpdateStatus("hhhh"/*log.Substring(log.LastIndexOf("\n"))*/);

            }
        }

		private static string log="!Application Log!\r\n";
		private static LogWindow LogWindow;
        private static MainForm frm;
	}
}
