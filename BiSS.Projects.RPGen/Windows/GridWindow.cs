using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace BiSS.Projects.RPGen.Windows
{
	public partial class GridWindow : MetroFramework.Forms.MetroForm
	{
		private bool showed=false;
		public GridWindow(string title)
		{
			InitializeComponent();
			this.Text = title;
			dataGridView.DoubleBuffered(true);
			dataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
			dataGridView.DefaultCellStyle.SelectionBackColor = Color.MediumPurple;
			dataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;
			dataGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
			//dataGridView.Sort();

		}
		public DataGridView DataGridView { get => this.dataGridView; set => this.dataGridView = value; }
		public BindingSource DisplayObjectBindingSource { get => this.displayObjectBindingSource; set => this.displayObjectBindingSource = value; }
		private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void displayObjectBindingSource_CurrentChanged(object sender, EventArgs e)
		{

		}

		private void dataGridView_Paint(object sender, PaintEventArgs e)
		{
			
		}

		private void GridWindow_Shown(object sender, EventArgs e)
		{
			for (int i = 0; i < dataGridView.Rows.Count; i++)
			{
				if (i % 2 == 0)
					dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.Aquamarine;
				else
					dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.Cyan;
				//if (i >= 3) dataGridView.Columns[i].Width = 80;
			}
			showed = true;
			for (int i = 0; i < dataGridView.ColumnCount; i++)
			{
				
			}
		}

		private void dataGridView_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
		{
			if (Program.DebugEnabled&&this.showed)
				MessageBox.Show($"Width:{e.Column.Width}");
		}

		private void GridWindow_VisibleChanged(object sender, EventArgs e)
		{
			if (this.Visible == false)
				showed = false;
		}

		private void GridWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			showed = false;
		}
	}
}
