using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting.ChartTypes;
using System.Threading;

namespace CMSP_course
{
    public partial class Graph : Form
    {
        private bool bdrawed = false;
        private double dXmin = 0.0, dXmax = 1.0, dStep = 0.1;
        private long xnum = 100;
        private double[]dXvals,dYvals;
        Thread countThread;
        bool runthread = false;
        System.Windows.Forms.DataVisualization.Charting.Series ser = new System.Windows.Forms.DataVisualization.Charting.Series("Hyperbolic  Secant Distribution");

        //////////  PROGRESS BAR VARIABLES   /////////////////
        int progPos = 0;

        public Graph()
        {
            InitializeComponent();
            bdrawed = false;
            distrChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            distrChart.Series[0].Name = "Hyperbolic  Secant Distribution0";
            dXvals = new double[10];
            dYvals = fillYArray(dXvals);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (runthread)
                countThread.Abort();
            progTimer.Stop();
            this.Close();
        }

        private double[] fillYArray(double[] x)
        {
            long len=x.Length;
            double[] y = new double[len];
            mainForm mf = new mainForm();
            for (long l = 0; l < len; l++)
                y[l] = mf.hsPlotRasp(x[l]);
               // y[l] = mf.hsIntegralPlotRasp(x[l]);
               
            return y;
        }

        private void CountAndDraw()
        {
            dXvals = new double[xnum];
            double d = dXmin;
            for (long l = 0; l < xnum; d += dStep, l++)
            {
                dXvals[l] = d;
                progPos++;
            }
            dYvals = fillYArray(dXvals);
            for (long i = 0; i < xnum; i++)
            {
                ser.Points.AddXY(dXvals[i], dYvals[i]);
                progPos++;
            }
            runthread = false;
        }

        private void Draw_Click(object sender, EventArgs e)
        {
            /****************** Проверки лишними не бывают (Михаил Фленов (с)) ***************/
            if (!bdrawed)
            {
                bdrawed = true;
                this.DrawBtn.Text = "Redraw";
            }
            dXmin = Double.Parse(this.xminUpDown.Value.ToString());
            dXmax = Double.Parse(this.xmaxUpDown.Value.ToString());
            if (dXmax <= dXmin)
            {
                MessageBox.Show("Xmax must be greater then Xmin!");
                return;
            }
            dStep = Double.Parse(this.stepUpDown.Value.ToString());
            if (dStep == 0)
            {
                MessageBox.Show("Step must be > 0!");
                return;
            }

            /****************** Вдруг там дохрена вычислений надо... ***************/
            xnum = (Int64)Double.Parse(((dXmax - dXmin) / dStep).ToString());
            if (xnum > 7000)
                if (MessageBox.Show("Обработка столь большого числа данных займет некоторое время. Нажмите ОК для продолжения или уменьшите шаг либо пределы вычислений.", "Continue Counting?", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    return;
            /****************** Очистка после предыдущего вычисления ***************/
            ser = new System.Windows.Forms.DataVisualization.Charting.Series("Hyperbolic  Secant Distribution");
            ser.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            runthread = false;
            /****************** Вычисление и сопряженные с ним трудности... ***************/
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 2 * (int)xnum;
            progPos = 0;
            this.statusLbl.Text = "Обработка данных...";
            this.distrChart.Series.Clear();
            countThread = new Thread(delegate()
            {
                this.CountAndDraw();
            });
            runthread = true;
            progTimer.Start();
            countThread.Start();
        }

        private void IncProg(object sender, EventArgs e)
        {
            this.progressBar1.Value=progPos;
            //if (!runthread)
            if (this.progressBar1.Value == this.progressBar1.Maximum)
            {
                this.progTimer.Stop();
                this.endComputing();
            }
        }

        private void endComputing()
        {
            this.distrChart.Series.Clear();
            this.statusLbl.Text = "Перерисовка графика...";
            this.distrChart.Series.Add(ser);
            this.statusLbl.Text = "Вычисления закончены.";
        }

        private void DefaultBtn_Click(object sender, EventArgs e)
        {
            this.xminUpDown.Value = new Decimal(-10.0);
            this.xmaxUpDown.Value = new Decimal(10.0);
            this.stepUpDown.Value = new Decimal(0.1);
        }
    }
}
