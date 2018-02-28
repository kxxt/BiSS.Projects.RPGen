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
using System.Reflection;

namespace BiSS.Projects.RPGen
{
	internal static class Program
	{
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		private static int Main()
		{
#if DEBUG
			DebugEnabled = true;
#endif
#if RACE
			RaceMode = true;
#endif
			DataDir = EnvDir + "Data\\";
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			//MetroFramework.Fonts.FontResolver fontResolver = new FontResolver();
			//fontResolver.ResolveFont("微软雅黑", 12, FontStyle.Regular, GraphicsUnit.Pixel);
			// BindingFlags bf = BindingFlags.Static | BindingFlags.NonPublic;
			//typeof(MetroFramework.MetroFonts).GetField("", bf).SetValue();
			LogWindow = new LogWindow();
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
			Logs += str + "\r\n";
		}
		public static void ShowLogWindow()
		{
			Log("ShowLogWindow.");
			LogWindow.Visible = true;
		}
		private static bool debugEnabled = true;//todo
		private static bool raceMode = false;
		private static EventHandler<DebugEnabledChangedEventArgs> debugEnabledChanged;
		private static string envDir = Environment.CurrentDirectory+"\\";
		private static string dataDir = EnvDir + "Data"+"\\";
		public static bool DebugEnabled
		{
			get => debugEnabled;
			set
			{
				debugEnabled = value;
				debugEnabledChanged?.Invoke(null, new DebugEnabledChangedEventArgs(value));
			}
		}

		public static string Logs
		{
			get => log; set
			{
				log = value;
				if (LogWindow != null)
					LogWindow.metroTextBox1.Text = log;
				if (frm != null)
					frm.UpdateStatus("hhhh"/*log.Substring(log.LastIndexOf("\n"))*/);
			}
		}

		public static bool RaceMode { get => raceMode; private set => raceMode = value; }
		public static EventHandler<DebugEnabledChangedEventArgs> DebugEnabledChanged { get => debugEnabledChanged; set => debugEnabledChanged = value; }
		public static string EnvDir { get => envDir; set => envDir = value; }
		public static string DataDir { get => dataDir; set => dataDir = value; }

		private static string log = "!Application Log!\r\n";
		private static LogWindow LogWindow;
		private static MainForm frm;
	}

	public class DebugEnabledChangedEventArgs : EventArgs
	{
		private bool value = false;

		public DebugEnabledChangedEventArgs(bool value)
		{
			this.value = value;
		}

		public bool Value { get => this.value; set => this.value = value; }
	}
}
