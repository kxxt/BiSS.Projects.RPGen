using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Point = System.Windows.Point;

namespace BiSS.Projects.RPGen.ExcelLayout
{
	public class LayoutCalc_ChartsRegularLayout_
	{
		
		//private PointF next;

	
		private SizeF size=new SizeF(0,0);
		private SizeF padding=new SizeF(0,0);

		private int col=Int32.MaxValue;

		private int row=1;
		private (int X,int Y) cur = (0,0);
		private readonly LayoutMode mode;
		private PointF prev=new PointF(0,0);
		private PointF begin = new PointF(0, 0);
		public LayoutCalc_ChartsRegularLayout_(SizeF size,int col = Int32.MaxValue, int row = 1, LayoutMode mode = LayoutMode.LTR | LayoutMode.UTD)
		{
			
			this.col = col;
			this.row = row;
			this.mode = mode;
			this.size = size;
			UpdatePrev(true);
		}
		public LayoutCalc_ChartsRegularLayout_(PointF begin,SizeF padding, SizeF size, int col=Int32.MaxValue, int row=1, LayoutMode mode=LayoutMode.LTR|LayoutMode.UTD)
		{
			this.padding = padding;
			this.col = col;
			this.row = row;
			this.mode = mode;
			this.begin = begin;
			this.size = size;
			UpdatePrev(true);
		}

		private void UpdatePrev(bool IsBegin=false)
		{
			if (IsBegin)
				prev = this.begin;
		}
		/// <summary>
		/// 请存储局部变量使用
		/// </summary>
		public (PointF point,SizeF size) Next
		{
			get
			{
				//todo
				//PointF p=new PointF();
				if (cur.X == 0 && cur.Y == 0)
				{
					cur.X++;
					return (prev, size);
				}
					
				if (cur.X == 0)
				{
					prev.X = begin.X;
					prev.Y += size.Height + padding.Height;
				}
				else
				{
					prev.X += size.Width + padding.Width;
				}
				//prev = new PointF(prev.X + padding.Width, prev.Y);
				if (cur.X == col)
				{
					cur.Y++;
					cur.X = 0;
				}
				else ++cur.X;
				if (cur.Y == row)
				{
					//cur.X++;
					//cur.Y = 0;
					throw new NotImplementedException();
				}
				
				return (prev,size);
			}
		}
		public PointF Prev { get => this.prev;private set => this.prev = value; }
		public SizeF Padding { get => this.padding;private  set => this.padding = value; }
		public int Col { get => this.col; set => this.col = value; }
		public int Row { get => this.row; set => this.row = value; }
		public LayoutMode Mode { get => this.mode;  }
		public SizeF Size { get => this.size; private set => this.size = value; }
		//public PointF Begin { get => this.begin; set => this.begin = value; }
		//public PointF GetNextStartPos()
		//{
		//	return TPointF
		//}
	}
	[Flags]
	public enum LayoutMode
	{
		RTL=0b1,
		LTR=0b10,
		UTD=0b100,
		DTU=0b1000


	}
}
