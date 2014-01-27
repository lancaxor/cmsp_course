namespace CMSP_course
{
    partial class ResultForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.resChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.resList = new System.Windows.Forms.ListBox();
            this.clearList = new System.Windows.Forms.CheckBox();
            this.clearGraph = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.resChart)).BeginInit();
            this.SuspendLayout();
            // 
            // resChart
            // 
            this.resChart.BorderlineColor = System.Drawing.Color.PaleGreen;
            chartArea9.Name = "ChartArea1";
            this.resChart.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.resChart.Legends.Add(legend9);
            this.resChart.Location = new System.Drawing.Point(209, 0);
            this.resChart.Name = "resChart";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.resChart.Series.Add(series9);
            this.resChart.Size = new System.Drawing.Size(565, 468);
            this.resChart.TabIndex = 0;
            this.resChart.Text = "chart1";
            // 
            // resList
            // 
            this.resList.FormattingEnabled = true;
            this.resList.ItemHeight = 16;
            this.resList.Location = new System.Drawing.Point(0, 0);
            this.resList.Name = "resList";
            this.resList.ScrollAlwaysVisible = true;
            this.resList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.resList.Size = new System.Drawing.Size(203, 468);
            this.resList.TabIndex = 1;
            // 
            // clearList
            // 
            this.clearList.AutoSize = true;
            this.clearList.Location = new System.Drawing.Point(12, 474);
            this.clearList.Name = "clearList";
            this.clearList.Size = new System.Drawing.Size(136, 21);
            this.clearList.TabIndex = 2;
            this.clearList.Text = "Очищать список";
            this.clearList.UseVisualStyleBackColor = true;
            // 
            // clearGraph
            // 
            this.clearGraph.AutoSize = true;
            this.clearGraph.Location = new System.Drawing.Point(154, 474);
            this.clearGraph.Name = "clearGraph";
            this.clearGraph.Size = new System.Drawing.Size(141, 21);
            this.clearGraph.TabIndex = 3;
            this.clearGraph.Text = "Очищать График";
            this.clearGraph.UseVisualStyleBackColor = true;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 505);
            this.Controls.Add(this.clearGraph);
            this.Controls.Add(this.clearList);
            this.Controls.Add(this.resList);
            this.Controls.Add(this.resChart);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ResultForm";
            this.ShowInTaskbar = false;
            this.Text = "ResultForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ResultForm_FormClosing);
            this.Resize += new System.EventHandler(this.ResultForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.resChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart resChart;
        private System.Windows.Forms.ListBox resList;
        private System.Windows.Forms.CheckBox clearList;
        private System.Windows.Forms.CheckBox clearGraph;
    }
}