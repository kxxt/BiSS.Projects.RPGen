using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BiSS.Projects.RPGen.Program;

namespace BiSS.Projects.RPGen.Windows.Wizard
{
	public partial class SettingWindow : DialogWindows10
	{
		public SettingWindow()
		{
			InitializeComponent();
			//debugEnabledToggle.Checked = Program.DebugEnabled;

		}

		private void windows10Btn21_Click(object sender, EventArgs e)
		{
			try
			{
				File.Create("Data\\ShowReadme").Close();
			}
			catch
			{
				if (DebugEnabled)
					MessageBox.Show("应用程序内部错误", "操作失败");
			}
			System.Diagnostics.Process.Start(Application.ExecutablePath);
			Application.Exit();
		}

		//private void debugEnabledToggle_CheckedChanged(object sender, EventArgs e)
		//{
		//	Program.DebugEnabled = debugEnabledToggle.Checked;
		//	if (!debugEnabledToggle.Checked)
		//		return;

		//	var r = MessageBox.Show("调试模式可能导致应用程序不稳定 , 是否继续 ?", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
		//	if (r == DialogResult.No)
		//	{
		//		Program.DebugEnabled = false;
		//		debugEnabledToggle.Checked = false;
		//	}
		//	else
		//	{
		//		Program.DebugEnabled = true;
		//		debugEnabledToggle.Checked = true;
		//	}

		//	if (Program.DebugEnabled)
		//	{
		//		new DebugWindiow().Show();
		//	}
		//}

		private void windows10Btn22_Click(object sender, EventArgs e)
		{
			Program.ShowLogWindow();
		}

		private void windows10Btn23_Click(object sender, EventArgs e)
		{
			if (!Program.DebugEnabled)
			{
				var r = MessageBox.Show("调试模式可能导致应用程序不稳定 , 是否继续 ?", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
				if (r == DialogResult.Yes)
				{
					Program.DebugEnabled = true;
				}
			}
			else
			{
				Program.DebugEnabled = false;
			}

			if (DebugEnabled)
				new DebugWindiow().ShowDialog();
		}
	}
}
