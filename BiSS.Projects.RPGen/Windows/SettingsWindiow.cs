using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BiSS.Projects.RPGen.Debug;
using BiSS.Projects.RPGen.Op;
using BiSS.Projects.RPGen.Structure;
using static BiSS.Projects.RPGen.Structure.Level;
using static BiSS.Projects.RPGen.Structure.NfSubjects;

namespace BiSS.Projects.RPGen.Windows
{
	public partial class SettingsWindiow : RsWork.UI.Windows.ModernDialogBase
	{
		public SettingsWindiow()
		{
			InitializeComponent();
			debugEnabledToggle.Checked = Program.DebugEnabled;
			metroToggle1.Checked = Program.ShowCellInfo;
		}

		private void debugEnabledToggle_CheckedChanged(object sender, EventArgs e)
		{
			Program.DebugEnabled = debugEnabledToggle.Checked;
		}

		private void closebtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void metroToggle1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void windows10Btn11_Click(object sender, EventArgs e)
		{
			MessageBox.Show(
				"int@1: "+SampleClass.TestAnalyzerCount(1).ToString()+"\r\n"+
				"int@2 " + SampleClass.TestAnalyzerCount(2).ToString() + "\r\n" +
				"float@1: " + SampleClass.TestAnalyzerCount(3).ToString() + "\r\n" +
				"float@1: " + SampleClass.TestAnalyzerCount(4).ToString() + "\r\n" 

				);
		}

		private void windows10Btn21_Click(object sender, EventArgs e)
		{
			Dictionary<NfSubjects,float> fs=new Dictionary<NfSubjects, float>()
			{
				[Zh]=150,
				[M] = 150,
				[En] = 150,
				[P] = 100,
				[NfSubjects.C] = 100,
				[Po] = 100,
				[H] = 100,
				[G] = 100,
				[NfSubjects.B] = 100,
				[All] = 1050,
				
			};
			Dictionary<NfSubjects,Dictionary<Level,float>> spr=new Dictionary<NfSubjects, Dictionary<Level, float>>()
			{
				[Zh] =new Dictionary<Level, float>()
				{
					[A]=0.9f,
					[Level.B]=0.8f,
					[Level.C]=0.6f,
					[D]=0.0f
				} ,
				[M] = new Dictionary<Level, float>()
				{
					[A] = 0.9f,
					[Level.B] = 0.8f,
					[Level.C] = 0.6f,
					[D] = 0.0f
				},
				[En] = new Dictionary<Level, float>()
				{
					[A] = 0.9f,
					[Level.B] = 0.8f,
					[Level.C] = 0.6f,
					[D] = 0.0f
				},
				[P] = new Dictionary<Level, float>()
				{
					[A] = 0.9f,
					[Level.B] = 0.8f,
					[Level.C] = 0.6f,
					[D] = 0.0f
				},
				[NfSubjects.C] = new Dictionary<Level, float>()
				{
					[A] = 0.9f,
					[Level.B] = 0.8f,
					[Level.C] = 0.6f,
					[D] = 0.0f
				},
				[Po] = new Dictionary<Level, float>()
				{
					[A] = 0.9f,
					[Level.B] = 0.8f,
					[Level.C] = 0.6f,
					[D] = 0.0f
				},
				[H] = new Dictionary<Level, float>()
				{
					[A] = 0.9f,
					[Level.B] = 0.8f,
					[Level.C] = 0.6f,
					[D] = 0.0f
				},
				[G] = new Dictionary<Level, float>()
				{
					[A] = 0.9f,
					[Level.B] = 0.8f,
					[Level.C] = 0.6f,
					[D] = 0.0f
				},
				[NfSubjects.B] = new Dictionary<Level, float>()
				{
					[A] = 0.9f,
					[Level.B] = 0.8f,
					[Level.C] = 0.6f,
					[D] = 0.0f
				},
				[All] = new Dictionary<Level, float>()
				{
					[A] = 0.9f,
					[Level.B] = 0.8f,
					[Level.C] = 0.6f,
					[D] = 0.0f
				},
			};
			var res = Analyzer.GetSeparator(fs, spr[Zh]);
			string space = "    ";
			string tststr = "";
			foreach (var v in res)
			{
				tststr += $"{v.Key.Name()} :\r\n";
				foreach (var sc in v.Value)
				{
					tststr += (space+sc.Key.Name()+" : "+sc.Value+"\r\n");
				}
			}

			MessageBox.Show(tststr,"TEST");
		}
	}
}
