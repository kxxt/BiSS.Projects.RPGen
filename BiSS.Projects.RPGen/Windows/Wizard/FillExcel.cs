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
	public partial class FillExcel : DialogWindows10
	{
		public FillExcel()
		{
			InitializeComponent();
		}
		/*您可以像编辑Excel文档一样编辑它,同时您也可以从源成绩单中复制相关数据到本表中,
		   填写完毕后请关闭窗口,数据将自动保存.*/
		private void sfButton1_Click(object sender, EventArgs e)
		{
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
				dlg.subtitle.Text = "请检查以下问题是否存在,修复并重试:\r\n" +
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
			MessageBox.Show("单击确定以继续...",WriteObject(ew.spreadsheet1.ActiveSheet));
			Log("Loop Begin");
			while (ew.Export() == null)
			{
				Log("Looping...");
				if (ew.Error)
					break;
			}
			if(!ew.Error)
			{
				var data = ew.Export();
				Program.Data.FillExcel = data;
				MessageBox.Show(JsonConvert.SerializeObject(data[0]),"测试数据");
				this.Hide();
				var fmt=new FormatWindow();
				fmt.FormClosed += (s, args) => this.Close();
				fmt.Show();
			}
			else
			{
				return;
			}
			
			//Process.Start($"Temp\\{Program.XlsFile}");
		}
	}
}
