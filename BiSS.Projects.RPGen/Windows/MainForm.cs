using System.Diagnostics;
using System.Windows.Forms;
using MetroFramework.Forms;
namespace BiSS.Projects.RPGen.Windows
{
	public partial class MainForm : MetroForm
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
			//MessageBox.Show(Application.StartupPath + @"\Web\loading.html");
			new SplashWindow().Show();
		}

		private void modernButton1_Click(object sender, System.EventArgs e)
		{
			Process.Start("https://github.com/kxxt/BiSS.Projects.RPGen");
		}

		private void modernButton3_Click(object sender, System.EventArgs e)
		{
			new AboutWindow().ShowDialog();
		}
	}
}
