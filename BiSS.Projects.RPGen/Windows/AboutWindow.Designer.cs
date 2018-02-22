using MetroFramework.Controls;

namespace BiSS.Projects.RPGen.Windows
{
	partial class AboutWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutWindow));
			this.label1 = new MetroFramework.Controls.MetroLabel();
			this.label2 = new MetroFramework.Controls.MetroLabel();
			this.label3 = new MetroFramework.Controls.MetroLabel();
			this.metroButton1 = new MetroFramework.Controls.MetroButton();
			this.metroButton2 = new MetroFramework.Controls.MetroButton();
			this.metroButton3 = new MetroFramework.Controls.MetroButton();
			this.metroButton4 = new MetroFramework.Controls.MetroButton();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.label1.Location = new System.Drawing.Point(23, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(535, 150);
			this.label1.TabIndex = 0;
			this.label1.Text = resources.GetString("label1.Text");
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.label2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label2.Location = new System.Drawing.Point(23, 220);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(261, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "第三方声明(Third Party Notice):";
			this.label2.Theme = MetroFramework.MetroThemeStyle.Light;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(24, 258);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(404, 38);
			this.label3.TabIndex = 2;
			this.label3.Text = "1. MetroFramework : Open Source , Licenced under the MIT licence.\r\n2. FreeSpire :" +
    " Fully Free.";
			// 
			// metroButton1
			// 
			this.metroButton1.Location = new System.Drawing.Point(27, 299);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new System.Drawing.Size(118, 38);
			this.metroButton1.TabIndex = 3;
			this.metroButton1.Text = "确定(&Y)";
			this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
			this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
			// 
			// metroButton2
			// 
			this.metroButton2.Location = new System.Drawing.Point(291, 299);
			this.metroButton2.Name = "metroButton2";
			this.metroButton2.Size = new System.Drawing.Size(118, 38);
			this.metroButton2.TabIndex = 4;
			this.metroButton2.Text = "E-mail(&E)";
			this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Light;
			this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
			// 
			// metroButton3
			// 
			this.metroButton3.Location = new System.Drawing.Point(159, 299);
			this.metroButton3.Name = "metroButton3";
			this.metroButton3.Size = new System.Drawing.Size(118, 38);
			this.metroButton3.TabIndex = 5;
			this.metroButton3.Text = "GitHub(&G)";
			this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Light;
			this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
			// 
			// metroButton4
			// 
			this.metroButton4.Location = new System.Drawing.Point(423, 299);
			this.metroButton4.Name = "metroButton4";
			this.metroButton4.Size = new System.Drawing.Size(118, 38);
			this.metroButton4.TabIndex = 6;
			this.metroButton4.Text = "Wire(&W)";
			this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Light;
			this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
			// 
			// AboutWindow
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(567, 355);
			this.ControlBox = false;
			this.Controls.Add(this.metroButton4);
			this.Controls.Add(this.metroButton3);
			this.Controls.Add(this.metroButton2);
			this.Controls.Add(this.metroButton1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutWindow";
			this.Resizable = false;
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Style = MetroFramework.MetroColorStyle.Purple;
			this.Text = "关于 Believers in Science Studio";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private MetroLabel label1;
		private MetroLabel label2;
		private MetroLabel label3;
		private MetroButton metroButton1;
		private MetroButton metroButton2;
		private MetroButton metroButton3;
		private MetroButton metroButton4;
	}
}