using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiSS.Projects.RPGen.Windows;

using Spire.Xls;

using System.Reflection;
using System.Runtime.Remoting.Messaging;
using BiSS.Projects.RPGen.Structure;
using System.Dynamic;
using System.Threading;

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
			sc=SynchronizationContext.Current;
			LogWindow = new LogWindow();
			Program.ExcelWindow=new ExcelWindow("填写Excel表单");
			ExcelWindow.TopMost = true;
			//ExcelWindow.FormClosing+=new FormClosingEventHandler(((sender, args) => {
			//	if ((sender as ExcelWindow).Export().Equals(new List<ScoreModel>()) )
			//		args.Cancel = true;
			//}));
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

		private static SynchronizationContext sc;
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
		private static bool showCellInfo = true;
		private static bool raceMode = false;
		private static EventHandler<DebugEnabledChangedEventArgs> debugEnabledChanged;
		private static string envDir = Environment.CurrentDirectory+"\\";
		private static string dataDir = EnvDir + "Data"+"\\";
		private static ExpandoObject data=new ExpandoObject();
	
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
				{
					LogWindow.Wfsc.Post((state =>LogWindow.metroTextBox1.Text = log ),log);
					//LogWindow.metroTextBox1.Text = log;
				}			
				if (frm != null)
					frm.UpdateStatus("hhhh"/*log.Substring(log.LastIndexOf("\n"))*/);
			}
		}

		public static bool RaceMode { get => raceMode; private set => raceMode = value; }
		public static EventHandler<DebugEnabledChangedEventArgs> DebugEnabledChanged { get => debugEnabledChanged; set => debugEnabledChanged = value; }
		public static string EnvDir { get => envDir; set => envDir = value; }
		public static string DataDir { get => dataDir; set => dataDir = value; }
		public static bool ShowCellInfo { get => showCellInfo; set => showCellInfo = value; }
		public static Dictionary<NfSubjects,float> FullScore { get; set; }=new Dictionary<NfSubjects, float>()
		{
			{NfSubjects.Zh, 150},
			{ NfSubjects.M, 150 },
			{ NfSubjects.En, 150 },
			{ NfSubjects.P, 100 },
			{ NfSubjects.C, 100 },
			{ NfSubjects.Po, 100 },
			{ NfSubjects.H, 100 },
			{ NfSubjects.G, 100 },
			{ NfSubjects.B, 100 } 
			
		};
		public static float AllFullScore
		{
			get => FullScore[NfSubjects.Zh] + FullScore[NfSubjects.Zh] + FullScore[NfSubjects.Zh] + FullScore[NfSubjects.M] +
			       FullScore[NfSubjects.En] + FullScore[NfSubjects.P] + FullScore[NfSubjects.C] + FullScore[NfSubjects.Po] +
			       FullScore[NfSubjects.H] + FullScore[NfSubjects.G] + FullScore[NfSubjects.B];
		}

		public static void UpdateDataCache()
		{
			suicache.Item2 = true;
		}
		private static (float,bool) suicache = (float.NegativeInfinity,true);//item2:Update Require;
		public static float ScoreUnionIndicator
		{
			get
			{
				if(suicache.Item2)
				{
					suicache.Item1= FullScore[NfSubjects.Zh] * FullScore[NfSubjects.Zh] * FullScore[NfSubjects.Zh] * FullScore[NfSubjects.M] *
				       FullScore[NfSubjects.En] * FullScore[NfSubjects.P] * FullScore[NfSubjects.C] * FullScore[NfSubjects.Po] *
				       FullScore[NfSubjects.H] * FullScore[NfSubjects.G] * FullScore[NfSubjects.B];
					suicache.Item2 = false;
				}

				return suicache.Item1;
			}
		}

		public static string XlsFile
		{
			get
			{
				if (xlsFile == null)
				{
					var dt = DateTime.Now;
					xlsFile = $"{dt.Year}-{dt.Month}-{dt.Day}@{dt.Hour}-{dt.Minute}-{dt.Second}%{dt.Millisecond}.xlsx";
				}

				return xlsFile;
			}
			set => xlsFile = value;
		}

		public static dynamic Data { get => data; set => data = value; }

		public static ExcelWindow ExcelWindow;
		private static string log = "!Application Log!\r\n";
		private static LogWindow LogWindow;
		private static MainForm frm;
		private static string pptfile="";
		private static string xlsFile = null;
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
