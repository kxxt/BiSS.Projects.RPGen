using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using RsWork.Functions.Log;
using RsWork.UI.Technologies;
using static BiSS.Projects.RPGen.Program;
namespace BiSS.Projects.RPGen.Windows
{
	public partial class GridEditWindow : MetroFramework.Forms.MetroForm
	{
		private readonly SynchronizationContext synchronizationContext;
		private bool showed=false;
		public GridEditWindow(string title)
		{
			InitializeComponent();
			this.Text = title;
			dataGridView.DoubleBuffered(true);
			//dataGridView.AutoGenerateColumns = false;
			dataGridView.AllowUserToAddRows = false;
			dataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
			dataGridView.DefaultCellStyle.SelectionBackColor = Color.MediumPurple;
			dataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;
			for(int i=0;i<dataGridView.ColumnCount;i++)
				dataGridView.Columns[i].SortMode=DataGridViewColumnSortMode.Automatic;
			
			dataGridView.SortCompare +=StringIntSortCompare; 
		}
		public DataGridView DataGridView { get => this.dataGridView; set => this.dataGridView = value; }
		
		private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dataGridView_Paint(object sender, PaintEventArgs e)
		{

				for (int i = 0; i < dataGridView.Rows.Count; i++)
				{
					if (i % 2 == 0)
						dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.Aquamarine;
					else
						dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.Cyan;
					//if (i >= 3) dataGridView.Columns[i].Width = 80;
				}

			
		}

		private  void GridWindow_Shown(object sender, EventArgs e)
		{
		
				showed = true;
				for (int i = 0; i < dataGridView.ColumnCount; i++)
				for (int j = 0; j < dataGridView.RowCount; j++)
				{
					try
					{
						switch (i)
						{
							case 1:
							case 2:
							case 3:
							case 5:
							case 6:
							case 8:
							case 9:
							case 11:
							case 12:
							case 14:
							case 15:
							case 17:
							case 18:
							case 20:
							case 21:
							case 23:
							case 24:
							case 26:
							case 27:
							case 29:
							case 30:
								dataGridView[i, j].Value = Convert.ToInt32(dataGridView[i, j].Value); 
						;	
								break;
							default:
								if (i != 0)
									dataGridView[i, j].Value = Convert.ToSingle(dataGridView[i, j].Value);
									
								break;
						}

					}
					catch (Exception ex)
					{
						if (i != 0)
						{
							Log($"Error cell:({i},{j})");
							MessageBox.Show($"{dataGridView[0, j].Value}同学的\"{dataGridView.Columns[i].Name}\"值设置不正确.", "错误");
						}

					}
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

		private void dataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try {
				if (Program.ShowCellInfo)
					MessageBox.Show($"Cell[{e.ColumnIndex},{e.RowIndex}]\r\n" +
					                $"Info:\r\n" +
					                $"\tFormat:{dataGridView[e.ColumnIndex, e.RowIndex].Style.Format}\r\n" +
					                $"\tIsInt32:{dataGridView[e.ColumnIndex, e.RowIndex].Value is Int32}\r\n"+
									$"\tIsFloat:{dataGridView[e.ColumnIndex, e.RowIndex].Value is float}\r\n");
			}
			catch { }
			
		}
		private void StringIntSortCompare(object sender, DataGridViewSortCompareEventArgs e)
		{
			int a = int.Parse(e.CellValue1.ToString()), b = int.Parse(e.CellValue2.ToString());

			// If the cell value is already an integer, just cast it instead of parsing

			e.SortResult = a.CompareTo(b);

			e.Handled = true;
		}

		private async void dataGridView_DataSourceChanged(object sender, EventArgs e)
		{

				var d = dataGridView.DataSource as DataTable;
				for (int i = 1; i < d.Columns.Count; i++) //0 col is iged
				{
					for (int j = 0; j < d.Rows.Count; j++)
					{
						try
						{
							if(i==4|| i == 4 || i == 7 || i == 10 || i == 13 || i == 16 || i == 19 || i == 22 || i == 4 ||i==25||i==28)
								d.Rows[j][i] = Convert.ToSingle(d.Rows[j][i].ToString());
							else
								d.Rows[j][i] = Convert.ToInt32(d.Rows[j][i].ToString());
						}
						catch
						{
							Log($"Error convert ({i},{j}) to Int32");
						}

					}
				}
				dataGridView.DataSource = d;
			

		}

		private void dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			Log(Logger.GetExceptionInfo(e.Exception));
		
		}

		private void metroButton1_Click(object sender, EventArgs e)
		{
			if(dataGridView.Rows.Count - 1>=0)
			dataGridView.Rows.RemoveAt(dataGridView.Rows.Count - 1);
		}
	}
}
