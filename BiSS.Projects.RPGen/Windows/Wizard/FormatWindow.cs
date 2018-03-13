using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BiSS.Projects.RPGen.Windows.Wizard
{
	public partial class FormatWindow : BiSS.Projects.RPGen.Windows.Wizard.DialogWindows10
	{
		private string path="$";

		public string Path { get => this.path; set => this.path = value; }

		public FormatWindow()
		{
			InitializeComponent();
		}

		private void metroTextBox1_Click(object sender, EventArgs e)
		{

		}

		protected void ChangeFileSaveDialog(bool toPPT)
		{
			if (Program.DebugEnabled) MessageBox.Show($"Checked:{metroToggle2.Checked}\r\nCHANGED TO {(toPPT ? "PPT" : "EXCEL")} MODE!");
			saveFileDialog.Filter =
				toPPT ? "PowerPoint 2007+ 幻灯片|*.pptx|PowerPoint 2003 幻灯片|*.ppt" : "Excel 2007+ 表格|*.xlsx|Excel 2003 表格|*.xls";
		}
		private void dotdotdot_Click(object sender, EventArgs e)
		{
			this.saveFileDialog.ShowDialog();
			this.metroTextBox1.Text = saveFileDialog.FileName;
		}

		private void metroToggle2_CheckedChanged(object sender, EventArgs e)
		{
			if(Program.DebugEnabled)
			MessageBox.Show(metroToggle2.Checked.ToString());
			this.ChangeFileSaveDialog(!metroToggle2.Checked);
		}

		private void metroTile1_Click(object sender, EventArgs e)
		{

		}
	}
}
