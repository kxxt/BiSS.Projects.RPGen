using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using Newtonsoft.Json;
using RsWork.UI.Windows;

namespace BiSS.Projects.RPGen.Windows
{
	public partial class MainForm : MetroForm
	{
		public MainForm()
		{
			InitializeComponent();
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
			//MessageBox.Show(Application.StartupPath + @"\Web\loading.html");
			//new IntroductionWindow().Show();
		}

		private void metroTile3_Click(object sender, EventArgs e)
		{
			new SettingsWindiow().ShowDialog();
		}

		private void metroTile5_Click(object sender, EventArgs e)
		{
			Process.Start("https://github.com/kxxt/BiSS.Projects.RPGen");
		}

		private void metroTile6_Click(object sender, EventArgs e)
		{
			new AboutWindow().Show();
		}

		private void metroTile7_Click(object sender, EventArgs e)
		{
			new ModernDialogN("提示", "此版本无自动更新功能,如有需要请前往GitHub下载本程序.","zh-cn",Color.Coral,Color.Chocolate,Color.Tomato,Color.DarkSalmon).ShowDialog();
		}

		private void statusTitleLabel_Click(object sender, EventArgs e)
		{
			Program.ShowLogWindow();
		}
	}
}
