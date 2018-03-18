using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Syncfusion.WinForms.Controls;

namespace BiSS.Projects.RPGen.Windows
{
	public class Windows10Btn1:SfButton
	{
		//private bool entered = false;
		//private Pen broderbackup=null;
		//private Color colorbackup =Color.FromArgb(0,0,0) ;
		public Windows10Btn1()
		{
			
			this.Style.BackColor = Color.FromArgb(0, 120, 215);
			this.Style.HoverBackColor = Color.FromArgb(0, 103, 184);
			this.Style.PressedBackColor = Color.FromArgb(0, 93, 166);
			this.Style.FocusedBackColor = Color.FromArgb(0, 93, 166);
			this.Style.FocusedBorder.Width = 3f;
			this.Style.FocusedBorder.Color = Color.FromArgb(0, 0, 0);
			//this.Style.FocusedBorder.LineJoin = LineJoin.Round;

			this.Style.ForeColor = Color.White;
			this.Style.FocusedForeColor = Color.White;
			this.Style.HoverForeColor = Color.White;
			this.Style.PressedForeColor = Color.White;
			
			this.Style.PressedBorder = new Pen(Color.Black, 0f);
			this.Style.HoverBorder = new Pen(Color.Black, 0f);
			//this.MouseHover += this.Windows10Btn1_MouseHover;
			//this.LostFocus += this.Windows10Btn1_LostFocus;
			//this.MouseEnter += this.Windows10Btn1_MouseEnter;
			//this.MouseLeave += this.Windows10Btn1_MouseLeave;

			//this.broderbackup = Style.HoverBorder.Clone() as Pen;
			//this.colorbackup = Color.FromArgb(Style.HoverBackColor.R, Style.HoverBackColor.G, Style.HoverBackColor.B);
		}

		//private void Windows10Btn1_MouseLeave(object sender, EventArgs e)
		//{
		//	entered = false;
		//	//Thread.Sleep(100);
		//	this.Style.HoverBorder = broderbackup;
		//	this.Style.HoverBackColor = colorbackup;
			
		//}

		//private void Windows10Btn1_MouseEnter(object sender, EventArgs e)
		//{
			//entered = true;
			//if (this.Focused)
			//{
			//	this.Style.HoverBorder = this.Style.FocusedBorder;
			//	this.Style.HoverBackColor = this.Style.FocusedBackColor;
			//}

		//}

		private void Windows10Btn1_LostFocus(object sender, EventArgs e)
		{
			//if (!entered)
			//{
			//	this.Style.HoverBorder = broderbackup;
			//	this.Style.HoverBackColor = colorbackup;
			//}
			//else
			//{
			//	//var xx = null;
			//	var x= new EventHandler((s, args) => {
			//		this.Style.HoverBorder = broderbackup;
			//		this.Style.HoverBackColor = colorbackup;
					
			//	});
			//	MouseLeave +=x ;

			//}
			
			
		}

		//private void Windows10Btn1_MouseHover(object sender, EventArgs e)
		//{
			
		//}
	}
}
