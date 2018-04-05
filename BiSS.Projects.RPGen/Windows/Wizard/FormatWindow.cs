using System;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BiSS.Projects.RPGen.Structure;
using Syncfusion.WinForms.Input;
using Syncfusion.WinForms.Input.Enums;
using static BiSS.Projects.RPGen.Program;
namespace BiSS.Projects.RPGen.Windows.Wizard
{
	public partial class FormatWindow : DialogWindows10
	{
		private readonly SfNumericTextBox[,] tbs;

		public string Path { get; set; } = "$";

		public FormatWindow()
		{
			InitializeComponent();
			tbs = new SfNumericTextBox[5, 10];
			var curbackup = new Point(392, 157);
			var cur = new Point(392, 157);
			var padding = new Size(5, 6);
			//int pdx = 5, pdy = 4; //curx:current X,cury:current y;pdx:X padding,pdy:Y padding
			//int i = 0, j = 0;
			for (int j = 0; j <= 8; j++)
			{
				//j = j;
				//Log($"j:{j},j:{j}");
				for (int i = 1; i <= 4; i++)
				{
					//i = i;
					//Log($"@B i:{i},i:{i}");
					tbs[i, j] = new SfNumericTextBox();
					tbs[i, j].Location = new Point(cur.X, cur.Y);

					cur.X += 100 + padding.Width;

					tbs[i, j].BorderStyle = BorderStyle.FixedSingle;
					tbs[i, j].Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
					tbs[i, j].ForeColor = SystemColors.WindowText;
					tbs[i, j].FormatMode = FormatMode.Percent;
					tbs[i, j].HideTrailingZeros = true;
					//tbs[i, j].Location = new System.Drawing.Point(710, 342);
					tbs[i, j].MaxValue = 100D;
					tbs[i, j].MinValue = 0D;
					tbs[i, j].Value = Program.Seprators[(NfSubjects)j][(Level)i];
					tbs[i, j].Size = new Size(100, 23);
					var icpy = i;
					var jcpy = j;
					tbs[i, j].LostFocusValidation = ValidationResetOption.MaxValue;
					tbs[i, j].ValidationMode = ValidationMode.LostFocus;

					tbs[i, j].ValueChanged += (__sender, __args) =>
					{
						Program.Seprators[(NfSubjects)jcpy][(Level)icpy] = tbs[icpy, jcpy].Value.HasValue ? (float)(tbs[icpy, jcpy].Value.Value / 100f) : 0f;
						//Log($"j:{jcpy},j:{jcpy}\r\ni:{icpy},i:{icpy}");
						MessageBox.Show($"{tbs[icpy, jcpy].Value}\r\n{Program.Seprators[(NfSubjects)jcpy][(Level)icpy]}");

					};
					Controls.Add(tbs[i, j]);
					//Log($"@E i:{i},i:{i}");
				}

				cur.X = curbackup.X;
				cur.Y += 23 + padding.Height;
			}

			continuebtn.TabIndex = 256;
			//MessageBox.Show($"{metroLabel28.Location}\r\n{tbs[1, 1].Location}");
			//MessageBox.Show($"{tbs[1,1].Value}\r\n{Program.Seprators[0][Level.A]}");

		}

		private void metroTextBox1_Click(object sender, EventArgs e)
		{
		}

		protected void ChangeFileSaveDialog(bool toPPT)
		{
			if (Program.DebugEnabled)
				MessageBox.Show($"Checked:{metroToggle2.Checked}\r\nCHANGED TO {(toPPT ? "PPT" : "EXCEL")} MODE!");
			saveFileDialog.Filter =
				toPPT ? "PowerPoint 2007+ 幻灯片|*.pptx|PowerPoint 2003 幻灯片|*.ppt" : "Excel 2007+ 表格|*.xlsx|Excel 2003 表格|*.xls";
		}

		private void dotdotdot_Click(object sender, EventArgs e)
		{
			saveFileDialog.ShowDialog();
			metroTextBox1.Text = saveFileDialog.FileName;
		}

		private void metroToggle2_CheckedChanged(object sender, EventArgs e)
		{
			if (Program.DebugEnabled)
				MessageBox.Show(metroToggle2.Checked.ToString());
			ChangeFileSaveDialog(!metroToggle2.Checked);
		}

		private void metroTile1_Click(object sender, EventArgs e)
		{
			var x = new DialogWindows10With1Btn();
			x.Text = "提示";
			x.title.Text = x.Text;
			x.subTitle.Text = "此成绩报告由本生成器生成,您无法修改其作者.";
			x.Btn.Click += (__a, __b) => { x.Close(); };
			x.ShowDialog();
		}

		private void FormatWindow_Shown(object sender, EventArgs e)
		{
			Activate();
		}

		private void sfNumericTextBox1_TextChanged(object sender, EventArgs e)
		{
			Program.FullScore[NfSubjects.Zh] = (float)(sfNumericTextBox1.Value ?? 150f);
		}

		private void sfNumericTextBox8_TextChanged(object sender, EventArgs e)
		{
			Program.FullScore[NfSubjects.M] = (float)(sfNumericTextBox8.Value ?? 150f);
		}

		private void sfNumericTextBox7_TextChanged(object sender, EventArgs e)
		{
			Program.FullScore[NfSubjects.En] = (float)(sfNumericTextBox7.Value ?? 150f);
		}

		private void sfNumericTextBox6_TextChanged(object sender, EventArgs e)
		{
			Program.FullScore[NfSubjects.P] = (float)(sfNumericTextBox6.Value ?? 150f);
		}

		private void sfNumericTextBox5_TextChanged(object sender, EventArgs e)
		{
			Program.FullScore[NfSubjects.C] = (float)(sfNumericTextBox5.Value ?? 150f);
		}

		private void sfNumericTextBox4_TextChanged(object sender, EventArgs e)
		{
			Program.FullScore[NfSubjects.Po] = (float)(sfNumericTextBox4.Value ?? 150f);
		}

		private void sfNumericTextBox3_TextChanged(object sender, EventArgs e)
		{
			Program.FullScore[NfSubjects.H] = (float)(sfNumericTextBox3.Value ?? 150f);
		}

		private void sfNumericTextBox2_TextChanged(object sender, EventArgs e)
		{
			Program.FullScore[NfSubjects.G] = (float)(sfNumericTextBox2.Value ?? 150f);
		}

		private void sfNumericTextBox9_TextChanged(object sender, EventArgs e)
		{
			Program.FullScore[NfSubjects.B] = (float)(sfNumericTextBox9.Value ?? 150f);
		}

		private void metroTextBox2_TextChanged(object sender, EventArgs e)
		{
			Program.Title = metroTextBox2.Text;
		}

		private void metroTextBox3_TextChanged(object sender, EventArgs e)
		{
			Program.ClassName = metroTextBox3.Text;
		}

		private void continuebtn_Click(object sender, EventArgs e)
		{
			var _path = string.IsNullOrWhiteSpace(metroTextBox1.Text)
				? Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) +
				  $"\\成绩报告.{(metroToggle2.Checked ? "xlsx" : "pptx")}"
				: metroTextBox1.Text;
			var fi = new FileInfo(_path);
			//MessageBox.Show(fi.FullName);
			if (!fi.Directory.Exists)
			{
				MessageBox.Show("路径不存在.\r\n请返回修改.", "错误");
				return;
			}

			dynamic x = null;
			try
			{
				x = Program.Data.X;
			}
			catch
			{
				if (DebugEnabled)
					return;
			}

			//MessageBox.Show($"{fi.Name.Replace("." + fi.Extension, "")}\r\n{fi.Extension}");
			Program.SaveExcel(x, fi.DirectoryName, fi.Name.Replace(fi.Extension, ""), fi.Extension == ".xlsx");
			Path = _path;
			this.Hide();
		}

		private void FormatWindow_Load(object sender, EventArgs e)
		{
		}

		private void metroLabel19_Click(object sender, EventArgs e)
		{
		}

		private void metroLabel20_Click(object sender, EventArgs e)
		{
		}

		private void metroLabel21_Click(object sender, EventArgs e)
		{
		}

		private void metroLabel22_Click(object sender, EventArgs e)
		{
		}

		private void metroLabel23_Click(object sender, EventArgs e)
		{
		}

		private void metroLabel24_Click(object sender, EventArgs e)
		{
		}

		private void metroLabel25_Click(object sender, EventArgs e)
		{
		}

		private void metroLabel26_Click(object sender, EventArgs e)
		{
		}

		private void metroLabel27_Click(object sender, EventArgs e)
		{
		}

		private void metroLabel18_Click(object sender, EventArgs e)
		{
		}


	}
}