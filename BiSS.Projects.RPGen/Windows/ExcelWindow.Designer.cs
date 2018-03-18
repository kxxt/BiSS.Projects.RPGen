namespace BiSS.Projects.RPGen.Windows
{
	partial class ExcelWindow
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
			Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetCopyPaste spreadsheetCopyPaste1 = new Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetCopyPaste();
			Syncfusion.Windows.Forms.Spreadsheet.FormulaRangeSelectionController formulaRangeSelectionController1 = new Syncfusion.Windows.Forms.Spreadsheet.FormulaRangeSelectionController();
			this.spreadsheet1 = new Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.sfButton1 = new Syncfusion.WinForms.Controls.SfButton();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// spreadsheet1
			// 
			this.spreadsheet1.AllowCellContextMenu = false;
			this.spreadsheet1.AllowExtendRowColumnCount = true;
			this.spreadsheet1.AllowFormulaRangeSelection = true;
			this.spreadsheet1.AllowTabItemContextMenu = false;
			this.spreadsheet1.AllowZooming = true;
			spreadsheetCopyPaste1.AllowPasteOptionPopup = true;
			spreadsheetCopyPaste1.DefaultPasteOption = Syncfusion.Windows.Forms.Spreadsheet.PasteOptions.Paste;
			this.spreadsheet1.CopyPaste = spreadsheetCopyPaste1;
			this.spreadsheet1.DefaultColumnCount = 101;
			this.spreadsheet1.DefaultRowCount = 101;
			this.spreadsheet1.DisplayAlerts = true;
			this.spreadsheet1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.spreadsheet1.FileName = "Book1";
			this.spreadsheet1.FormulaBarVisibility = true;
			formulaRangeSelectionController1.AllowMouseSelection = true;
			formulaRangeSelectionController1.AllowSelectionOnEditing = true;
			this.spreadsheet1.FormulaRangeSelectionController = formulaRangeSelectionController1;
			this.spreadsheet1.IsCustomTabItemContextMenuEnabled = false;
			this.spreadsheet1.Location = new System.Drawing.Point(0, 0);
			this.spreadsheet1.Name = "spreadsheet1";
			this.spreadsheet1.SelectedTabIndex = 0;
			this.spreadsheet1.SelectedTabItem = null;
			this.spreadsheet1.ShowBusyIndicator = true;
			this.spreadsheet1.Size = new System.Drawing.Size(985, 508);
			this.spreadsheet1.TabIndex = 0;
			this.spreadsheet1.TabItemContextMenu = null;
			this.spreadsheet1.Text = "spreadsheet1";
			this.spreadsheet1.ThemeName = "Office365";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(2, 2);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.sfButton1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.spreadsheet1);
			this.splitContainer1.Size = new System.Drawing.Size(985, 558);
			this.splitContainer1.SplitterDistance = 46;
			this.splitContainer1.TabIndex = 1;
			// 
			// sfButton1
			// 
			this.sfButton1.AccessibleName = "Button";
			this.sfButton1.Dock = System.Windows.Forms.DockStyle.Top;
			this.sfButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
			this.sfButton1.ForeColor = System.Drawing.Color.Red;
			this.sfButton1.Location = new System.Drawing.Point(0, 0);
			this.sfButton1.Name = "sfButton1";
			this.sfButton1.Size = new System.Drawing.Size(985, 48);
			this.sfButton1.Style.ForeColor = System.Drawing.Color.Red;
			this.sfButton1.TabIndex = 0;
			this.sfButton1.Text = "填写完成后点此保存";
			this.sfButton1.Click += new System.EventHandler(this.sfButton1_Click);
			// 
			// ExcelWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(989, 562);
			this.Controls.Add(this.splitContainer1);
			this.Name = "ExcelWindow";
			this.Text = "ExcelWindow";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExcelWindow_FormClosing);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		public Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet spreadsheet1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private Syncfusion.WinForms.Controls.SfButton sfButton1;
	}
}