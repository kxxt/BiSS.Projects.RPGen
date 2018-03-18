using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static BiSS.Projects.RPGen.Program;
using Syncfusion.WinForms.Controls;
using static BiSS.Projects.RPGen.Config.Config;
namespace BiSS.Projects.RPGen.Windows.Wizard
{
	public partial class FillExcel : DialogWindows10With1Btn
	{
		public FillExcel()
		{
			InitializeComponent();
		}
		/*您可以像编辑Excel文档一样编辑它,同时您也可以从源成绩单中复制相关数据到本表中,
		   填写完毕后请关闭窗口,数据将自动保存.*/
		private async void sfButton1_Click(object sender, EventArgs e)
		{
			Btn.Enabled = false;
			//if(Program.ExcelWindow.FileName=="")
			//	Program.ExcelWindow.spreadsheet1.Open("Data\\Test\\c5.xlsx");
			//else
			//	Program.ExcelWindow.spreadsheet1.Open(Program.ExcelWindow.FileName);
			//Program.ExcelWindow.ShowDialog();
			//MessageBox.Show($"Temp\\{Program.XlsFile}");
			try
			{
				File.Copy(@"Data\Test\c5.xlsx", Application.StartupPath + $"\\Temp\\{Program.XlsFile}", true);
			}
			catch(Exception)
			{
				var dlg = new DialogWindows10();
				dlg.title.Text = "应用程序内部错误";
				dlg.subTitle.Text = "请检查以下问题是否存在,修复并重试:\r\n" +
				                    "1. 应用程序不完整,请重新下载应用程序.\r\n" +
				                    "2. 应用程序没有在文件系统上操作文件的权限,请修改权限设置.\r\n" +
				                    "3. 如果以上均无问题,请联系应用程序开发者.";
				return;
			}
			var xls = new Process()
			{
				StartInfo =
				{
					FileName = $"Temp\\{Program.XlsFile}",
					
				},
			};
			xls.Start();
			xls.WaitForExit();
			ExcelWindow ew=new ExcelWindow("检查数据");
			ew.spreadsheet1.Open($"Temp\\{Program.XlsFile}");
			MessageBox.Show("单击确定以继续...\r\n您可能需要等待一段时间...",WriteObject(ew.spreadsheet1.ActiveSheet)??"提示");
			Log("Loop Begin");
			Busy.BusyWindow busy=new Busy.BusyWindow();
			//busy.Worker.DoWork += (___s___, ___args___) => {
			//	while (ew.Export() == null)
			//	{
			//		Log("Looping...");
			//		if (ew.Error.HasValue&&ew.Error.Value)
			//			break;
			//	}
			//};
			//busy.ShowDialog();
			await Task.Run(() => {
				while (ew.Export() == null)
				{
					Log("Looping...");
					if (ew.Error.HasValue && ew.Error.Value)
						break;
				}
			});
			//while (ew.Export() == null)
			//{
			//	Log("Looping...");
			//	if (ew.Error.HasValue&&ew.Error.Value)
			//		break;
			//}
			if (ew.Error.HasValue&&!ew.Error.Value)
			{
				var data = ew.Export();
				Program.Data.X = data;
				MessageBox.Show(JsonConvert.SerializeObject(data[0]),"测试数据");
				this.Hide();
				var fmt=new FormatWindow();
				fmt.FormClosed += (s, args) =>
				{
					this.Btn.Enabled = true;
					this.Close();
				};
				fmt.Show();
			}
			else
			{
				MessageBox.Show("Error");
				Btn.Enabled = true;
				return;
			}
			
			//Process.Start($"Temp\\{Program.XlsFile}");

		}

		private void Btn_Click(object sender, EventArgs e)
		{
			sfButton1_Click(this.Btn,null);
		}
	}
}
