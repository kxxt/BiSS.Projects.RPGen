namespace BiSS.Projects.RPGen.Windows
{
	partial class SettingsWindiow
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.debugEnabledToggle = new MetroFramework.Controls.MetroToggle();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.closebtn = new RsWork.UI.Controls.ModernButton();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.windows10Btn21 = new BiSS.Projects.RPGen.Windows.Windows10Btn2();
			this.windows10Btn11 = new BiSS.Projects.RPGen.Windows.Windows10Btn1();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// title
			// 
			this.title.Size = new System.Drawing.Size(236, 46);
			this.title.Text = "应用程序设置";
			// 
			// Context
			// 
			this.Context.Size = new System.Drawing.Size(122, 21);
			this.Context.Text = "非技术人员勿动";
			// 
			// debugEnabledToggle
			// 
			this.debugEnabledToggle.AutoSize = true;
			this.debugEnabledToggle.DisplayStatus = false;
			this.debugEnabledToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.debugEnabledToggle.Location = new System.Drawing.Point(201, 93);
			this.debugEnabledToggle.Name = "debugEnabledToggle";
			this.debugEnabledToggle.Size = new System.Drawing.Size(50, 30);
			this.debugEnabledToggle.TabIndex = 2;
			this.debugEnabledToggle.Text = "Off";
			this.debugEnabledToggle.UseVisualStyleBackColor = true;
			this.debugEnabledToggle.CheckedChanged += new System.EventHandler(this.debugEnabledToggle_CheckedChanged);
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.CustomBackground = true;
			this.metroLabel1.CustomForeColor = true;
			this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel1.ForeColor = System.Drawing.Color.White;
			this.metroLabel1.Location = new System.Drawing.Point(17, 93);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(178, 25);
			this.metroLabel1.Style = MetroFramework.MetroColorStyle.Orange;
			this.metroLabel1.TabIndex = 3;
			this.metroLabel1.Text = "Debug Mode Enabled";
			// 
			// closebtn
			// 
			this.closebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.closebtn.BackColor = System.Drawing.Color.Transparent;
			this.closebtn.BorderColor = System.Drawing.Color.White;
			this.closebtn.DisabledBorderColor = System.Drawing.Color.DarkGray;
			this.closebtn.DisabledForeColor = System.Drawing.Color.DarkGray;
			this.closebtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.closebtn.FlatAppearance.BorderSize = 2;
			this.closebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.closebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closebtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.closebtn.ForeColor = System.Drawing.Color.White;
			this.closebtn.Location = new System.Drawing.Point(722, 8);
			this.closebtn.Name = "closebtn";
			this.closebtn.Size = new System.Drawing.Size(32, 32);
			this.closebtn.TabIndex = 4;
			this.closebtn.Text = "X";
			this.closebtn.UseVisualStyleBackColor = false;
			this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.CustomBackground = true;
			this.metroLabel2.CustomForeColor = true;
			this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel2.ForeColor = System.Drawing.Color.White;
			this.metroLabel2.Location = new System.Drawing.Point(17, 126);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(120, 25);
			this.metroLabel2.Style = MetroFramework.MetroColorStyle.Orange;
			this.metroLabel2.TabIndex = 6;
			this.metroLabel2.Text = "Show Cell Info";
			// 
			// metroToggle1
			// 
			this.metroToggle1.AutoSize = true;
			this.metroToggle1.DisplayStatus = false;
			this.metroToggle1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.metroToggle1.Location = new System.Drawing.Point(201, 126);
			this.metroToggle1.Name = "metroToggle1";
			this.metroToggle1.Size = new System.Drawing.Size(50, 30);
			this.metroToggle1.TabIndex = 5;
			this.metroToggle1.Text = "Off";
			this.metroToggle1.UseVisualStyleBackColor = true;
			this.metroToggle1.CheckedChanged += new System.EventHandler(this.metroToggle1_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.windows10Btn21);
			this.groupBox1.Controls.Add(this.windows10Btn11);
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(15, 162);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(739, 349);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "调试函数";
			// 
			// windows10Btn21
			// 
			this.windows10Btn21.AccessibleName = "Button";
			this.windows10Btn21.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
			this.windows10Btn21.Location = new System.Drawing.Point(6, 67);
			this.windows10Btn21.Name = "windows10Btn21";
			this.windows10Btn21.Size = new System.Drawing.Size(174, 28);
			this.windows10Btn21.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.windows10Btn21.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.windows10Btn21.Style.ForeColor = System.Drawing.Color.Black;
			this.windows10Btn21.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.windows10Btn21.Style.HoverForeColor = System.Drawing.Color.Black;
			this.windows10Btn21.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
			this.windows10Btn21.TabIndex = 1;
			this.windows10Btn21.Text = "T Analyzer->GetSeprators\r\n";
			this.windows10Btn21.Click += new System.EventHandler(this.windows10Btn21_Click);
			// 
			// windows10Btn11
			// 
			this.windows10Btn11.AccessibleName = "Button";
			this.windows10Btn11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
			this.windows10Btn11.Location = new System.Drawing.Point(6, 32);
			this.windows10Btn11.Name = "windows10Btn11";
			this.windows10Btn11.Size = new System.Drawing.Size(174, 28);
			this.windows10Btn11.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
			this.windows10Btn11.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(166)))));
			this.windows10Btn11.Style.FocusedForeColor = System.Drawing.Color.White;
			this.windows10Btn11.Style.ForeColor = System.Drawing.Color.White;
			this.windows10Btn11.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(184)))));
			this.windows10Btn11.Style.HoverForeColor = System.Drawing.Color.White;
			this.windows10Btn11.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(166)))));
			this.windows10Btn11.Style.PressedForeColor = System.Drawing.Color.White;
			this.windows10Btn11.TabIndex = 0;
			this.windows10Btn11.Text = "T Analyzer->CountInRange()";
			this.windows10Btn11.Click += new System.EventHandler(this.windows10Btn11_Click);
			// 
			// SettingsWindiow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.ClientSize = new System.Drawing.Size(766, 528);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.metroToggle1);
			this.Controls.Add(this.closebtn);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.debugEnabledToggle);
			this.Name = "SettingsWindiow";
			this.TopMost = false;
			this.Controls.SetChildIndex(this.debugEnabledToggle, 0);
			this.Controls.SetChildIndex(this.metroLabel1, 0);
			this.Controls.SetChildIndex(this.title, 0);
			this.Controls.SetChildIndex(this.Context, 0);
			this.Controls.SetChildIndex(this.closebtn, 0);
			this.Controls.SetChildIndex(this.metroToggle1, 0);
			this.Controls.SetChildIndex(this.metroLabel2, 0);
			this.Controls.SetChildIndex(this.groupBox1, 0);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroToggle debugEnabledToggle;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private RsWork.UI.Controls.ModernButton closebtn;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroToggle metroToggle1;
		private System.Windows.Forms.GroupBox groupBox1;
		private Windows10Btn1 windows10Btn11;
		private Windows10Btn2 windows10Btn21;
	}
}
