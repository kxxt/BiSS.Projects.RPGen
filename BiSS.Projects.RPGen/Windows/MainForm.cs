using System.Windows.Forms;

namespace BiSS.Projects.RPGen.Windows
{
	public partial class MainForm : RsWork.UI.Windows.ModernDialogBase
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void closebtn_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void minbtn_Click(object sender, System.EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void modernButton2_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show(Application.StartupPath + @"\Web\loading.html");
			new SplashWindow().Show();
		}
	}
}
