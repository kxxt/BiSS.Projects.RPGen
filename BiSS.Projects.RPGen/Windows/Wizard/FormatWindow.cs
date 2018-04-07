using System;
using System.Collections.Generic;
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
					tbs[i, j].Value = Program.Seprators[(NfSubjects)j][(Level)i] * 100;
					tbs[i, j].Size = new Size(100, 23);
					var icpy = i;
					var jcpy = j;
					tbs[i, j].LostFocusValidation = ValidationResetOption.MaxValue;
					tbs[i, j].ValidationMode = ValidationMode.LostFocus;

					tbs[i, j].ValueChanged += (__sender, __args) =>
					{
						Program.Seprators[(NfSubjects)jcpy][(Level)icpy] = tbs[icpy, jcpy].Value.HasValue ? (float)(tbs[icpy, jcpy].Value.Value / 100f) : 0f;
						//Log($"j:{jcpy},j:{jcpy}\r\ni:{icpy},i:{icpy}");
						if (DebugEnabled)
							MessageBox.Show($"{tbs[icpy, jcpy].Value}\r\n{Program.Seprators[(NfSubjects)jcpy][(Level)icpy]}");

					};
					Controls.Add(tbs[i, j]);
					//Log($"@E i:{i},i:{i}");
				}

				cur.X = curbackup.X;
				cur.Y += 23 + padding.Height;
			}

			sfNumericTextBox10.Value = 100 * Program.Seprators[NfSubjects.Zh][Level.A];
			sfNumericTextBox11.Value = 100 * Program.Seprators[NfSubjects.Zh][Level.B];
			sfNumericTextBox12.Value = 100 * Program.Seprators[NfSubjects.Zh][Level.C];
			sfNumericTextBox13.Value = 100 * Program.Seprators[NfSubjects.Zh][Level.D];
			continuebtn.TabIndex = 256;
			//MessageBox.Show($"{metroLabel28.Location}\r\n{tbs[1, 1].Location}");
			//MessageBox.Show($"{tbs[1,1].Value}\r\n{Program.Seprators[0][Level.A]}");

		}

		private void metroTextBox1_Click(object sender, EventArgs e)
		{
		}



		private void dotdotdot_Click(object sender, EventArgs e)
		{
			saveFileDialog.ShowDialog();
			metroTextBox1.Text = saveFileDialog.FileName;
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
			//Program.Title = metroTextBox2.Text;
		}

		private void metroTextBox3_TextChanged(object sender, EventArgs e)
		{
			Program.ClassName = metroTextBox3.Text;
		}

		private (bool right, IList<NfSubjects> errSubjects) CheckData()
		{
			(bool, IList<NfSubjects>) ret = (true, new List<NfSubjects>());
			for (NfSubjects x = NfSubjects.Zh; x < NfSubjects.All; x++)
			{
				if (!(tbs[4, (int)x].Value <= tbs[3, (int)x].Value &&
					  tbs[3, (int)x].Value <= tbs[2, (int)x].Value &&
					  tbs[2, (int)x].Value <= tbs[1, (int)x].Value))
				{
					ret.Item1 = false;
					ret.Item2.Add(x);
				}
			}

			return ret;
		}

		private void continuebtn_Click(object sender, EventArgs e)
		{
			ClosedByUser = false;
			var ret = CheckData();
			if (!ret.right)
			{
				var w = new DialogWindows10
				{
					Text = "数据错误!",
					title = { Text = "数据错误!" },
					subTitle =
					{
						Text = "输入的数据应满足 A > B > C > D .\r\n" +
							   $"{ret.errSubjects.FormatCol(" , ", pp => pp.Name())}学科不满足以上条件 , 请修改 ."
					}
				};
				w.ShowDialog();
				return;
			}
			string _path = string.IsNullOrWhiteSpace(metroTextBox1.Text)
				? Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) +
				  $"\\成绩报告.xlsx"
				: metroTextBox1.Text;
			var fi = new FileInfo(_path);
			//MessageBox.Show(_path);
			if (fi.Directory == null || !fi.Directory.Exists)
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
			OutputPath = _path;

			this.Close();
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

		private void sfNumericTextBox13_TextChanged(object sender, EventArgs e)
		{

		}

		private void windows10Btn21_Click(object sender, EventArgs e)
		{
			if (sfNumericTextBox13.Value <= sfNumericTextBox12.Value &&
				sfNumericTextBox12.Value <= sfNumericTextBox11.Value &&
				sfNumericTextBox11.Value <= sfNumericTextBox10.Value)
			{
				for (int i = 0; i <= 8; i++)
				{
					tbs[4, i].Value = sfNumericTextBox13.Value;
				}
				for (int i = 0; i <= 8; i++)
				{
					tbs[3, i].Value = sfNumericTextBox12.Value;
				}
				for (int i = 0; i <= 8; i++)
				{
					tbs[2, i].Value = sfNumericTextBox11.Value;
				}
				for (int i = 0; i <= 8; i++)
				{
					tbs[1, i].Value = sfNumericTextBox10.Value;
				}
			}
			else
			{
				var w = new DialogWindows10
				{
					Text = "数据错误!",
					title = { Text = "数据错误!" },
					subTitle = { Text = "输入的数据应满足 A > B > C > D ." }
				};
				w.ShowDialog();
			}
		}

		private void metroTextBox4_TextChanged(object sender, EventArgs e)
		{
			Program.Author = metroTextBox4.Text;
		}

		public bool ClosedByUser = true;
		private void FormatWindow_FormClosing(object sender, FormClosingEventArgs e)
		{

		}

		private void FormatWindow_FormClosed(object sender, FormClosedEventArgs e)
		{

		}
	}
}