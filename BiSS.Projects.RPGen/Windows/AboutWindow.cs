using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace BiSS.Projects.RPGen.Windows
{
	public partial class AboutWindow : MetroForm
	{
		public AboutWindow()
		{
			InitializeComponent();
		}

		private void metroButton1_Click(object sender, EventArgs e)
		{
			this.Visible=false;
		}

		private void metroButton3_Click(object sender, EventArgs e)
		{
			Process.Start("https://github.com/kxxt/BiSS.Projects.RPGen");
		}

		private void metroButton2_Click(object sender, EventArgs e)
		{
			Process.Start("mailto:bbsadmin@bbs.rswork.heliohost.org");
		}

		private void metroButton4_Click(object sender, EventArgs e)
		{
			var msgb = new MetroMessageBox
			{
				Text = "Wire:@rsworktech",
				MaximizeBox = false,
				MinimizeBox = false,
				Height=100,
				TopMost = true,
				Theme = MetroThemeStyle.Dark,
				Resizable = false
				
			};
			msgb.ShowDialog();
		}
	}
}
