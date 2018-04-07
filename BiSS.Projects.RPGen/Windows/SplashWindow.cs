using BiSS.Projects.RPGen.Op;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
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
			Thread.Sleep(2000);
		}

		private void bgw_DoWork(object sender, DoWorkEventArgs e)
		{
			Work();
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

		public void Work()
		{
			IList<(bool x, string y)> li = new List<(bool, string)>();
			li.Add((Ckf("Data\\object1"), "Data\\object1"));
			li.Add((Ckf("Data\\object2"), "Data\\object2"));
			li.Add((Ckf("Data\\object3"), "Data\\object3"));
			li.Add((Ckf("Data\\Temp\\.data"), "Data\\Temp\\.data"));
			foreach (var b in li)
			{
				if (!b.x)
				{
					this.TopMost = false;
					MessageBox.Show($"应用程序找不到必要文件 :{b.y}\r\n可能是应用程序损坏 .\r\n请重新安装应用程序 .", "损坏 / 丢失 必要文件!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					Application.Exit();
				}
			}
		}

		private static bool Ckf(string f)
		{
			return File.Exists(f);
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
