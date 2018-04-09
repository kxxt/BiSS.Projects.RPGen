namespace BiSS.Projects.RPGen.Windows.Wizard
{
	partial class WebWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebWindow));
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.windows10Btn21 = new BiSS.Projects.RPGen.Windows.Windows10Btn2();
			this.windows10Btn11 = new BiSS.Projects.RPGen.Windows.Windows10Btn1();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
			this.tableLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// subTitle
			// 
			this.subTitle.Enabled = false;
			this.subTitle.Location = new System.Drawing.Point(89, 71);
			this.subTitle.Size = new System.Drawing.Size(0, 21);
			this.subTitle.Text = "";
			this.subTitle.Visible = false;
			// 
			// title
			// 
			this.title.Location = new System.Drawing.Point(219, 95);
			this.title.Size = new System.Drawing.Size(0, 30);
			this.title.Text = "";
			// 
			// webBrowser1
			// 
			this.webBrowser1.AllowNavigation = false;
			this.tableLayoutPanel1.SetColumnSpan(this.webBrowser1, 3);
			this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser1.Location = new System.Drawing.Point(3, 70);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(1038, 354);
			this.webBrowser1.TabIndex = 4;
			this.webBrowser1.WebBrowserShortcutsEnabled = false;
			// 
			// windows10Btn21
			// 
			this.windows10Btn21.AccessibleName = "Button";
			this.windows10Btn21.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.windows10Btn21.Dock = System.Windows.Forms.DockStyle.Fill;
			this.windows10Btn21.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
			this.windows10Btn21.Location = new System.Drawing.Point(837, 45);
			this.windows10Btn21.Name = "windows10Btn21";
			this.windows10Btn21.Size = new System.Drawing.Size(204, 19);
			this.windows10Btn21.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.windows10Btn21.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.windows10Btn21.Style.ForeColor = System.Drawing.Color.Black;
			this.windows10Btn21.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.windows10Btn21.Style.HoverForeColor = System.Drawing.Color.Black;
			this.windows10Btn21.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
			this.windows10Btn21.TabIndex = 1;
			this.windows10Btn21.Text = "不同意并退出程序";
			this.windows10Btn21.Click += new System.EventHandler(this.windows10Btn21_Click);
			// 
			// windows10Btn11
			// 
			this.windows10Btn11.AccessibleName = "Button";
			this.windows10Btn11.Dock = System.Windows.Forms.DockStyle.Fill;
			this.windows10Btn11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
			this.windows10Btn11.Location = new System.Drawing.Point(629, 45);
			this.windows10Btn11.Name = "windows10Btn11";
			this.windows10Btn11.Size = new System.Drawing.Size(202, 19);
			this.windows10Btn11.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
			this.windows10Btn11.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(166)))));
			this.windows10Btn11.Style.FocusedForeColor = System.Drawing.Color.White;
			this.windows10Btn11.Style.ForeColor = System.Drawing.Color.White;
			this.windows10Btn11.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(184)))));
			this.windows10Btn11.Style.HoverForeColor = System.Drawing.Color.White;
			this.windows10Btn11.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(166)))));
			this.windows10Btn11.Style.PressedForeColor = System.Drawing.Color.White;
			this.windows10Btn11.TabIndex = 0;
			this.windows10Btn11.Text = "同意并继续";
			this.windows10Btn11.Click += new System.EventHandler(this.windows10Btn11_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.ForeColor = System.Drawing.Color.DarkOrange;
			this.label3.Location = new System.Drawing.Point(3, 42);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(492, 24);
			this.label3.TabIndex = 3;
			this.label3.Text = "请仔细阅读以下用户许可协议 , 关闭本窗口表示您同意本协议";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.AutoEllipsis = true;
			this.label2.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.label2, 2);
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Font = new System.Drawing.Font("微软雅黑", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(828, 42);
			this.label2.TabIndex = 2;
			this.label2.Text = "用户许可协议";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.windows10Btn11, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.windows10Btn21, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.webBrowser1, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 2, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1044, 427);
			this.tableLayoutPanel1.TabIndex = 5;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.label1);
			this.flowLayoutPanel1.Controls.Add(this.metroToggle1);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(837, 3);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(167, 36);
			this.flowLayoutPanel1.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 31);
			this.label1.TabIndex = 1;
			this.label1.Text = "不再自动显示";
			// 
			// metroToggle1
			// 
			this.metroToggle1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.metroToggle1.AutoSize = true;
			this.metroToggle1.Checked = true;
			this.metroToggle1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.metroToggle1.DisplayStatus = false;
			this.metroToggle1.Location = new System.Drawing.Point(108, 3);
			this.metroToggle1.Name = "metroToggle1";
			this.metroToggle1.Size = new System.Drawing.Size(50, 25);
			this.metroToggle1.Style = MetroFramework.MetroColorStyle.Orange;
			this.metroToggle1.TabIndex = 0;
			this.metroToggle1.Text = "On";
			this.metroToggle1.Theme = MetroFramework.MetroThemeStyle.Light;
			this.metroToggle1.UseVisualStyleBackColor = true;
			this.metroToggle1.CheckedChanged += new System.EventHandler(this.metroToggle1_CheckedChanged);
			// 
			// WebWindow
			// 
			this.AcceptButton = this.windows10Btn11;
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.windows10Btn21;
			this.ClientSize = new System.Drawing.Size(1048, 431);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = true;
			this.Name = "WebWindow";
			this.Text = "成绩报告生成器 用户许可协议";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WebWindow_FormClosing);
			this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
			this.Controls.SetChildIndex(this.title, 0);
			this.Controls.SetChildIndex(this.subTitle, 0);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private Windows10Btn1 windows10Btn11;
		private Windows10Btn2 windows10Btn21;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private MetroFramework.Controls.MetroToggle metroToggle1;
	}
}