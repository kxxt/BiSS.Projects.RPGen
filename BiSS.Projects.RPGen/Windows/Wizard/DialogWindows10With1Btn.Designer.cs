namespace BiSS.Projects.RPGen.Windows.Wizard
{
	partial class DialogWindows10With1Btn
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
			this.BottomPanel = new System.Windows.Forms.Panel();
			this.Btn = new BiSS.Projects.RPGen.Windows.Windows10Btn1();
			this.BottomPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// BottomPanel
			// 
			this.BottomPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BottomPanel.BackColor = System.Drawing.Color.DarkGray;
			this.BottomPanel.Controls.Add(this.Btn);
			this.BottomPanel.Location = new System.Drawing.Point(0, 192);
			this.BottomPanel.Margin = new System.Windows.Forms.Padding(0);
			this.BottomPanel.Name = "BottomPanel";
			this.BottomPanel.Size = new System.Drawing.Size(860, 100);
			this.BottomPanel.TabIndex = 5;
			// 
			// Btn
			// 
			this.Btn.AccessibleName = "Button";
			this.Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
			this.Btn.Location = new System.Drawing.Point(703, 33);
			this.Btn.Name = "Btn";
			this.Btn.Size = new System.Drawing.Size(144, 41);
			this.Btn.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
			this.Btn.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(166)))));
			this.Btn.Style.FocusedForeColor = System.Drawing.Color.White;
			this.Btn.Style.ForeColor = System.Drawing.Color.White;
			this.Btn.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(184)))));
			this.Btn.Style.HoverForeColor = System.Drawing.Color.White;
			this.Btn.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(166)))));
			this.Btn.Style.PressedForeColor = System.Drawing.Color.White;
			this.Btn.TabIndex = 0;
			this.Btn.Text = "下一步(&N)";
			// 
			// DialogWindows10With1Btn
			// 
			this.AcceptButton = this.Btn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(863, 297);
			this.Controls.Add(this.BottomPanel);
			this.Name = "DialogWindows10With1Btn";
			this.Text = "DialogWindows10With1Btn";
			this.Load += new System.EventHandler(this.DialogWindows10With1Btn_Load);
			this.Controls.SetChildIndex(this.title, 0);
			this.Controls.SetChildIndex(this.subTitle, 0);
			this.Controls.SetChildIndex(this.BottomPanel, 0);
			this.BottomPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		public System.Windows.Forms.Panel BottomPanel;
		public Windows10Btn1 Btn;
	}
}