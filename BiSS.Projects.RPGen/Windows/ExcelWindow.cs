using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RsWork.UI.Windows;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;
using MetroForm = MetroFramework.Forms.MetroForm;

namespace BiSS.Projects.RPGen.Windows
{
	public partial class ExcelWindow : SfForm
	{
		public ExcelWindow(string title)
		{
			InitializeComponent();
			DoubleBuffered = true;
			spreadsheet1.DoubleBuffered(true);
			this.Text = title;
		}
	}
}
