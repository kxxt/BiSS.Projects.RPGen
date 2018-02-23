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

		}

		private void debugEnabledToggle_CheckedChanged(object sender, EventArgs e)
		{
			Program.DebugEnabled = debugEnabledToggle.Checked;
		}

		private void closebtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
