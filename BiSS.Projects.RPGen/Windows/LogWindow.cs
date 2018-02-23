using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiSS.Projects.RPGen.Windows
{
	public partial class LogWindow : Form
	{
		private static bool Inited=false;
		public LogWindow()
		{
			if (Inited) throw new InvalidOperationException("An instance has already been there.");
			else Inited = true;
			
			InitializeComponent();
			this.metroTextBox1.Text = Program.Log;
		}

		private void metroTextBox1_Click(object sender, EventArgs e)
		{

		}

		private void metroButton1_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(this.metroTextBox1.Text);
		}

		private void metroButton2_Click(object sender, EventArgs e)
		{
			Program.Log = "";
		}

		private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

	}
}
