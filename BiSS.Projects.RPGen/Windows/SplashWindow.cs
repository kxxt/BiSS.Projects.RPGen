using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BiSS.Projects.RPGen.Windows
{
	public partial class SplashWindow : RsWork.UI.Windows.ModernDialogBase
	{
		public SplashWindow()
		{
			InitializeComponent();
			webBrowser1.Url=new Uri(Application.StartupPath+@"\Web\loading.html");
		}

		private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{

		}
	}
}
