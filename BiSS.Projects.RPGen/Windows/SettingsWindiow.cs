using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BiSS.Projects.RPGen.Windows
{
	public partial class SettingsWindiow : RsWork.UI.Windows.ModernDialogBase
	{
		public SettingsWindiow()
		{
			InitializeComponent();
			debugEnabledToggle.Checked = Program.DebugEnabled;
			metroToggle1.Checked = Program.ShowCellInfo;
		}

		private void debugEnabledToggle_CheckedChanged(object sender, EventArgs e)
		{
			Program.DebugEnabled = debugEnabledToggle.Checked;
		}

		private void closebtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void metroToggle1_CheckedChanged(object sender, EventArgs e)
		{
			Program.ShowCellInfo = metroToggle1.Checked;
		}
	}
}
