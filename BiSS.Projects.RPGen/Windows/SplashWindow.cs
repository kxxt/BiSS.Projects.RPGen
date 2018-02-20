using BiSS.Projects.RPGen.Op;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using RsWork.UI.Windows;

namespace BiSS.Projects.RPGen.Windows
{
	public partial class SplashWindow : RsWork.UI.Windows.ModernDialogBase
	{
		private BlackBackground bg;
		public SplashWindow()
		{
			InitializeComponent();
			bg=new BlackBackground();
			bg.Show();
			//metroProgressSpinner1.BringToFront();
			//metroProgressSpinner1.Spinning = true;
			//metroProgressSpinner1.UseSelectable = true;
			//webBrowser1.Url=new Uri(Application.StartupPath+@"\Web\loading.html");
			//DataReader.RecordFiles();
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			timer.Stop();
			//Thread t=new Thread(DoWork);
			//t.Start();
			//Thread.Sleep(5000);
			this.bgw.RunWorkerAsync();
			
		}
	
		private void DoWork()
		{
			//todo:
			Thread.Sleep(5000);
		}

		private void bgw_DoWork(object sender, DoWorkEventArgs e)
		{
			DoWork();
		}

		private void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			bg.Close();
			this.Close();
		}
		private void WindowMove(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
		}
	}
}
