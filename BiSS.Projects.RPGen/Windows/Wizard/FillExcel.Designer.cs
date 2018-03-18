namespace BiSS.Projects.RPGen.Windows.Wizard
{
	partial class FillExcel
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
			this.BottomPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// BottomPanel
			// 
			this.BottomPanel.Location = new System.Drawing.Point(0, 220);
			this.BottomPanel.Size = new System.Drawing.Size(771, 123);
			// 
			// Btn
			// 
			this.Btn.Location = new System.Drawing.Point(607, 18);
			this.Btn.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
			this.Btn.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(166)))));
			this.Btn.Style.FocusedForeColor = System.Drawing.Color.White;
			this.Btn.Style.ForeColor = System.Drawing.Color.White;
			this.Btn.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(184)))));
			this.Btn.Style.HoverForeColor = System.Drawing.Color.White;
			this.Btn.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(166)))));
			this.Btn.Style.PressedForeColor = System.Drawing.Color.White;
			this.Btn.Click += new System.EventHandler(this.Btn_Click);
			// 
			// subtitle
			// 
			this.subTitle.Size = new System.Drawing.Size(581, 63);
			this.subTitle.Text = "应用程序将启动 Excel , 请填写此表格 , 您可以把原成绩表中的数据复制到此表中.\r\n注意:请勿修改列标题及列的顺序 ! \r\n请在填写完成后保存文件并关闭 " +
    "Excel 窗口,返回到本程序中继续操作.";
			// 
			// title
			// 
			this.title.Size = new System.Drawing.Size(611, 30);
			this.title.Text = "在接下来的过程中,你将填写一份固定格式的Excel 成绩表单";
			// 
			// FillExcel
			// 
			this.AcceptButton = null;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(768, 303);
			this.Name = "FillExcel";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "填写Excel";
			this.BottomPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
	}
}