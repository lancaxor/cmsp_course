namespace CMSP_course
{
    partial class Graph
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
            this.distrChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.DrawBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.xminUpDown = new System.Windows.Forms.NumericUpDown();
            this.xmaxUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.stepUpDown = new System.Windows.Forms.NumericUpDown();
            this.progTimer = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.DefaultBtn = new System.Windows.Forms.Button();
            this.statusLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.distrChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xminUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xmaxUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // distrChart
            // 
            chartArea1.Name = "ChartArea1";
            this.distrChart.ChartAreas.Add(chartArea1);
            this.distrChart.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Name = "Legend1";
            this.distrChart.Legends.Add(legend1);
            this.distrChart.Location = new System.Drawing.Point(0, 0);
            this.distrChart.Name = "distrChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.distrChart.Series.Add(series1);
            this.distrChart.Size = new System.Drawing.Size(569, 391);
            this.distrChart.TabIndex = 5;
            this.distrChart.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DrawBtn
            // 
            this.DrawBtn.Location = new System.Drawing.Point(482, 450);
            this.DrawBtn.Name = "DrawBtn";
            this.DrawBtn.Size = new System.Drawing.Size(75, 23);
            this.DrawBtn.TabIndex = 3;
            this.DrawBtn.Text = "Draw";
            this.DrawBtn.UseVisualStyleBackColor = true;
            this.DrawBtn.Click += new System.EventHandler(this.Draw_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "X min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "X max";
            // 
            // xminUpDown
            // 
            this.xminUpDown.DecimalPlaces = 5;
            this.xminUpDown.Location = new System.Drawing.Point(61, 410);
            this.xminUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.xminUpDown.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.xminUpDown.Name = "xminUpDown";
            this.xminUpDown.Size = new System.Drawing.Size(120, 22);
            this.xminUpDown.TabIndex = 0;
            // 
            // xmaxUpDown
            // 
            this.xmaxUpDown.DecimalPlaces = 5;
            this.xmaxUpDown.Location = new System.Drawing.Point(61, 439);
            this.xmaxUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.xmaxUpDown.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.xmaxUpDown.Name = "xmaxUpDown";
            this.xmaxUpDown.Size = new System.Drawing.Size(120, 22);
            this.xmaxUpDown.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Step:";
            // 
            // stepUpDown
            // 
            this.stepUpDown.DecimalPlaces = 5;
            this.stepUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.stepUpDown.Location = new System.Drawing.Point(247, 410);
            this.stepUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.stepUpDown.Name = "stepUpDown";
            this.stepUpDown.Size = new System.Drawing.Size(120, 22);
            this.stepUpDown.TabIndex = 2;
            // 
            // progTimer
            // 
            this.progTimer.Interval = 200;
            this.progTimer.Tick += new System.EventHandler(this.IncProg);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 479);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(464, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // DefaultBtn
            // 
            this.DefaultBtn.Location = new System.Drawing.Point(482, 421);
            this.DefaultBtn.Name = "DefaultBtn";
            this.DefaultBtn.Size = new System.Drawing.Size(75, 23);
            this.DefaultBtn.TabIndex = 7;
            this.DefaultBtn.Text = "Default";
            this.DefaultBtn.UseVisualStyleBackColor = true;
            this.DefaultBtn.Click += new System.EventHandler(this.DefaultBtn_Click);
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(217, 482);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(55, 17);
            this.statusLbl.TabIndex = 8;
            this.statusLbl.Text = "READY";
            // 
            // Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 513);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.DefaultBtn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.xmaxUpDown);
            this.Controls.Add(this.stepUpDown);
            this.Controls.Add(this.xminUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DrawBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.distrChart);
            this.Name = "Graph";
            this.Text = "Graph";
            ((System.ComponentModel.ISupportInitialize)(this.distrChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xminUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xmaxUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart distrChart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DrawBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown xminUpDown;
        private System.Windows.Forms.NumericUpDown xmaxUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown stepUpDown;
        private System.Windows.Forms.Timer progTimer;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button DefaultBtn;
        private System.Windows.Forms.Label statusLbl;
    }
}