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
	public partial class LogWindow : MetroFramework.Forms.MetroForm
	{
		private static bool Inited=false;
		public LogWindow()
		{
			if (Inited) throw new InvalidOperationException("An instance has already been there.");
			else Inited = true;
			
			InitializeComponent();
			this.metroTextBox1.Text = Program.Logs;
		}

		private void metroTextBox1_Click(object sender, EventArgs e)
		{

		}

		private void metroButton1_Click(object sender, EventArgs e)
		{
            if(!string.IsNullOrEmpty(this.metroTextBox1.Text))
			Clipboard.SetText(this.metroTextBox1.Text);
		}

		private void metroButton2_Click(object sender, EventArgs e)
		{
			Program.Logs = "";
		}

		private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

        private void metroButton4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            metroButton1_Click(this.metroButton1, null);
            metroButton2_Click(this.metroButton2, null);
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
