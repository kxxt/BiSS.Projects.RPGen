using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using BiSS.Projects.RPGen.Structure;

namespace BiSS.Projects.RPGen.Windows.Wizard
{
	public partial class FormatWindow : BiSS.Projects.RPGen.Windows.Wizard.DialogWindows10
	{
		private string path="$";

		public string Path { get => this.path; set => this.path = value; }

		public FormatWindow()
		{
			InitializeComponent();
		}

		private void metroTextBox1_Click(object sender, EventArgs e)
		{

		}

		protected void ChangeFileSaveDialog(bool toPPT)
		{
			if (Program.DebugEnabled) MessageBox.Show($"Checked:{metroToggle2.Checked}\r\nCHANGED TO {(toPPT ? "PPT" : "EXCEL")} MODE!");
			saveFileDialog.Filter =
				toPPT ? "PowerPoint 2007+ 幻灯片|*.pptx|PowerPoint 2003 幻灯片|*.ppt" : "Excel 2007+ 表格|*.xlsx|Excel 2003 表格|*.xls";
		}
		private void dotdotdot_Click(object sender, EventArgs e)
		{
			this.saveFileDialog.ShowDialog();
			this.metroTextBox1.Text = saveFileDialog.FileName;
		}

		private void metroToggle2_CheckedChanged(object sender, EventArgs e)
		{
			if(Program.DebugEnabled)
			MessageBox.Show(metroToggle2.Checked.ToString());
			this.ChangeFileSaveDialog(!metroToggle2.Checked);
		}

		private void metroTile1_Click(object sender, EventArgs e)
		{
			var x=new DialogWindows10With1Btn();
			x.Text = "提示";
			x.title.Text = x.Text;
			x.subTitle.Text = "此成绩报告由本生成器生成,您无法修改其作者.";
			x.Btn.Click += (__a, __b) => { x.Close();};
			x.ShowDialog();
		}

		private void FormatWindow_Shown(object sender, EventArgs e)
		{
			this.Activate();
		}

		private void sfNumericTextBox1_TextChanged(object sender, EventArgs e)
		{
			Program.FullScore[NfSubjects.Zh] = (float)(sfNumericTextBox1.Value??150f);
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
			string _path =string.IsNullOrWhiteSpace(metroTextBox1.Text)?(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)+$"\\成绩报告.{(this.metroToggle2.Checked?"xlsx":"pptx")}"): metroTextBox1.Text;
			FileInfo fi=new FileInfo(_path);
			MessageBox.Show(fi.FullName);
			if (!fi.Directory.Exists)
			{
				MessageBox.Show("路径不存在.\r\n请返回修改.","错误");
				return;
			}

			var x = Program.Data.X;
			MessageBox.Show($"{fi.Name.Replace("." + fi.Extension, "")}\r\n{fi.Extension}");
			Program.SaveExcel(x,fi.DirectoryName,fi.Name.Replace(fi.Extension,""),fi.Extension==".xlsx");

		}

		private void FormatWindow_Load(object sender, EventArgs e)
		{

		}

		private void metroLabel19_Click(object sender, EventArgs e)
		{

		}

		private void sfNumericTextBox11_TextChanged(object sender, EventArgs e)
		{

		}

		private void metroLabel20_Click(object sender, EventArgs e)
		{

		}

		private void sfNumericTextBox12_TextChanged(object sender, EventArgs e)
		{

		}

		private void metroLabel21_Click(object sender, EventArgs e)
		{

		}

		private void sfNumericTextBox13_TextChanged(object sender, EventArgs e)
		{

		}

		private void metroLabel22_Click(object sender, EventArgs e)
		{

		}

		private void sfNumericTextBox14_TextChanged(object sender, EventArgs e)
		{

		}

		private void metroLabel23_Click(object sender, EventArgs e)
		{

		}

		private void sfNumericTextBox15_TextChanged(object sender, EventArgs e)
		{

		}

		private void metroLabel24_Click(object sender, EventArgs e)
		{

		}

		private void sfNumericTextBox16_TextChanged(object sender, EventArgs e)
		{

		}

		private void metroLabel25_Click(object sender, EventArgs e)
		{

		}

		private void sfNumericTextBox17_TextChanged(object sender, EventArgs e)
		{

		}

		private void metroLabel26_Click(object sender, EventArgs e)
		{

		}

		private void sfNumericTextBox18_TextChanged(object sender, EventArgs e)
		{

		}

		private void metroLabel27_Click(object sender, EventArgs e)
		{

		}

		private void metroLabel18_Click(object sender, EventArgs e)
		{

		}

		private void sfNumericTextBox10_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
