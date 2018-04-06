using BiSS.Projects.RPGen.Op;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Cryptography;
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
			bg = new BlackBackground();
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
			Thread.Sleep(1000);
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
			//if (this.Handle == null) return;
			ReleaseCapture();

			SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
		}

		private void Work()
		{

		}
		/// <summary>
		/// 计算文件的MD5校验
		/// </summary>
		/// <param name="fileName"></param>
		/// <returns></returns>
		public static string MD5(string fileName)
		{
			try
			{
				FileStream file = new FileStream(fileName, FileMode.Open);
				System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
				byte[] retVal = md5.ComputeHash(file);
				file.Close();
				StringBuilder sb = new StringBuilder();
				for (int i = 0; i < retVal.Length; i++)
				{
					sb.Append(retVal[i].ToString("x2"));
				}
				return sb.ToString();
			}
			catch (Exception ex)
			{
				throw new Exception("GetMD5HashFromFile() fail,error:" + ex.Message);
			}
		}
	}
}
