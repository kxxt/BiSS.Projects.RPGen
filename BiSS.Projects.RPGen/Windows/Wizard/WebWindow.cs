using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiSS.Projects.RPGen.Windows.Wizard
{
	public partial class WebWindow : DialogWindows10
	{
		private DialogResult ret;
		public WebWindow(string html, bool showToggle)
		{
			InitializeComponent();

			ret = DialogResult.Yes;
			this.webBrowser1.DocumentText = html;
			metroToggle1.Checked = Program.IsShowReadme;
			if (!showToggle)
			{
				metroToggle1.Visible = false;
				label1.Visible = false;
			}
		}

		private void windows10Btn11_Click(object sender, EventArgs e)
		{
			DialogResult = ret;
			this.Close();
		}

		private void windows10Btn21_Click(object sender, EventArgs e)
		{

			Application.Exit();
		}

		private void metroToggle1_CheckedChanged(object sender, EventArgs e)
		{
			this.ret = metroToggle1.Checked ? DialogResult.Yes : DialogResult.No;
		}

		private void WebWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult = ret;
		}
	}
}
