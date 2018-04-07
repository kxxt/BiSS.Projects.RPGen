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

namespace BiSS.Projects.RPGen.Windows.Wizard
{
	public partial class AppStartWindow : DialogWindows10
	{
		public AppStartWindow()
		{
			InitializeComponent();
		}

		private void metroTile2_Click(object sender, EventArgs e)
		{
			new Wizard.SettingWindow().ShowDialog();
		}

		private void metroTile1_Click(object sender, EventArgs e)
		{
			new WelcomeWindow().ShowDialog();
		}

		private void metroTile3_Click(object sender, EventArgs e)
		{
			Program.ShowReadme(false);
		}

		private void metroTile4_Click(object sender, EventArgs e)
		{
			var x = new DialogWindows10
			{
				Text = "更新失败"
			};
			x.title.Text = "更新失败";
			x.subTitle.Text = "本版本无自动更新功能 .";
			x.ShowDialog();

		}

		private void metroTile5_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start("Data\\example.mp4");
			}
			catch (FileNotFoundException)
			{
				MessageBox.Show("辅助视频文件未找到 .\r\n播放失败 !", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch
			{
				MessageBox.Show("辅助视频播放失败 .\r\n播放失败 !", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}

		private void FlashTimer_Tick(object sender, EventArgs e)
		{

		}

		private void AppStartWindow_Shown(object sender, EventArgs e)
		{
			this.Activate();
		}
	}
}
