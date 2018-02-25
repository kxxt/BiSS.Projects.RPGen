using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BiSS.Projects.RPGen.Windows
{
    public partial class WarningWindow : RsWork.UI.Windows.BasicNoneBorderWinForm
    {
        public WarningWindow()
        {
            InitializeComponent();
			

		}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void WarningWindow_Load(object sender, EventArgs e)
        {

        }

        private void modernButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modernButton2_Click(object sender, EventArgs e)
        {
            Environment.Exit(-2147483648);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
        }

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
