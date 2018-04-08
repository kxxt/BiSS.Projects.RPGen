﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiSS.Projects.RPGen.Structure;
using BiSS.Projects.RPGen.Windows.Wizard;
using RsWork.Functions.Log;
using RsWork.UI.Windows;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;
using Syncfusion.XlsIO;
using MetroForm = MetroFramework.Forms.MetroForm;

namespace BiSS.Projects.RPGen.Windows
{
	public partial class ExcelWindow : SfForm
	{
		public ExcelWindow(string title)
		{
			InitializeComponent();
			DoubleBuffered = true;
			spreadsheet1.DoubleBuffered(true);
			this.Text = title;


		}

		public IList<ScoreModel> Export()
		{
			Error = false;
			var s = spreadsheet1.ActiveSheet;
			var l = s.ExportDataTable(s.UsedRange, ExcelExportDataTableOptions.ColumnNames | ExcelExportDataTableOptions.ComputedFormulaValues);

			//MessageBox.Show($"{l.Rows[0][0].ToString()}");
			//ScoreTable st=new ScoreTable(new Dictionary<string, ScoreModel>(),new InputDataIndicator() );
			List<ScoreModel> li = null;
			try
			{
				li = new List<ScoreModel>();
				for (int j = 0; j < l.Rows.Count; j++)
				{
					if (Program.DebugEnabled)
						MessageBox.Show($"j:{j}");
					ScoreModel sm = new ScoreModel();
					try
					{
						for (int i = 0; i < l.Columns.Count; i++)
						{
							switch (i)
							{
								case 0:
									if (Program.DebugEnabled)
										MessageBox.Show($"i,j:{i},{j}\r\nVALUE [NAME]:" + l.Rows[j][i].ToString());
									if (String.IsNullOrWhiteSpace(l.Rows[j][i].ToString()))
									{
										if (j != 1)
											goto Dest;
										else
										{
											throw new Exception();
										}
									}

									sm.Name = l.Rows[j][i].ToString();
									break;
								case 1:
									if (Program.DebugEnabled)
										MessageBox.Show($"i, j:{i},{j}\r\nVALUE [ID]:" + l.Rows[j][i].ToString());
									sm.Id = Int32.Parse(l.Rows[j][i].ToString().Trim());
									break;
								case 2:
									sm.SumRank = Int32.Parse(l.Rows[j][i].ToString());
									break;
								case 3:
									sm.SumGradeRank = Int32.Parse(l.Rows[j][i].ToString());
									break;
								case 4:
									sm.Zh = Single.Parse(l.Rows[j][i].ToString());
									break;
								case 5:
									sm.ZhRank = Int32.Parse(l.Rows[j][i].ToString());
									break;
								case 6:
									sm.ZhGradeRank = int.Parse(l.Rows[j][i].ToString());
									break;
								case 7:
									sm.M = float.Parse(l.Rows[j][i].ToString());
									break;
								case 8:
									sm.MRank = int.Parse(l.Rows[j][i].ToString());
									break;
								case 9:
									sm.MGradeRank = int.Parse(l.Rows[j][i].ToString());
									break;
								case 10:
									sm.En = float.Parse(l.Rows[j][i].ToString());
									break;
								case 11:
									sm.EnRank = int.Parse(l.Rows[j][i].ToString());
									break;
								case 12:
									sm.EnGradeRank = int.Parse(l.Rows[j][i].ToString());
									break;
								case 13:
									sm.P = float.Parse(l.Rows[j][i].ToString());
									break;
								case 14:
									sm.PRank = int.Parse(l.Rows[j][i].ToString());
									break;
								case 15:
									sm.PGradeRank = int.Parse(l.Rows[j][i].ToString());
									break;
								case 16:
									sm.C = float.Parse(l.Rows[j][i].ToString());
									break;
								case 17:
									sm.CRank = int.Parse(l.Rows[j][i].ToString());
									break;
								case 18:
									sm.CGradeRank = int.Parse(l.Rows[j][i].ToString());
									break;
								case 19:
									sm.Po = float.Parse(l.Rows[j][i].ToString());
									break;
								case 20:
									sm.PoRank = Int32.Parse(l.Rows[j][i].ToString());
									break;
								case 21:
									sm.PoGradeRank = Int32.Parse(l.Rows[j][i].ToString());
									break;
								case 22:
									sm.H = float.Parse(l.Rows[j][i].ToString());
									break;
								case 23:
									sm.HRank = int.Parse(l.Rows[j][i].ToString());
									break;
								case 24:
									sm.HGradeRank = int.Parse(l.Rows[j][i].ToString());
									break;
								case 25:
									sm.G = float.Parse(l.Rows[j][i].ToString());
									break;
								case 26:
									sm.GRank = int.Parse(l.Rows[j][i].ToString());
									break;
								case 27:
									sm.GGradeRank = int.Parse(l.Rows[j][i].ToString());
									break;
								case 28:
									sm.B = float.Parse(l.Rows[j][i].ToString());
									break;
								case 29:
									sm.BRank = int.Parse(l.Rows[j][i].ToString());
									break;
								case 30:
									sm.BGradeRank = int.Parse(l.Rows[j][i].ToString());
									break;
								default:
									throw new NotImplementedException();
									break;
							}
						}
					}
					catch (FormatException ex)
					{

						if (KillingError != true)
						{
							KillingError = true;

						}
						else
							return null;

						var r = MessageBox.Show($"表格中有错误数据,可能是数字中混入了字母,\r\n或信息输入不正确,请检查并改正.{(Program.DebugEnabled ? $"\r\n{Logger.GetExceptionInfo(ex)}" : "")}\r\n单击 [ 确定 ] 以返回修改 .\r\n单击 [ 取消 ] 将退出向导 .", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
						//DialogWindows10 dlg = new DialogWindows10();
						//dlg.title.Text = "错误";
						//dlg.Text = "错误";
						//dlg.subTitle.Text = $"表格中有错误数据,可能是数字中混入了字母,\r\n或信息输入不正确,请检查并改正.{(Program.DebugEnabled ? $"\r\n{Logger.GetExceptionInfo(ex)}" : "")}";
						//dlg.ShowDialog();
						if (r != DialogResult.OK)
						{
							Program.ExitGuide = true;
						}
					}
					Dest:
					li.Add(sm);
					//MessageBox.Show($"%C# {name}%=>%JSON%:\r\n{sm.ToString()}");
				}
			}
			catch (Exception e)
			{
				Error = true;
				//DialogWindows10 dlg = new DialogWindows10();
				//dlg.title.Text = "错误";
				//dlg.Text = "错误";
				//dlg.subTitle.Text = "表格中有错误数据,可能是数字中混入了字母,请检查并改正.";
				//dlg.ShowDialog();
				var r = MessageBox.Show($"表格中有错误数据,可能是数字中混入了字母,\r\n或信息输入不正确,请检查并改正.{(Program.DebugEnabled ? $"\r\n{Logger.GetExceptionInfo(e)}" : "")}\r\n单击 [ 确定 ] 以返回修改 .\r\n单击 [ 取消 ] 将退出向导 .", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
				if (r != DialogResult.OK)
				{
					Program.ExitGuide = true;
				}
				li = null;
			}

			return li;
		}

		private bool? error = null;
		private string fileName = "";

		public string FileName { get => this.fileName; }
		public bool? Error { get => this.error; set => this.error = value; }
		public bool KillingError { get; set; } = false;

		private void ExcelWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.spreadsheet1.SaveAs(FileName);

			if ((sender as ExcelWindow).Export() == null)
				e.Cancel = true;

		}

		private void sfButton1_Click(object sender, EventArgs e)
		{
			Random rd = new Random();
			if (FileName == "")
				fileName = $"Data\\Temp\\{rd.Next()}.xlsx";
			this.spreadsheet1.SaveAs(FileName);
		}
	}
}
