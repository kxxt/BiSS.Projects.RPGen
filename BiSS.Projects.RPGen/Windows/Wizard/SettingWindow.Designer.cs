namespace BiSS.Projects.RPGen.Windows.Wizard
{
	partial class SettingWindow
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
			this.windows10Btn21 = new BiSS.Projects.RPGen.Windows.Windows10Btn2();
			this.windows10Btn22 = new BiSS.Projects.RPGen.Windows.Windows10Btn2();
			this.windows10Btn23 = new BiSS.Projects.RPGen.Windows.Windows10Btn2();
			this.SuspendLayout();
			// 
			// subTitle
			// 
			this.subTitle.Size = new System.Drawing.Size(250, 21);
			this.subTitle.Text = "在这里你可以对应用程序进行设置";
			// 
			// title
			// 
			this.title.Size = new System.Drawing.Size(151, 30);
			this.title.Text = "应用程序设置";
			// 
			// windows10Btn21
			// 
			this.windows10Btn21.AccessibleName = "Button";
			this.windows10Btn21.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
			this.windows10Btn21.Location = new System.Drawing.Point(13, 58);
			this.windows10Btn21.Name = "windows10Btn21";
			this.windows10Btn21.Size = new System.Drawing.Size(246, 28);
			this.windows10Btn21.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.windows10Btn21.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.windows10Btn21.Style.ForeColor = System.Drawing.Color.Black;
			this.windows10Btn21.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.windows10Btn21.Style.HoverForeColor = System.Drawing.Color.Black;
			this.windows10Btn21.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
			this.windows10Btn21.TabIndex = 5;
			this.windows10Btn21.Text = "恢复初始设置";
			this.windows10Btn21.Click += new System.EventHandler(this.windows10Btn21_Click);
			// 
			// windows10Btn22
			// 
			this.windows10Btn22.AccessibleName = "Button";
			this.windows10Btn22.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
			this.windows10Btn22.Location = new System.Drawing.Point(13, 126);
			this.windows10Btn22.Name = "windows10Btn22";
			this.windows10Btn22.Size = new System.Drawing.Size(246, 28);
			this.windows10Btn22.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.windows10Btn22.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.windows10Btn22.Style.ForeColor = System.Drawing.Color.Black;
			this.windows10Btn22.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.windows10Btn22.Style.HoverForeColor = System.Drawing.Color.Black;
			this.windows10Btn22.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
			this.windows10Btn22.TabIndex = 8;
			this.windows10Btn22.Text = "显示日志窗口";
			this.windows10Btn22.Click += new System.EventHandler(this.windows10Btn22_Click);
			// 
			// windows10Btn23
			// 
			this.windows10Btn23.AccessibleName = "Button";
			this.windows10Btn23.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
			this.windows10Btn23.Location = new System.Drawing.Point(13, 92);
			this.windows10Btn23.Name = "windows10Btn23";
			this.windows10Btn23.Size = new System.Drawing.Size(246, 28);
			this.windows10Btn23.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.windows10Btn23.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.windows10Btn23.Style.ForeColor = System.Drawing.Color.Black;
			this.windows10Btn23.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.windows10Btn23.Style.HoverForeColor = System.Drawing.Color.Black;
			this.windows10Btn23.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
			this.windows10Btn23.TabIndex = 9;
			this.windows10Btn23.Text = "启动 / 关闭 调试模式";
			this.windows10Btn23.Click += new System.EventHandler(this.windows10Btn23_Click);
			// 
			// SettingWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(273, 182);
			this.Controls.Add(this.windows10Btn23);
			this.Controls.Add(this.windows10Btn22);
			this.Controls.Add(this.windows10Btn21);
			this.Name = "SettingWindow";
			this.Text = "设置";
			this.Controls.SetChildIndex(this.title, 0);
			this.Controls.SetChildIndex(this.subTitle, 0);
			this.Controls.SetChildIndex(this.windows10Btn21, 0);
			this.Controls.SetChildIndex(this.windows10Btn22, 0);
			this.Controls.SetChildIndex(this.windows10Btn23, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Windows10Btn2 windows10Btn21;
		private Windows10Btn2 windows10Btn22;
		private Windows10Btn2 windows10Btn23;
	}
}