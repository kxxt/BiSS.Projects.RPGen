namespace BiSS.Projects.RPGen.Windows
{
	partial class LogWindow
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.metroButton1 = new MetroFramework.Controls.MetroButton();
			this.metroButton2 = new MetroFramework.Controls.MetroButton();
			this.metroButton3 = new MetroFramework.Controls.MetroButton();
			this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.splitContainer1.Panel1.Controls.Add(this.metroButton1);
			this.splitContainer1.Panel1.Controls.Add(this.metroButton2);
			this.splitContainer1.Panel1.Controls.Add(this.metroButton3);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.splitContainer1.Panel2.Controls.Add(this.metroTextBox1);
			this.splitContainer1.Size = new System.Drawing.Size(478, 566);
			this.splitContainer1.SplitterDistance = 159;
			this.splitContainer1.TabIndex = 0;
			// 
			// metroButton1
			// 
			this.metroButton1.Dock = System.Windows.Forms.DockStyle.Top;
			this.metroButton1.Location = new System.Drawing.Point(0, 194);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new System.Drawing.Size(159, 97);
			this.metroButton1.TabIndex = 5;
			this.metroButton1.Text = "Copy";
			this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
			// 
			// metroButton2
			// 
			this.metroButton2.Dock = System.Windows.Forms.DockStyle.Top;
			this.metroButton2.Location = new System.Drawing.Point(0, 97);
			this.metroButton2.Name = "metroButton2";
			this.metroButton2.Size = new System.Drawing.Size(159, 97);
			this.metroButton2.TabIndex = 6;
			this.metroButton2.Text = "Clear";
			this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// metroButton3
			// 
			this.metroButton3.Dock = System.Windows.Forms.DockStyle.Top;
			this.metroButton3.Location = new System.Drawing.Point(0, 0);
			this.metroButton3.Name = "metroButton3";
			this.metroButton3.Size = new System.Drawing.Size(159, 97);
			this.metroButton3.TabIndex = 7;
			this.metroButton3.Text = "Copy Then Clear";
			this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// metroTextBox1
			// 
			this.metroTextBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.metroTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.metroTextBox1.ForeColor = System.Drawing.Color.White;
			this.metroTextBox1.Location = new System.Drawing.Point(0, 0);
			this.metroTextBox1.MaxLength = 131068;
			this.metroTextBox1.Multiline = true;
			this.metroTextBox1.Name = "metroTextBox1";
			this.metroTextBox1.ReadOnly = true;
			this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.metroTextBox1.Size = new System.Drawing.Size(315, 566);
			this.metroTextBox1.TabIndex = 4;
			this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// LogWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(478, 566);
			this.Controls.Add(this.splitContainer1);
			this.Name = "LogWindow";
			this.Text = "LogWindow";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private MetroFramework.Controls.MetroButton metroButton1;
		private MetroFramework.Controls.MetroButton metroButton2;
		private MetroFramework.Controls.MetroButton metroButton3;
		internal MetroFramework.Controls.MetroTextBox metroTextBox1;
	}
}