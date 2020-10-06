namespace Covid_19
{
    partial class Covid19
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Covid19Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Covid19Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // Covid19Chart
            // 
            this.Covid19Chart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            chartArea1.AxisX.Interval = 5D;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelAutoFitMaxFontSize = 20;
            chartArea1.AxisX.LabelStyle.Angle = -90;
            chartArea1.BorderWidth = 2;
            chartArea1.Name = "ChartArea1";
            this.Covid19Chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Covid19Chart.Legends.Add(legend1);
            this.Covid19Chart.Location = new System.Drawing.Point(-4, -1);
            this.Covid19Chart.Name = "Covid19Chart";
            this.Covid19Chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "confirmedCases";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "confirmedDeaths";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Legend = "Legend1";
            series3.Name = "confirmedRecovered";
            this.Covid19Chart.Series.Add(series1);
            this.Covid19Chart.Series.Add(series2);
            this.Covid19Chart.Series.Add(series3);
            this.Covid19Chart.Size = new System.Drawing.Size(1930, 686);
            this.Covid19Chart.TabIndex = 0;
            this.Covid19Chart.Text = "covid19Chart";
            // 
            // Covid19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1924, 682);
            this.Controls.Add(this.Covid19Chart);
            this.Name = "Covid19";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Covid19Chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Covid19Chart;
    }
}

