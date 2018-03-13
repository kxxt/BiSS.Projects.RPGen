using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.WinForms.Controls;

namespace BiSS.Projects.RPGen.Windows.Busy
{
	public partial class BusyWindow : SfForm
	{
		public BusyWindow()
		{
			InitializeComponent();
			//this.Worker.DoWork += this.TestDoWorkMethod;
			this.Worker.RunWorkerCompleted += (s,args) => this.Close();
			this.Worker.RunWorkerAsync();
		}

		private void TestDoWorkMethod(object sender, DoWorkEventArgs e)
		{
			for(int i=1;i<=10;i++)
			{
				Program.Log($"#Test id={i}");
				Thread.Sleep(1000);
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			this.metroProgressSpinner2.Style += 1;
		}

		private void metroProgressSpinner2_Click(object sender, EventArgs e)
		{
			
		}

		private void BusyWindow_Load(object sender, EventArgs e)
		{
			
		}
	}
}
