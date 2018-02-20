using BiSS.Projects.RPGen.Op;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BiSS.Projects.RPGen.Windows
{
	public partial class SplashWindow : RsWork.UI.Windows.ModernDialogBase
	{
		public SplashWindow()
		{
			InitializeComponent();
			//metroProgressSpinner1.BringToFront();
			//metroProgressSpinner1.Spinning = true;
			//metroProgressSpinner1.UseSelectable = true;
			//webBrowser1.Url=new Uri(Application.StartupPath+@"\Web\loading.html");
			//DataReader.RecordFiles();
			t= new Thread(DoWork);
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			timer2.Stop();
			//Thread t=new Thread(DoWork);
			//t.Start();
			this.BeginInvoke(new Action(DoWork));
			this.Dispose();
		}
		Thread t; 
		private void DoWork()
		{
			Thread.Sleep(10000);
			MessageBox.Show("Finished");
		}
	}
}
