using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiSS.Projects.RPGen.Windows;



using System.Reflection;
using System.Runtime.Remoting.Messaging;
using BiSS.Projects.RPGen.Structure;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Threading;
using BiSS.Projects.RPGen.ExcelLayout;
using BiSS.Projects.RPGen.Op;
using BiSS.Projects.RPGen.Properties;
using BiSS.Projects.RPGen.Windows.Wizard;
using Newtonsoft.Json;
using Syncfusion.Data.Extensions;
using Syncfusion.XlsIO;
using Syncfusion.Presentation;

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
			if (DebugEnabled)
				if (File.Exists("test.dat"))
					Data.TestData = JsonConvert.DeserializeObject<IList<ScoreModel>>(File.ReadAllText("test.dat"));


			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			//MetroFramework.Fonts.FontResolver fontResolver = new FontResolver();
			//fontResolver.ResolveFont("微软雅黑", 12, FontStyle.Regular, GraphicsUnit.Pixel);
			// BindingFlags bf = BindingFlags.Static | BindingFlags.NonPublic;
			//typeof(MetroFramework.MetroFonts).GetField("", bf).SetValue();
			sc = SynchronizationContext.Current;
			LogWindow = new LogWindow();
			Program.ExcelWindow = new ExcelWindow("填写Excel表单");
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

		private static bool showReadme = false;
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
		private static string envDir = Environment.CurrentDirectory + "\\";
		private static string dataDir = EnvDir + "Data" + "\\";
		private static ExpandoObject data = new ExpandoObject();
		private static string title = "成绩报告";
		private static string className = "本班";
		private static string author = "Believers in Science Studio";
		private static Dictionary<NfSubjects, Dictionary<Level, float>> seprators = new Dictionary<NfSubjects, Dictionary<Level, float>>()
		{
			[NfSubjects.Zh] = new Dictionary<Level, float>()
			{
				[Level.A] = 0.9f,
				[Level.B] = 0.8f,
				[Level.C] = 0.6f,
				[Level.D] = 0.0f
			},
			[NfSubjects.M] = new Dictionary<Level, float>()
			{
				[Level.A] = 0.9f,
				[Level.B] = 0.8f,
				[Level.C] = 0.6f,
				[Level.D] = 0.0f
			},
			[NfSubjects.En] = new Dictionary<Level, float>()
			{
				[Level.A] = 0.9f,
				[Level.B] = 0.8f,
				[Level.C] = 0.6f,
				[Level.D] = 0.0f
			},
			[NfSubjects.P] = new Dictionary<Level, float>()
			{
				[Level.A] = 0.9f,
				[Level.B] = 0.8f,
				[Level.C] = 0.6f,
				[Level.D] = 0.0f
			},
			[NfSubjects.C] = new Dictionary<Level, float>()
			{
				[Level.A] = 0.9f,
				[Level.B] = 0.8f,
				[Level.C] = 0.6f,
				[Level.D] = 0.0f
			},
			[NfSubjects.Po] = new Dictionary<Level, float>()
			{
				[Level.A] = 0.9f,
				[Level.B] = 0.8f,
				[Level.C] = 0.6f,
				[Level.D] = 0.0f
			},
			[NfSubjects.H] = new Dictionary<Level, float>()
			{
				[Level.A] = 0.9f,
				[Level.B] = 0.8f,
				[Level.C] = 0.6f,
				[Level.D] = 0.0f
			},
			[NfSubjects.G] = new Dictionary<Level, float>()
			{
				[Level.A] = 0.9f,
				[Level.B] = 0.8f,
				[Level.C] = 0.6f,
				[Level.D] = 0.0f
			},
			[NfSubjects.B] = new Dictionary<Level, float>()
			{
				[Level.A] = 0.9f,
				[Level.B] = 0.8f,
				[Level.C] = 0.6f,
				[Level.D] = 0.0f
			},
			[NfSubjects.All] = new Dictionary<Level, float>()
			{
				[Level.A] = 0.9f,
				[Level.B] = 0.8f,
				[Level.C] = 0.6f,
				[Level.D] = 0.0f
			},
		};

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
					LogWindow.Wfsc.Post((state => LogWindow.metroTextBox1.Text = log), log);
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
		public static Dictionary<NfSubjects, float> FullScore { get; set; } = new Dictionary<NfSubjects, float>()
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

		public static void SaveExcel(IList<ScoreModel> list, string pathWithoutLine, string mname, bool v2007 = true)
		{
			IList<(NfSubjects, float)> aveList = Analyzer.Average(list);
			//BindingList<(NfSubjects, float)> aveBindingList = Analyzer.Average(li);//todo;
			IList<(NfSubjects, float)> sumList = Analyzer.Sum(list);
			IList<(NfSubjects, float[])> modeList = Analyzer.Mode(list);
			IList<(NfSubjects, double)> midList = Analyzer.Mid(list);
			Log("Average:\r\n" + string.Join(",", aveList));
			Log("Sum:\r\n" + string.Join(",", sumList));
			Log("Mode:");
			foreach (var mode in modeList)
			{
				Log($"{mode.Item1.ToString()}:{string.Join(",", mode.Item2)}");
			}
			//Log("Mode:\r\n" + string.Join(",",modeList));
			Log("Mid:\r\n" + string.Join(",", midList));

			ExcelEngine ee = new ExcelEngine();

			IApplication xls = ee.Excel;

			xls.DefaultVersion = Syncfusion.XlsIO.ExcelVersion.Excel2016;
			IWorkbook wb = xls.Workbooks.Create();
			wb.Version = v2007 ? ExcelVersion.Excel2016 : ExcelVersion.Excel97to2003;
			IWorksheet ws = wb.ActiveSheet;
			IChartShape chart = ws.Charts.Add();
			/////////////////////////////////////////////////////
			//IChartSerie serie = chart.Series.Add(Syncfusion.XlsIO.ExcelChartType.Column_Clustered);
			//chart.ChartType = Syncfusion.XlsIO.ExcelChartType.Column_Clustered;
			IList<string> xave = new List<string>();
			IList<object> yave = new List<object>();
			int allavei = Int32.MaxValue, allmidi = Int32.MaxValue;
			for (var index = 0; index < aveList.Count; index++)
			{
				if (aveList[index].Item1 == NfSubjects.All)
					allavei = index;
				var ave = aveList[index];
				xave.Add(ave.Item1.Name());
				yave.Add(ave.Item2);
			}

			//serie.EnteredDirectlyValues = yave.ToArray();
			//serie.Name = "平均分";
			//serie.EnteredDirectlyCategoryLabels = xave.ToArray();
			ChartGen.GenChart(chart, xave.ToArray(), yave.ToArray(), "平均分", ExcelChartType.Column_Clustered);
			////////////////////////////////////////////////
			//IChartSerie seriemid = chart.Series.Add(Syncfusion.XlsIO.ExcelChartType.Column_Clustered);
			//chart.ChartType = Syncfusion.XlsIO.ExcelChartType.Column_Clustered;
			IList<string> xmid = new List<string>();
			IList<object> ymid = new List<object>();
			for (var index = 0; index < midList.Count; index++)
			{
				if (midList[index].Item1 == NfSubjects.All)
					allmidi = index;
				var mid = midList[index];
				xmid.Add(mid.Item1.Name());
				ymid.Add(mid.Item2);
			}
			ChartGen.GenChart(chart, xmid.ToArray(), ymid.ToArray(), "中位分", ExcelChartType.Column_Clustered);
			//{{{{{{{{{{{{{{
			xave.RemoveAt(allavei);
			yave.RemoveAt(allavei);
			xmid.RemoveAt(allmidi);
			ymid.RemoveAt(allmidi);
			IChartShape leida = ws.Shapes.AddChart();

			ChartGen.GenChart(leida, xave.ToArray(), yave.ToArray(), "平均分", ExcelChartType.Radar);
			ChartGen.GenChart(leida, xmid.ToArray(), ymid.ToArray(), "中位分", ExcelChartType.Radar);
			leida.Name = "学科成绩分布1";
			leida.ChartTitle = "学科成绩分布1";
			//}}}}}}}}}}}}}}
			//{{{{{{{{{{{{{{
			var xyave = Analyzer.ReArrangeData(aveList);
			var xymid = Analyzer.ReArrangeData(midList);
			IChartShape leida2 = ws.Shapes.AddChart();

			ChartGen.GenChart(leida2, xyave.Item1, xyave.Item2, "平均分", ExcelChartType.Radar);
			ChartGen.GenChart(leida2, xymid.Item1, xymid.Item2, "中位分", ExcelChartType.Radar);
			leida2.Name = "学科成绩分布2";
			leida2.ChartTitle = "学科成绩分布2";
			//}}}}}}}}}}}}}}
			var ordered = list.OrderBy(pp => pp.Sum);
			ChartGen.GenChart(ws.Shapes.AddChart(), ordered.Select(sm => (object)(sm.Name)).ToArray(), ordered.Select(sm => (object)(sm.Sum ?? 0)).ToArray(), "总分", ExcelChartType.Column_Clustered);
			//seriemid.EnteredDirectlyValues = ymid.ToArray();
			//seriemid.Name = "中位分";
			//seriemid.EnteredDirectlyCategoryLabels = xmid.ToArray();
			//IChartShape pie1 = ws.Shapes.AddChart();
			int[][] nperl = new int[10][];
			string testmsg = "";
			for (NfSubjects sub = NfSubjects.Zh; sub <= NfSubjects.All; sub++)
			{
				if (sub != NfSubjects.All)
					nperl[(int)sub] = list.CountStuNumPerLevelPerSubject(sub, Program.FullScore[sub], Program.Seprators[sub]);
				else
					nperl[(int)sub] = list.CountStuNumPerLevelPerSubject(sub, Program.AllFullScore, Program.Seprators[sub]);
				string tmp___ = "";
				for (var index = 1; index < nperl[(int)sub].Length; index++)
				{

					int xXXx = nperl[(int)sub][index];
					tmp___ += $"{xXXx.ToString()} , ";
				}

				testmsg += $"{sub}\t{tmp___}\r\n";
			}

			//var cpy = new float[nperl[(int)NfSubjects.Zh].Length-1];
			int cnt_of_all = list.Count;
			//for (var index = 0; index < cpy.Length; index++)
			//{
			//	cpy[index] = (float)nperl[(int)NfSubjects.Zh][index+1] / cnt_of_all;
			//}

			//MessageBox.Show(testmsg+"\r\n"+ $"{cpy.FormatCol()}\r\nCount:{cnt_of_all}");
			//pie1.Name = "等级分布示意图";
			//pie1.ChartTitle = "等级分布示意图";
			//ChartGen.GenPieChart(pie1,LevelEx.GetOrders_ExtraIncluded_().ToObjectArray(),cpy.ToObjectArray(), "等级分布示意图");
			CMUnit widthTST = 13f;
			CMUnit heighTST = 10f;
			LayoutCalc_ChartsRegularLayout_ layout = new LayoutCalc_ChartsRegularLayout_(
				new PointF((XlsSizeUnit)((CMUnit)10), (XlsSizeUnit)((CMUnit)10)),
				new SizeF((XlsSizeUnit)((CMUnit)0.5), (XlsSizeUnit)((CMUnit)0.8)),
				new SizeF((XlsSizeUnit)widthTST, (XlsSizeUnit)heighTST),
				3, 10
				);
			for (NfSubjects sub = NfSubjects.Zh; sub <= NfSubjects.All; sub++)
			{
				var cpy_sub = new float[nperl[(int)sub].Length - 1];
				for (var index = 0; index < cpy_sub.Length; index++)
				{
					cpy_sub[index] = (float)nperl[(int)sub][index + 1] / cnt_of_all;
				}
				IChartShape pie = ws.Shapes.AddChart();
				if (sub == NfSubjects.All)
					pie.Name = $"总成绩等级分布示意图";
				else
					pie.Name = $"{sub.Name()}学科等级分布示意图";
				pie.ChartTitle = pie.Name;
				var nextp = layout.Next;
				pie.XPos = nextp.point.X;
				pie.YPos = nextp.point.Y;
				((IChart)pie).Width = nextp.size.Width;
				((IChart)pie).Height = nextp.size.Height;

				ChartGen.GenPieChart(pie, LevelEx.GetOrders_ExtraIncluded_().ToObjectArray(), cpy_sub.ToObjectArray(), pie.Name);
			}
			/////////////////////////////////////////////////
			xls.Save(pathWithoutLine + "\\" + mname + (v2007 ? ".xlsx" : ".xls"));
			wb.Close();
			ee.Dispose();
		}
		//public static void SavePPT(IList<ScoreModel> list, string pathWithoutLine, string mname, bool v2007 = true)
		//{
		//	IList<(NfSubjects, float)> aveList = Analyzer.Average(list);
		//	//BindingList<(NfSubjects, float)> aveBindingList = Analyzer.Average(li);//todo;
		//	IList<(NfSubjects, float)> sumList = Analyzer.Sum(list);
		//	IList<(NfSubjects, float[])> modeList = Analyzer.Mode(list);
		//	IList<(NfSubjects, double)> midList = Analyzer.Mid(list);
		//	Log("Average:\r\n" + string.Join(",", aveList));
		//	Log("Sum:\r\n" + string.Join(",", sumList));
		//	Log("Mode:");
		//	foreach (var mode in modeList)
		//	{
		//		Log($"{mode.Item1.ToString()}:{string.Join(",", mode.Item2)}");
		//	}
		//	//Log("Mode:\r\n" + string.Join(",",modeList));
		//	Log("Mid:\r\n" + string.Join(",", midList));

		//	IPresentation ip = Presentation.Create();

		//	//IApplication xls = ip.;
		//	ISlide slide = ip.Slides[0];

		////	IWorkbook wb = xls.Workbooks.Create();
		//	//wb.Version = v2007 ? ExcelVersion.Excel2016 : ExcelVersion.Excel97to2003;
		//	//IWorksheet ws = wb.ActiveSheet;
		//	IPresentationChart chart = slide.Charts.AddChart(0,0,200,200);
		//	chart.SetChartData();
		//	/////////////////////////////////////////////////////
		//	//IChartSerie serie = chart.Series.Add(Syncfusion.XlsIO.ExcelChartType.Column_Clustered);
		//	//chart.ChartType = Syncfusion.XlsIO.ExcelChartType.Column_Clustered;
		//	IList<string> xave = new List<string>();
		//	IList<object> yave = new List<object>();
		//	int allavei = Int32.MaxValue, allmidi = Int32.MaxValue;
		//	for (var index = 0; index < aveList.Count; index++)
		//	{
		//		if (aveList[index].Item1 == NfSubjects.All)
		//			allavei = index;
		//		var ave = aveList[index];
		//		xave.Add(ave.Item1.Name());
		//		yave.Add(ave.Item2);
		//	}

		//	//serie.EnteredDirectlyValues = yave.ToArray();
		//	//serie.Name = "平均分";
		//	//serie.EnteredDirectlyCategoryLabels = xave.ToArray();
		//	ChartGen.GenChart(chart, xave.ToArray(), yave.ToArray(), "平均分", ExcelChartType.Column_Clustered);
		//	////////////////////////////////////////////////
		//	//IChartSerie seriemid = chart.Series.Add(Syncfusion.XlsIO.ExcelChartType.Column_Clustered);
		//	//chart.ChartType = Syncfusion.XlsIO.ExcelChartType.Column_Clustered;
		//	IList<string> xmid = new List<string>();
		//	IList<object> ymid = new List<object>();
		//	for (var index = 0; index < midList.Count; index++)
		//	{
		//		if (midList[index].Item1 == NfSubjects.All)
		//			allmidi = index;
		//		var mid = midList[index];
		//		xmid.Add(mid.Item1.Name());
		//		ymid.Add(mid.Item2);
		//	}
		//	ChartGen.GenChart(chart, xmid.ToArray(), ymid.ToArray(), "中位分", ExcelChartType.Column_Clustered);
		//	//{{{{{{{{{{{{{{
		//	xave.RemoveAt(allavei);
		//	yave.RemoveAt(allavei);
		//	xmid.RemoveAt(allmidi);
		//	ymid.RemoveAt(allmidi);
		//	IChartShape leida = ws.Shapes.AddChart();

		//	ChartGen.GenChart(leida, xave.ToArray(), yave.ToArray(), "平均分", ExcelChartType.Radar);
		//	ChartGen.GenChart(leida, xmid.ToArray(), ymid.ToArray(), "中位分", ExcelChartType.Radar);
		//	leida.Name = "学科成绩分布1";
		//	leida.ChartTitle = "学科成绩分布1";
		//	//}}}}}}}}}}}}}}
		//	//{{{{{{{{{{{{{{
		//	var xyave = Analyzer.ReArrangeData(aveList);
		//	var xymid = Analyzer.ReArrangeData(midList);
		//	IChartShape leida2 = ws.Shapes.AddChart();

		//	ChartGen.GenChart(leida2, xyave.Item1, xyave.Item2, "平均分", ExcelChartType.Radar);
		//	ChartGen.GenChart(leida2, xymid.Item1, xymid.Item2, "中位分", ExcelChartType.Radar);
		//	leida2.Name = "学科成绩分布2";
		//	leida2.ChartTitle = "学科成绩分布2";
		//	//}}}}}}}}}}}}}}
		//	var ordered = list.OrderBy(pp => pp.Sum);
		//	ChartGen.GenChart(ws.Shapes.AddChart(), ordered.Select(sm => (object)(sm.Name)).ToArray(), ordered.Select(sm => (object)(sm.Sum ?? 0)).ToArray(), "总分", ExcelChartType.Column_Clustered);
		//	//seriemid.EnteredDirectlyValues = ymid.ToArray();
		//	//seriemid.Name = "中位分";
		//	//seriemid.EnteredDirectlyCategoryLabels = xmid.ToArray();
		//	//IChartShape pie1 = ws.Shapes.AddChart();
		//	int[][] nperl = new int[10][];
		//	string testmsg = "";
		//	for (NfSubjects sub = NfSubjects.Zh; sub <= NfSubjects.All; sub++)
		//	{
		//		if (sub != NfSubjects.All)
		//			nperl[(int)sub] = list.CountStuNumPerLevelPerSubject(sub, Program.FullScore[sub], Program.Seprators[sub]);
		//		else
		//			nperl[(int)sub] = list.CountStuNumPerLevelPerSubject(sub, Program.AllFullScore, Program.Seprators[sub]);
		//		string tmp___ = "";
		//		for (var index = 1; index < nperl[(int)sub].Length; index++)
		//		{

		//			int xXXx = nperl[(int)sub][index];
		//			tmp___ += $"{xXXx.ToString()} , ";
		//		}

		//		testmsg += $"{sub}\t{tmp___}\r\n";
		//	}

		//	//var cpy = new float[nperl[(int)NfSubjects.Zh].Length-1];
		//	int cnt_of_all = list.Count;
		//	//for (var index = 0; index < cpy.Length; index++)
		//	//{
		//	//	cpy[index] = (float)nperl[(int)NfSubjects.Zh][index+1] / cnt_of_all;
		//	//}

		//	//MessageBox.Show(testmsg+"\r\n"+ $"{cpy.FormatCol()}\r\nCount:{cnt_of_all}");
		//	//pie1.Name = "等级分布示意图";
		//	//pie1.ChartTitle = "等级分布示意图";
		//	//ChartGen.GenPieChart(pie1,LevelEx.GetOrders_ExtraIncluded_().ToObjectArray(),cpy.ToObjectArray(), "等级分布示意图");
		//	for (NfSubjects sub = NfSubjects.Zh; sub <= NfSubjects.All; sub++)
		//	{
		//		var cpy_sub = new float[nperl[(int)sub].Length - 1];
		//		for (var index = 0; index < cpy_sub.Length; index++)
		//		{
		//			cpy_sub[index] = (float)nperl[(int)sub][index + 1] / cnt_of_all;
		//		}
		//		IChartShape pie = ws.Shapes.AddChart();
		//		pie.Name = $"{sub.Name()}学科等级分布示意图";
		//		pie.ChartTitle = pie.Name;
		//		ChartGen.GenPieChart(pie, LevelEx.GetOrders_ExtraIncluded_().ToObjectArray(), cpy_sub.ToObjectArray(), pie.Name);
		//	}
		//	/////////////////////////////////////////////////
		//	xls.Save(pathWithoutLine + "\\" + mname + (v2007 ? ".xlsx" : ".xls"));
		//	wb.Close();
		//	ip.Dispose();
		//}
		public static float AllFullScore
		{
			get => FullScore[NfSubjects.Zh] + FullScore[NfSubjects.Zh] + FullScore[NfSubjects.Zh] + FullScore[NfSubjects.M] +
				   FullScore[NfSubjects.En] + FullScore[NfSubjects.P] + FullScore[NfSubjects.C] + FullScore[NfSubjects.Po] +
				   FullScore[NfSubjects.H] + FullScore[NfSubjects.G] + FullScore[NfSubjects.B];
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="IsControlled"></param>
		/// <returns>Isshowed</returns>
		public static bool ShowReadme(bool IsControlled)
		{
			if (File.Exists("Data\\ShowReadme"))
			{
				showReadme = true;
			}
			else
			{
				showReadme = false;
			}
			var rm = new System.ComponentModel.ComponentResourceManager(typeof(Resources));
			if (IsControlled)
			{
				if (IsShowReadme)
				{
					var r = new WebWindow(rm.GetString("ReadmeHTML"), true).ShowDialog();
					if (r == DialogResult.Yes)
						try
						{
							File.Delete("Data\\ShowReadme");
						}
						catch
						{
							if (DebugEnabled)
								MessageBox.Show("应用程序内部错误", "操作失败");
						}
					else if (r == DialogResult.No)
						try
						{
							File.Create("Data\\ShowReadme").Close();
						}
						catch
						{
							if (DebugEnabled)
								MessageBox.Show("应用程序内部错误", "操作失败");
						}

					return true;
				}
				else return false;
			}
			else
			{
				new WebWindow(rm.GetString("ReadmeHTML"), false).ShowDialog();
				return true;
			}


		}
		public static string FormatCol<T>(this IEnumerable<T> li, string spr = " , ", Func<T, string> cast = null)
		{
			if (li == null)
				return "";
			string ret = "";
			var array = li as T[] ?? li.ToArray();
			if (cast == null)
			{

				for (int i = 0; i < array.Length; i++)
				{
					ret += $"{array[i]}{((i == array.Length - 1) ? "" : spr)}";
				}
			}
			else
			{
				for (int i = 0; i < array.Length; i++)
				{
					ret += $"{cast(array[i])}{((i == array.Length - 1) ? "" : spr)}";
				}
			}

			return ret;
		}
		public static void UpdateDataCache()
		{
			suicache.Item2 = true;
		}
		private static (float, bool) suicache = (float.NegativeInfinity, true);//item2:Update Require;
		public static float ScoreUnionIndicator
		{
			get
			{
				if (suicache.Item2)
				{
					suicache.Item1 = FullScore[NfSubjects.Zh] * FullScore[NfSubjects.Zh] * FullScore[NfSubjects.Zh] * FullScore[NfSubjects.M] *
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
		public static string Title { get => title; set => title = value; }
		public static string ClassName { get => className; set => className = value; }
		public static string Author { get => author; set => author = value; }
		public static Dictionary<NfSubjects, Dictionary<Level, float>> Seprators { get => seprators; set => seprators = value; }
		public static bool IsShowReadme { get => showReadme; }

		public static ExcelWindow ExcelWindow;
		private static string log = "!Application Log!\r\n";
		private static LogWindow LogWindow;
		private static MainForm frm;
		private static string pptfile = "";
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
