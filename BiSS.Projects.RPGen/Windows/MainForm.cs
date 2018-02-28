using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using BiSS.Projects.RPGen.Structure;
using MetroFramework.Forms;
using Newtonsoft.Json;
using RsWork.Functions.Log;
using RsWork.UI.Windows;
using static BiSS.Projects.RPGen.Program;
namespace BiSS.Projects.RPGen.Windows
{
	public partial class MainForm : MetroForm
	{
		public MainForm()
		{
			InitializeComponent();
			if (!Program.DebugEnabled)
				modernButton2.Visible = false;
			Program.DebugEnabledChanged +=new EventHandler<DebugEnabledChangedEventArgs>(this.DebugEnabledChanged); 
		}

		private void DebugEnabledChanged(object sender, DebugEnabledChangedEventArgs e)
		{
			modernButton2.Visible = e.Value;
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
			var st = new Structure.ScoreTable(new Dictionary<string, ScoreModel>(), new CalcResultContainer(),
				new InputDataIndicator());
			for (int i = 0; i <= 5000; i++)
			{
				r = 150*(float )rand.NextDouble();
				rr = rand.Next();
				st.Add(i.ToString(),new ScoreModel(r,r,r,r,r,r,r,r,r,rr,rr,rr,rr,rr,rr,rr,rr,rr));
			}
			r = rand.Next(0, 5000);
			MessageBox.Show($"id:{r},zh:{st.Score[r.ToString()].Zh}", "Finished");
			st.CalcAverageTest();
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
			try
			{
				MessageBox.Show("将选择表格文件保存位置.\r\n" +
				                "文件保存后应用程序将启动Excel完成表单填写ヾ(￣▽￣)Bye~Bye~." +
				                "\r\n请在填写完成后返回本程序继续操作.(*≧︶≦))(￣▽￣* )ゞ", "Hint");
				var result = saveFileDialog_XLSX.ShowDialog();
				if (!(result == DialogResult.OK || result == DialogResult.Yes))
				{
					MessageBox.Show("操作已取消.＞﹏＜","取消");
					return;
				}
				Log($"XLSX Output Path:{saveFileDialog_XLSX.FileName}");
				File.Copy(Program.DataDir + "TEMPLATE.XLSX", saveFileDialog_XLSX.FileName,true);
				
				Process.Start(saveFileDialog_XLSX.FileName);
			}
			catch (Exception exception)
			{
				Log(Logger.GetExceptionInfo(exception));
				MessageBox.Show("文件操作失败!\r\n请保证程序有足够的权限在文件系统上操作文件,然后重试","运行时错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}

		private void metroTile2_Click(object sender, EventArgs e)
		{
			openFileDialog_XLSX.ShowDialog();
		}
	}
}
