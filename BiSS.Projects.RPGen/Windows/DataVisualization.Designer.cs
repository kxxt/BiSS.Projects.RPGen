namespace BiSS.Projects.RPGen.Windows
{
	partial class DataVisualization
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
			this.components = new System.ComponentModel.Container();
			Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries1 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
			Syncfusion.Windows.Forms.Chart.ChartDataBindModel chartDataBindModel1 = new Syncfusion.Windows.Forms.Chart.ChartDataBindModel();
			Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo1 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
			Syncfusion.Windows.Forms.Chart.ChartLineInfo chartLineInfo1 = new Syncfusion.Windows.Forms.Chart.ChartLineInfo();
			Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem chartToolBarSaveItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem();
			Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem chartToolBarCopyItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem();
			Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem chartToolBarPrintItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem();
			Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem chartToolBarPrintPreviewItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem();
			Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter chartToolBarSplitter1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter();
			Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem chartToolBarPaletteItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem();
			Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem chartToolBarStyleItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem();
			Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem chartToolBarTypeItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem();
			Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem chartToolBarSeries3DItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem();
			Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem chartToolBarShowLegendItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.lDChartDataSourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.sfScrollFrame = new Syncfusion.WinForms.Controls.SfScrollFrame();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.pivotChart1 = new Syncfusion.Windows.Forms.PivotChart.PivotChart();
			this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chartControl2 = new Syncfusion.Windows.Forms.Chart.ChartControl();
			((System.ComponentModel.ISupportInitialize)(this.lDChartDataSourceBindingSource)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
			this.SuspendLayout();
			// 
			// lDChartDataSourceBindingSource
			// 
			this.lDChartDataSourceBindingSource.DataSource = typeof(BiSS.Projects.RPGen.Structure.LDChartDataSource);
			// 
			// sfScrollFrame
			// 
			this.sfScrollFrame.Control = this.flowLayoutPanel1;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.chartControl1);
			this.flowLayoutPanel1.Controls.Add(this.chart1);
			this.flowLayoutPanel1.Controls.Add(this.pivotChart1);
			this.flowLayoutPanel1.Controls.Add(this.chart2);
			this.flowLayoutPanel1.Controls.Add(this.chartControl2);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 2);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(1316, 876);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// chartControl1
			// 
			this.chartControl1.BorderAppearance.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
			this.chartControl1.BorderAppearance.Interior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
			this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
			this.chartControl1.ChartArea.BorderColor = System.Drawing.Color.Transparent;
			this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
			this.chartControl1.ChartArea.CursorReDraw = false;
			this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White);
			this.chartControl1.CustomPalette = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(144)))), ((int)(((byte)(34))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(190)))), ((int)(((byte)(82))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(222)))), ((int)(((byte)(37))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(66)))), ((int)(((byte)(153))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(90)))), ((int)(((byte)(36))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(38)))))};
			this.chartControl1.DataSourceName = "lDChartDataSourceBindingSource";
			this.chartControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.chartControl1.IsWindowLess = false;
			// 
			// 
			// 
			this.chartControl1.Legend.Location = new System.Drawing.Point(288, 81);
			this.chartControl1.Localize = null;
			this.chartControl1.Location = new System.Drawing.Point(3, 3);
			this.chartControl1.Name = "chartControl1";
			this.chartControl1.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Metro;
			this.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.LightGray;
			this.chartControl1.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
			this.chartControl1.PrimaryXAxis.Margin = true;
			this.chartControl1.PrimaryXAxis.TitleColor = System.Drawing.Color.Black;
			this.chartControl1.PrimaryXAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
			this.chartControl1.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.LightGray;
			this.chartControl1.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
			this.chartControl1.PrimaryYAxis.Margin = true;
			this.chartControl1.PrimaryYAxis.TitleColor = System.Drawing.Color.Black;
			this.chartControl1.PrimaryYAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
			chartSeries1.FancyToolTip.ResizeInsideSymbol = true;
			chartSeries1.Name = "成绩分布";
			chartSeries1.Resolution = 0D;
			chartDataBindModel1.DataSource = this.lDChartDataSourceBindingSource;
			chartDataBindModel1.XName = "Zh.Value";
			chartDataBindModel1.YNames = new string[] {
        "M.HasValue"};
			chartSeries1.SeriesModel = chartDataBindModel1;
			chartSeries1.StackingGroup = "Default Group";
			chartSeries1.Style.AltTagFormat = "";
			chartSeries1.Style.Border.Color = System.Drawing.Color.Transparent;
			chartSeries1.Style.DrawTextShape = false;
			chartSeries1.Style.Font.Facename = "宋体";
			chartSeries1.Style.Font.Size = 12F;
			chartSeries1.Style.TextOrientation = Syncfusion.Windows.Forms.Chart.ChartTextOrientation.Down;
			chartLineInfo1.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
			chartLineInfo1.Color = System.Drawing.SystemColors.ControlText;
			chartLineInfo1.DashPattern = null;
			chartLineInfo1.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
			chartLineInfo1.Width = 1F;
			chartCustomShapeInfo1.Border = chartLineInfo1;
			chartCustomShapeInfo1.Color = System.Drawing.SystemColors.HighlightText;
			chartCustomShapeInfo1.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
			chartSeries1.Style.TextShape = chartCustomShapeInfo1;
			chartSeries1.Text = "成绩分布";
			this.chartControl1.Series.Add(chartSeries1);
			this.chartControl1.Size = new System.Drawing.Size(400, 300);
			this.chartControl1.Skins = Syncfusion.Windows.Forms.Chart.Skins.Metro;
			this.chartControl1.Style3D = true;
			this.chartControl1.TabIndex = 0;
			this.chartControl1.Text = "本班成绩分布情况";
			// 
			// 
			// 
			this.chartControl1.Title.Font = new System.Drawing.Font("Segoe UI", 16F);
			this.chartControl1.Title.Name = "Default";
			this.chartControl1.Titles.Add(this.chartControl1.Title);
			this.chartControl1.ToolBar.EnableDefaultItems = false;
			this.chartControl1.ToolBar.Items.Add(chartToolBarSaveItem1);
			this.chartControl1.ToolBar.Items.Add(chartToolBarCopyItem1);
			this.chartControl1.ToolBar.Items.Add(chartToolBarPrintItem1);
			this.chartControl1.ToolBar.Items.Add(chartToolBarPrintPreviewItem1);
			this.chartControl1.ToolBar.Items.Add(chartToolBarSplitter1);
			this.chartControl1.ToolBar.Items.Add(chartToolBarPaletteItem1);
			this.chartControl1.ToolBar.Items.Add(chartToolBarStyleItem1);
			this.chartControl1.ToolBar.Items.Add(chartToolBarTypeItem1);
			this.chartControl1.ToolBar.Items.Add(chartToolBarSeries3DItem1);
			this.chartControl1.ToolBar.Items.Add(chartToolBarShowLegendItem1);
			// 
			// chart1
			// 
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(409, 3);
			this.chart1.Name = "chart1";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(400, 300);
			this.chart1.TabIndex = 2;
			this.chart1.Text = "chart1";
			this.chart1.Click += new System.EventHandler(this.chart1_Click);
			// 
			// pivotChart1
			// 
			this.pivotChart1.ChartTypes = Syncfusion.Windows.Forms.PivotChart.PivotChartTypes.Column;
			this.pivotChart1.CustomPalette = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(196))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(173)))), ((int)(((byte)(71)))))};
			this.pivotChart1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.pivotChart1.Location = new System.Drawing.Point(815, 3);
			this.pivotChart1.MinimumSize = new System.Drawing.Size(300, 250);
			this.pivotChart1.Name = "pivotChart1";
			this.pivotChart1.Size = new System.Drawing.Size(400, 324);
			this.pivotChart1.TabIndex = 1;
			this.pivotChart1.Text = "pivotChart1";
			this.pivotChart1.UpdateManager = null;
			// 
			// chart2
			// 
			chartArea2.Name = "ChartArea1";
			this.chart2.ChartAreas.Add(chartArea2);
			this.chart2.DataSource = this.lDChartDataSourceBindingSource;
			legend2.Name = "Legend1";
			this.chart2.Legends.Add(legend2);
			this.chart2.Location = new System.Drawing.Point(3, 333);
			this.chart2.Name = "chart2";
			this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar;
			series2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			series2.Legend = "Legend1";
			series2.Name = "平均数";
			series3.ChartArea = "ChartArea1";
			series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar;
			series3.Legend = "Legend1";
			series3.Name = "中位数";
			this.chart2.Series.Add(series2);
			this.chart2.Series.Add(series3);
			this.chart2.Size = new System.Drawing.Size(300, 300);
			this.chart2.TabIndex = 3;
			this.chart2.Text = "学科成绩分布";
			// 
			// chartControl2
			// 
			this.chartControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.chartControl2.BorderAppearance.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(93)))), ((int)(((byte)(123)))));
			this.chartControl2.BorderAppearance.Interior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(190)))), ((int)(((byte)(211)))));
			this.chartControl2.ChartArea.BorderColor = System.Drawing.Color.Transparent;
			this.chartControl2.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
			this.chartControl2.ChartArea.CursorReDraw = false;
			this.chartControl2.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(5, 5, 5, 5);
			this.chartControl2.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White);
			this.chartControl2.ElementsSpacing = 5;
			this.chartControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.chartControl2.IsWindowLess = false;
			// 
			// 
			// 
			this.chartControl2.Legend.ItemsSize = new System.Drawing.Size(15, 15);
			this.chartControl2.Legend.Location = new System.Drawing.Point(60, 47);
			this.chartControl2.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Left;
			this.chartControl2.Legend.Spacing = 3;
			this.chartControl2.Legend.Visible = false;
			this.chartControl2.Localize = null;
			this.chartControl2.Location = new System.Drawing.Point(309, 333);
			this.chartControl2.Name = "chartControl2";
			this.chartControl2.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Metro;
			this.chartControl2.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.LightGray;
			this.chartControl2.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.LightSteelBlue;
			this.chartControl2.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
			this.chartControl2.PrimaryXAxis.Margin = true;
			this.chartControl2.PrimaryXAxis.Title = "学科";
			this.chartControl2.PrimaryXAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
			this.chartControl2.PrimaryYAxis.ForceZero = true;
			this.chartControl2.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.LightGray;
			this.chartControl2.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.LightSteelBlue;
			this.chartControl2.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
			this.chartControl2.PrimaryYAxis.Margin = true;
			this.chartControl2.PrimaryYAxis.Title = "分数指标";
			this.chartControl2.PrimaryYAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
			this.chartControl2.Size = new System.Drawing.Size(600, 300);
			this.chartControl2.Skins = Syncfusion.Windows.Forms.Chart.Skins.Metro;
			this.chartControl2.Style3D = true;
			this.chartControl2.TabIndex = 0;
			this.chartControl2.Text = "学科分数分布情况";
			// 
			// 
			// 
			this.chartControl2.Title.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chartControl2.Title.Name = "Default";
			this.chartControl2.Titles.Add(this.chartControl2.Title);
			// 
			// DataVisualization
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1320, 880);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "DataVisualization";
			this.Text = "DataVisualization";
			((System.ComponentModel.ISupportInitialize)(this.lDChartDataSourceBindingSource)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private Syncfusion.WinForms.Controls.SfScrollFrame sfScrollFrame;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		internal Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
		internal Syncfusion.Windows.Forms.PivotChart.PivotChart pivotChart1;
		internal System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		internal System.Windows.Forms.DataVisualization.Charting.Chart chart2;
		internal System.Windows.Forms.BindingSource lDChartDataSourceBindingSource;
		internal Syncfusion.Windows.Forms.Chart.ChartControl chartControl2;
	}
}