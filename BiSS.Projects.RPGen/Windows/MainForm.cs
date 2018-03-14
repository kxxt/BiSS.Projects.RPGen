using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiSS.Projects.RPGen.Debug;
using BiSS.Projects.RPGen.Op;
using BiSS.Projects.RPGen.Structure;
using BiSS.Projects.RPGen.Windows.Wizard;
using MetroFramework.Forms;
using Newtonsoft.Json;
using RsWork.Functions.Log;
using RsWork.UI.Windows;
using Syncfusion.Data.Extensions;
using Syncfusion.Presentation;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.XlsIO;
using static BiSS.Projects.RPGen.Program;
using ExcelChartType = Syncfusion.XlsIO.ExcelChartType;

namespace BiSS.Projects.RPGen.Windows
{
	public partial class MainForm : MetroForm
	{
		public MainForm()
		{
			InitializeComponent();
			if (!Program.DebugEnabled)
			{
				modernButton2.Visible = false;
				modernButton1.Visible = false;
			}
				
			Program.DebugEnabledChanged +=new EventHandler<DebugEnabledChangedEventArgs>(this.DebugEnabledChanged); 
		}

		private void DebugEnabledChanged(object sender, DebugEnabledChangedEventArgs e)
		{
			modernButton2.Visible = e.Value;
			modernButton1.Visible = e.Value;
		}
		private void closebtn_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void minbtn_Click(object sender, System.EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void modernButton2_Click(object sender, System.EventArgs e)
		{
			Log($"Test#1 Started @{DateTime.Now.ToString("h:mm:ss tt zz")}.");
			//MessageBox.Show(Application.StartupPath + @"\Web\loading.html");
			//new IntroductionWindow().Show();
			var rand = new Random();
			float r = 0f;
			int rr = 0;
			var st = new Structure.ScoreTable(new Dictionary<string, ScoreModel>(),new InputDataIndicator());
			var gw = new GridWindow("测试成绩数据");
			NameGen ng=new NameGen();
			for (int i = 1; i <= 100; i++)
			{
				
				r =  rand.Next(0,1500)/10f;
				rr = rand.Next(1,100);
				st.Add(ng.Rand2(),new ScoreModel(rr,rr,r,r,r,r,r,r,r,r,r,rr,rr,rr,rr,rr,rr,rr,rr,rr,rr,rr,rr,rr,rr,rr,rr,rr,rr));
			}
			//st.Add(5001.ToString(), new ScoreModel(rr,rr,r, r, r, r, r, r, r, r, r, rr, rr, rr, rr, rr, rr, rr, rr, rr));
			r = rand.Next(1, 100);
			//MessageBox.Show($"id:{r},zh:{st.Score[r.ToString()].Zh}", "Finished");
			var ex=st.Export();
			foreach (var i in ex)
			{
				gw.DisplayObjectBindingSource.Add(i);
			}
			gw.Show();

			//st.CalcAverage();
		}

		private void metroTile3_Click(object sender, EventArgs e)
		{
			FlashTimer.Stop();
		}

		private void metroTile5_Click(object sender, EventArgs e)
		{
			Log("Rdt => GitHub");
			Process.Start("https://github.com/kxxt/BiSS.Projects.RPGen");
		}

		private void metroTile6_Click(object sender, EventArgs e)
		{
			Log("ShowAboutWindow.");
			new AboutWindow().Show();
		}

		private void metroTile7_Click(object sender, EventArgs e)
		{
			new ModernDialogN("提示", "此版本无自动更新功能,如有需要请前往GitHub下载本程序.","zh-cn",Color.Coral,Color.Chocolate,Color.Tomato,Color.DarkSalmon).ShowDialog();
		}

		private void statusTitleLabel_DoubleClick(object sender, EventArgs e)
		{
			Program.ShowLogWindow();
		}
        public void UpdateStatus(string str)
        {
            this.status_Textbox.Text = str;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
			if(Program.RaceMode)
				new WarningWindow().ShowDialog();
			this.Activate();
			
        }

		private void metroTile1_Click(object sender, EventArgs e)
		{
			new SettingsWindiow().ShowDialog();
		}

		private void FlashTimer_Tick(object sender, EventArgs e)
		{
			#region TileFlash

			this.metroTile3.BackColor = (this.metroTile3.BackColor == Color.FromArgb(235, 73, 16)
				? Color.FromArgb(234, 0, 94)
				: Color.FromArgb(235, 73, 16));


			#endregion
		}

		private void Tile_XLS_Click(object sender, EventArgs e)
		{
			//try
			//{
			//	MessageBox.Show("将选择表格文件保存位置.\r\n" +
			//	                "文件保存后应用程序将启动Excel完成表单填写ヾ(￣▽￣)Bye~Bye~." +
			//	                "\r\n请在填写完成后返回本程序继续操作.(*≧︶≦))(￣▽￣* )ゞ", "Hint");
			//	var result = saveFileDialog_XLSX.ShowDialog();
			//	if (!(result == DialogResult.OK || result == DialogResult.Yes))
			//	{
			//		MessageBox.Show("操作已取消.＞﹏＜","取消");
			//		return;
			//	}
			//	Log($"XLSX Output Path:{saveFileDialog_XLSX.FileName}");
			//	File.Copy(Program.DataDir + "TEMPLATE.XLSX", saveFileDialog_XLSX.FileName,true);
				
			//	Process.Start(saveFileDialog_XLSX.FileName);
			//}
			//catch (Exception exception)
			//{
			//	Log(Logger.GetExceptionInfo(exception));
			//	MessageBox.Show("文件操作失败!\r\n请保证程序有足够的权限在文件系统上操作文件,然后重试","运行时错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
			//}
			var ew=
				 new ExcelWindow("填写成绩单 (Hint:可以从原始成绩单中复制)");
			Random rd = new Random();
			var name = $"Temp\\{rd.Next()}.xlsx";
			try
			{
				
				Directory.CreateDirectory("Temp");
				File.Copy("Data\\tmp.xlsx", name);
			}
			catch (Exception ce)
			{
				Log(Logger.GetExceptionInfo(ce));
				MessageBox.Show("文件操作失败!\r\n请保证程序有足够的权限在文件系统上操作文件,然后重试","运行时错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			ew.spreadsheet1.Open(name);
			ew.FormClosing +=new FormClosingEventHandler((o,b)=>{ew.spreadsheet1.Save();try{ew.Dispose();}catch{}});
			ew.Show();
		}

		private void metroTile2_Click(object sender, EventArgs e)
		{
			openFileDialog_XLSX.ShowDialog();
		}

		private void modernButton1_Click(object sender, EventArgs e)
		{
			Spire.Xls.Workbook wb;
			Spire.Xls.Worksheet ws =null;
			
				wb = new Spire.Xls.Workbook();
				wb.LoadFromFile("Data\\Test\\c5.xlsx");
				wb.ActiveSheetIndex = 0 + 1;
				ws = wb.ActiveSheet;
			
			//var dgv=new DataGridView();
			//dgv.Dock = DockStyle.Fill;
			//dgv.DoubleBuffered(true);
			//try { dgv.DataSource = ws.ExportDataTable(); } catch(Exception ex) { Log(Logger.GetExceptionInfo(ex));}
			
			
			//Form frm = new Form();
			//frm.Controls.Add(dgv);
			//frm.ShowDialog();
			ScoreTable st=new ScoreTable(new Dictionary<string, ScoreModel>(),new InputDataIndicator() );
			var data= ws.ExportDataTable();
			//for (int i = 0; i < data.Rows.Count; i++)
			//{
			//	data.Rows[i][1] = Convert.ToInt32(data.Rows[i][1].ToString());
			//}
			GridEditWindow gew=new GridEditWindow("编辑成绩");
			gew.DataGridView.DataSource = data;
			gew.Show();
		}

		private void metroTile4_Click(object sender, EventArgs e)
		{
			new IOFormatWindow().ShowDialog();
		}

		private void modernButton3_Click(object sender, EventArgs e)
		{
			Log("%TEST%");
			var ew = new ExcelWindow("Test#3");
			ew.spreadsheet1.Open("Data\\Test\\c5.xlsx");
			ew.ShowDialog();
			//ExcelOperator2 ex=new ExcelOperator2(ew.spreadsheet1);
			var s=ew.spreadsheet1.ActiveSheet;
			var l = s.ExportDataTable(s.UsedRange, ExcelExportDataTableOptions.ColumnNames|ExcelExportDataTableOptions.ComputedFormulaValues);
			//MessageBox.Show($"{l.Rows[0][0].ToString()}");
			//ScoreTable st=new ScoreTable(new Dictionary<string, ScoreModel>(),new InputDataIndicator() );
			List<ScoreModel> li=new List<ScoreModel>();
				for (int j = 0; j < l.Rows.Count; j++)
				{
					
					ScoreModel sm=new ScoreModel();
					for (int i = 0; i < l.Columns.Count; i++)
					{
						switch (i)
						{
						case 0:
							sm.Name = l.Rows[j][i].ToString();
							break;
						case 1:
							sm.Id = Int32.Parse(l.Rows[j][i].ToString());
							break;
						case 2:
							sm.SumRank = Int32.Parse(l.Rows[j][i].ToString());
							break;
						case 3:
							sm.SumGradeRank= Int32.Parse(l.Rows[j][i].ToString());
							break;
						case 4:
							sm.Zh = Single.Parse(l.Rows[j][i].ToString());
							break;
						case 5:
							sm.ZhRank=Int32.Parse(l.Rows[j][i].ToString());
							break;
							case 6:
								sm.ZhGradeRank =int.Parse(l.Rows[j][i].ToString());
								break;
							case 7:
								sm.M =float.Parse(l.Rows[j][i].ToString());
								break;
							case 8:
								sm.MRank =int.Parse(l.Rows[j][i].ToString());
								break;
							case 9:
								sm.MGradeRank =int.Parse(l.Rows[j][i].ToString());
								break;
							case 10:
								sm.En =float.Parse(l.Rows[j][i].ToString());
								break;
							case 11:
								sm.EnRank =int.Parse(l.Rows[j][i].ToString());
								break;
							case 12:
								sm.EnGradeRank =int.Parse(l.Rows[j][i].ToString());
								break;
							case 13:
								sm.P =float.Parse(l.Rows[j][i].ToString());
								break;
							case 14:
								sm.PRank =int.Parse(l.Rows[j][i].ToString());
								break;
							case 15:
								sm.PGradeRank =int.Parse(l.Rows[j][i].ToString());
								break;
							case 16:
								sm.C =float.Parse(l.Rows[j][i].ToString());
								break;
							case 17:
								sm.CRank =int.Parse(l.Rows[j][i].ToString());
								break;
							case 18:
								sm.CGradeRank =int.Parse(l.Rows[j][i].ToString());
								break;
							case 19:
								sm.Po =float.Parse(l.Rows[j][i].ToString());
								break;
							case 20:
								sm.PoRank =Int32.Parse(l.Rows[j][i].ToString());
								break;
							case 21:
								sm.PoGradeRank =Int32.Parse(l.Rows[j][i].ToString());
								break;
							case 22:
								sm.H =float.Parse(l.Rows[j][i].ToString());
								break;
							case 23:
								sm.HRank =int.Parse(l.Rows[j][i].ToString());
								break;
							case 24:
								sm.HGradeRank =int.Parse(l.Rows[j][i].ToString());
								break;
							case 25:
								sm.G =float.Parse(l.Rows[j][i].ToString());
								break;
							case 26:
								sm.GRank =int.Parse(l.Rows[j][i].ToString());
								break;
							case 27:
								sm.GGradeRank =int.Parse(l.Rows[j][i].ToString());
								break;
							case 28:
								sm.B =float.Parse(l.Rows[j][i].ToString());
								break;
							case 29:
								sm.BRank =int.Parse(l.Rows[j][i].ToString());
								break;
							case 30:
								sm.BGradeRank =int.Parse(l.Rows[j][i].ToString());
								break;
						default:throw new NotImplementedException();
							break;
						}
					}
					li.Add(sm);
					//MessageBox.Show($"%C# {name}%=>%JSON%:\r\n{sm.ToString()}");
			}
			IList<(NfSubjects, float)> aveList = Analyzer.Average(li);
			//BindingList<(NfSubjects, float)> aveBindingList = Analyzer.Average(li);//todo;
			IList<(NfSubjects, float)> sumList = Analyzer.Sum(li);
			IList<(NfSubjects, float[])> modeList = Analyzer.Mode(li);
			IList<(NfSubjects, double)> midList = Analyzer.Mid(li);
			Log("Average:\r\n"+string.Join(",",aveList));
			Log("Sum:\r\n" + string.Join(",", sumList));
			Log("Mode:");
			foreach (var mode in modeList)
			{
				Log($"{mode.Item1.ToString()}:{string.Join(",",mode.Item2)}");
			}
			//Log("Mode:\r\n" + string.Join(",",modeList));
			Log("Mid:\r\n" + string.Join(",",midList));
			//MessageBox.Show(aveList[0].Item2.ToString());
			DataVisualization dv=new DataVisualization();
			dv.lDChartDataSourceBindingSource.DataSource = new LDChartDataSource(aveList);

			#region Data Convert:
			ChartSeries cs=new ChartSeries("%Title%");
			ChartDataBindModel cdbm = new ChartDataBindModel(aveList);
			ChartDataBindAxisLabelModel cdbalm= new ChartDataBindAxisLabelModel(aveList);
			cdbm.XName = "Item1";
			cdbalm.LabelName = "Item1";
			cdbm.YNames = new String[] {"Item2"};
			cs.SeriesModel = cdbm;
			dv.chartControl1.Series.Add(cs);
			dv.chartControl1.PrimaryXAxis.LabelsImpl = cdbalm;
			dv.chartControl2.Series.Add(cs);
			dv.chartControl2.PrimaryXAxis.LabelsImpl = cdbalm;
			dv.chartControl2.PrimaryYAxis.Range = new MinMaxInfo(0, 150, 100);
			#endregion

			dv.Show();

			//#region PPT Output

			//IPresentation ip = Presentation.Create();
			//IList<double> avelist_ppt=new List<double>();
			//foreach (var ii in aveList)
			//{
			//	avelist_ppt.Add(ii.Item2);
			//}
			//ISlide sl = ip.Slides.Add(SlideLayoutType.Blank);
			//IPresentationChart ct = sl.Shapes.AddChart(avelist_ppt, 5, 5, 100, 100);
			//Spire.Presentation.Presentation ppt =new Spire.Presentation.Presentation(File.Open($"{new Random().Next()}.pptx",FileMode.Create,FileAccess.ReadWrite),FileFormat.Pptx2010);
			//var cts = ppt.Slides[0].Shapes.AppendChart(ChartType.Column3D,new RectangleF(5,5,200,200));

			//foreach (var ave in avelist_ppt)
			//{
			//	//cts.Series.Append(ave);
			//	cts.Series[0].Values.Add(ave);
			//}

			//ip.Save($"{new Random().Next()}.pptx");
			//#endregion

			#region ExcelChart

			ExcelEngine ee=new ExcelEngine();
			IApplication xls = ee.Excel;
			xls.DefaultVersion = Syncfusion.XlsIO.ExcelVersion.Excel2016;
			IWorkbook wb= xls.Workbooks.Open("Data\\Test\\c5.xlsx", ExcelOpenType.Automatic);
			IWorksheet ws = wb.Worksheets.Create("Chart");
			IChartShape chart = ws.Charts.Add();
			/////////////////////////////////////////////////////
			//IChartSerie serie = chart.Series.Add(Syncfusion.XlsIO.ExcelChartType.Column_Clustered);
			//chart.ChartType = Syncfusion.XlsIO.ExcelChartType.Column_Clustered;
			IList<string> xave=new List<string>();
			IList<object> yave = new List<object>();
			int allavei=Int32.MaxValue,allmidi=Int32.MaxValue;
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
			ChartGen.GenChart(chart,xave.ToArray(),yave.ToArray(),"平均分",ExcelChartType.Column_Clustered);
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
			ChartGen.GenChart(chart,xmid.ToArray(),ymid.ToArray(),"中位分",ExcelChartType.Column_Clustered);
			//{{{{{{{{{{{{{{
			xave.RemoveAt(allavei);
			yave.RemoveAt(allavei);
			xmid.RemoveAt(allmidi);
			ymid.RemoveAt(allmidi);
			IChartShape leida = ws.Shapes.AddChart();
			
			ChartGen.GenChart(leida, xave.ToArray(), yave.ToArray(), "平均分", ExcelChartType.Radar);
			ChartGen.GenChart(leida, xmid.ToArray(), ymid.ToArray(), "中位分", ExcelChartType.Radar);
			leida.Name = "学科成绩分布1";
			leida.ChartTitle= "学科成绩分布1"; 
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
			var ordered =li.OrderBy(pp=>pp.Sum);
			ChartGen.GenChart(ws.Shapes.AddChart(), ordered.Select(sm=>(object)(sm.Name)).ToArray(), ordered.Select(sm => (object)(sm.Sum ?? 0)).ToArray(), "总分", ExcelChartType.Column_3D);
			//seriemid.EnteredDirectlyValues = ymid.ToArray();
			//seriemid.Name = "中位分";
			//seriemid.EnteredDirectlyCategoryLabels = xmid.ToArray();
			/////////////////////////////////////////////////
			xls.Save("output.xlsx");
			wb.Close();
			ee.Dispose();
			#endregion
		}

		private void modernButton4_Click(object sender, EventArgs e)
		{
			new FillExcel().ShowDialog();
		}

		private void modernButton5_Click(object sender, EventArgs e)
		{
			new FormatWindow().Show();
		}

		private void modernButton6_Click(object sender, EventArgs e)
		{
			var w = new Windows.Busy.BusyWindow();
			w.Worker.DoWork += (s,args)=>{
				for (int i = 1; i <= 10; i++)
				{
					MessageBox.Show($"#Test id={i}");
					Thread.Sleep(500);
				}
			};
			//Thread.Sleep();
			w.ShowDialog();
		}
	}
}
