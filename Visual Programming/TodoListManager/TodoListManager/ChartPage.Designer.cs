namespace TodoListManager
{
    partial class ChartPage
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartPage));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuLineChart1 = new Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart(this.components);
            this.chart_tasks = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_back = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart_tasks)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuLineChart1
            // 
            this.bunifuLineChart1.BackgroundColor = System.Drawing.Color.Indigo;
            this.bunifuLineChart1.BorderCapStyle = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.LineCaps.Butt;
            this.bunifuLineChart1.BorderColor = System.Drawing.Color.Purple;
            this.bunifuLineChart1.BorderDash = null;
            this.bunifuLineChart1.BorderDashOffset = 0D;
            this.bunifuLineChart1.BorderJoin = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.BorderJoinStyles.Miter;
            this.bunifuLineChart1.BorderWidth = 3;
            this.bunifuLineChart1.CubicInterpolationMode = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.CubicInterpolationModes.Default;
            this.bunifuLineChart1.Data = null;
            this.bunifuLineChart1.Fill = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.FillOptions.Blank;
            this.bunifuLineChart1.Label = "Line Chart";
            this.bunifuLineChart1.LineTension = 0.4D;
            this.bunifuLineChart1.Order = 0;
            this.bunifuLineChart1.PointBackgroundColor = System.Drawing.Color.Empty;
            this.bunifuLineChart1.PointBorderColor = System.Drawing.Color.Empty;
            this.bunifuLineChart1.PointBorderWidth = 1;
            this.bunifuLineChart1.PointHitRadius = 1;
            this.bunifuLineChart1.PointHoverBackgroundColor = System.Drawing.Color.Empty;
            this.bunifuLineChart1.PointHoverBorderColor = System.Drawing.Color.Empty;
            this.bunifuLineChart1.PointHoverBorderWidth = 4;
            this.bunifuLineChart1.PointHoverRadius = 1;
            this.bunifuLineChart1.PointRadius = 3;
            this.bunifuLineChart1.PointRotation = 0;
            this.bunifuLineChart1.PointStyle = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.PointStyles.Circle;
            this.bunifuLineChart1.ShowLine = true;
            this.bunifuLineChart1.SpanGaps = false;
            this.bunifuLineChart1.SteppedLine = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.SteppedLineStyles.False;
            this.bunifuLineChart1.TargetCanvas = null;
            // 
            // chart_tasks
            // 
            this.chart_tasks.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chart_tasks.BorderlineColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.Name = "ChartArea1";
            this.chart_tasks.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_tasks.Legends.Add(legend1);
            this.chart_tasks.Location = new System.Drawing.Point(12, 12);
            this.chart_tasks.Name = "chart_tasks";
            this.chart_tasks.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_tasks.Series.Add(series1);
            this.chart_tasks.Size = new System.Drawing.Size(532, 336);
            this.chart_tasks.TabIndex = 0;
            this.chart_tasks.Text = "chart_tasks";
            // 
            // btn_back
            // 
            this.btn_back.AllowAnimations = true;
            this.btn_back.AllowMouseEffects = true;
            this.btn_back.AllowToggling = false;
            this.btn_back.AnimationSpeed = 200;
            this.btn_back.AutoGenerateColors = false;
            this.btn_back.AutoRoundBorders = false;
            this.btn_back.AutoSizeLeftIcon = true;
            this.btn_back.AutoSizeRightIcon = true;
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_back.ButtonText = "Back";
            this.btn_back.ButtonTextMarginLeft = 0;
            this.btn_back.ColorContrastOnClick = 45;
            this.btn_back.ColorContrastOnHover = 45;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_back.CustomizableEdges = borderEdges1;
            this.btn_back.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_back.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_back.DisabledFillColor = System.Drawing.Color.Empty;
            this.btn_back.DisabledForecolor = System.Drawing.Color.Empty;
            this.btn_back.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_back.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.DimGray;
            this.btn_back.IconLeft = null;
            this.btn_back.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_back.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_back.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_back.IconMarginLeft = 11;
            this.btn_back.IconPadding = 10;
            this.btn_back.IconRight = null;
            this.btn_back.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_back.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_back.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_back.IconSize = 25;
            this.btn_back.IdleBorderColor = System.Drawing.Color.Empty;
            this.btn_back.IdleBorderRadius = 0;
            this.btn_back.IdleBorderThickness = 0;
            this.btn_back.IdleFillColor = System.Drawing.Color.Empty;
            this.btn_back.IdleIconLeftImage = null;
            this.btn_back.IdleIconRightImage = null;
            this.btn_back.IndicateFocus = false;
            this.btn_back.Location = new System.Drawing.Point(12, 380);
            this.btn_back.Name = "btn_back";
            this.btn_back.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_back.OnDisabledState.BorderRadius = 10;
            this.btn_back.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_back.OnDisabledState.BorderThickness = 1;
            this.btn_back.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_back.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_back.OnDisabledState.IconLeftImage = null;
            this.btn_back.OnDisabledState.IconRightImage = null;
            this.btn_back.onHoverState.BorderColor = System.Drawing.Color.Silver;
            this.btn_back.onHoverState.BorderRadius = 10;
            this.btn_back.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_back.onHoverState.BorderThickness = 1;
            this.btn_back.onHoverState.FillColor = System.Drawing.Color.Silver;
            this.btn_back.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_back.onHoverState.IconLeftImage = null;
            this.btn_back.onHoverState.IconRightImage = null;
            this.btn_back.OnIdleState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_back.OnIdleState.BorderRadius = 10;
            this.btn_back.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_back.OnIdleState.BorderThickness = 1;
            this.btn_back.OnIdleState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btn_back.OnIdleState.ForeColor = System.Drawing.Color.DimGray;
            this.btn_back.OnIdleState.IconLeftImage = null;
            this.btn_back.OnIdleState.IconRightImage = null;
            this.btn_back.OnPressedState.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_back.OnPressedState.BorderRadius = 10;
            this.btn_back.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_back.OnPressedState.BorderThickness = 1;
            this.btn_back.OnPressedState.FillColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_back.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.btn_back.OnPressedState.IconLeftImage = null;
            this.btn_back.OnPressedState.IconRightImage = null;
            this.btn_back.Size = new System.Drawing.Size(87, 27);
            this.btn_back.TabIndex = 12;
            this.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_back.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_back.TextMarginLeft = 0;
            this.btn_back.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_back.UseDefaultRadiusAndThickness = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // ChartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(556, 419);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.chart_tasks);
            this.Name = "ChartPage";
            this.Text = "ChartPage";
            this.Load += new System.EventHandler(this.ChartPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_tasks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart bunifuLineChart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_tasks;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_back;
    }
}