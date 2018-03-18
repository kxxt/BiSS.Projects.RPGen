using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Syncfusion.WinForms.Controls;

namespace BiSS.Projects.RPGen.Windows
{
	public class Windows10Btn2:SfButton
	{
		
		public Windows10Btn2()
		{
			
			//this.Style.PressedBorder.Width = 0;
			this.Style.BackColor = Color.FromArgb(204, 204, 204);
			this.Style.HoverBackColor = Color.FromArgb(204, 204, 204);
			this.Style.PressedBackColor = Color.FromArgb(153, 153, 153);
			this.Style.FocusedBackColor = Color.FromArgb(204,204,204);
			this.Style.FocusedBorder.Width = 3f;
			this.Style.FocusedBorder.Color = Color.FromArgb(0,0,0);
			//this.Style.FocusedBorder.LineJoin = LineJoin.Round;
			
			this.Style.ForeColor = Color.Black;
			this.Style.FocusedForeColor = Color.Black;
			this.Style.HoverForeColor = Color.Black;
			this.Style.PressedForeColor = Color.Black;

			this.Style.HoverBorder.Color = Color.FromArgb(122, 122, 122);
			this.Style.HoverBorder.Width = 3f;

			this.Style.PressedBorder = new Pen(Color.Black,0f);
			//this.MouseHover += this.Windows10Btn2_MouseHover;
		}

		//private void Windows10Btn2_MouseHover(object sender, EventArgs e)
		//{
		//	if (this.Focused)
		//		this.Style.Border = this.Style.FocusedBorder;
		//}
	}
}
