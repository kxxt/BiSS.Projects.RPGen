using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;

namespace BiSS.Projects.RPGen.Windows.Wizard
{
	public partial class DialogWindows10With1Btn : DialogWindows10
	{
		public DialogWindows10With1Btn()
		{
			InitializeComponent();
			
		}

		protected override void OnShown(EventArgs e)
		{
			//OnPaint(null);
			
			//BottomPanel.Height = (int)(this.Height * 0.3);

			//Program.Log($"Window Height{this.Height}");
			//this.Height = BottomPanel.Height + BottomPanel.Location.Y;
			//Program.Log($"Window Height{this.Height}");

			//BottomPanel.Location = new Point(0, this.Height - BottomPanel.Height);
			//Btn.Location = new Point(BottomPanel.Width - Btn.Width - 20, (int)(BottomPanel.Height * 0.15));
			//Program.Log($"AutoSize MSG:Window Height:{this.Height} , Panel Height:{BottomPanel.Height} , Location:{BottomPanel.Location}");
			
			//if (BottomPanel.Size.Height + BottomPanel.Location.Y > this.Height)
			//{

			//	// = BottomPanel.Size.Height + BottomPanel.Location.Y;
			//}
			//panel1.Height = (int)1.0* this.Height;

			//BottomPanel.Width = this.Width;
			base.OnShown(e);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			//BottomPanel.Width = this.Width;
			base.OnPaint(e);
		}

		private void DialogWindows10With1Btn_Load(object sender, EventArgs e)
		{
			BottomPanel.Height = (int)(this.Height * 0.3);

			Program.Log($"Window Height{this.Height}");
			this.Height = BottomPanel.Height + BottomPanel.Location.Y;
			Program.Log($"Window Height{this.Height}");

			BottomPanel.Location = new Point(0, this.Height - BottomPanel.Height);
			Btn.Location = new Point(BottomPanel.Width - Btn.Width - 20, (int)(BottomPanel.Height * 0.15));
			Program.Log($"AutoSize MSG:Window Height:{this.Height} , Panel Height:{BottomPanel.Height} , Location:{BottomPanel.Location}");
			BottomPanel.Width = this.Width;
		}
	}
}
