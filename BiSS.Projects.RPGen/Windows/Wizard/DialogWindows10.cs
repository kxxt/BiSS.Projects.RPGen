using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.WinForms.Controls;

namespace BiSS.Projects.RPGen.Windows.Wizard
{
	public partial class DialogWindows10 : SfForm
	{
		public DialogWindows10()
		{
			InitializeComponent();
		}

		private void modernButton1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
