using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting.ChartTypes;

namespace CMSP_course
{
    public partial class ResultForm : Form
    {
        private const int MAXSERIES = 1024;
        public double[]rands;
        private double[] graphRands;
        public int colNum;
        public static bool openedForm=true;
        public int[]borders=new int[3];
        public List<PointF> points;
        System.Windows.Forms.DataVisualization.Charting.Series curSeries;

        public ResultForm()
        {
            InitializeComponent();
            this.dockControls();
            colNum = 1;
            rands = null;
            this.resChart.Series.Clear();
            curSeries = new System.Windows.Forms.DataVisualization.Charting.Series();
            curSeries.MarkerSize = 100;
            openedForm=true;
            points=new List<PointF>();
        }

        private void dockControls()
        {
            this.resChart.Left = this.Width / 3 + 2;
            this.resChart.Width = this.Width * 2 / 3;
            this.resList.Left = 0;
            this.resList.Width = this.Width / 3 - 2;
            this.resList.Top = 0;
            this.resList.Height = this.Height - 70;
            this.resChart.Top = 0;
            if (this.resChart.Left <= this.clearGraph.Right)
                this.resChart.Height = this.Height - 70;
            else
                this.resChart.Height = this.Height;
            this.clearGraph.Top = this.resList.Bottom + 14;
            this.clearList.Top = this.resList.Bottom + 14;
        }

        public void saveGraphToBmp(string FileName)
        {
            Bitmap b = new Bitmap(this.resChart.Width, this.resChart.Height);
            this.resChart.DrawToBitmap(b, new Rectangle(0, 0, this.resChart.Width, this.resChart.Height));
            b.Save(FileName + "_graph.bmp");
        }


        public void mainReDrawMethod()
        {
            if (this.clearList.Checked == true)
                this.resList.Items.Clear();
            for (int i = 0; i < rands.Length; i++)
                this.resList.Items.Add(rands[i].ToString());
            drawGraph("Метод Обратных Функций");
        }

        public void NeumanDrawMethod()
        {
            if (this.clearList.Checked == true)
                this.resList.Items.Clear();
            for (int i = 0; i < points.Count; i++)
                this.resList.Items.Add(points[i].X.ToString());

            if (this.clearGraph.Checked == true)
                this.resChart.Series.Clear();

            //System.Windows.Forms.DataVisualization.Charting.ChartArea chAr = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            String name = "Метод Неймана";
            for (Random r = new Random(); (this.resChart.Series.IndexOf(name) >= 0); )
                name += r.Next(9).ToString();
            curSeries = new System.Windows.Forms.DataVisualization.Charting.Series(name);
            curSeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;

            for (int i = 0; i < points.Count; i++)
                curSeries.Points.AddXY(points[i].X,points[i].Y);

            resChart.Series.Add(curSeries);
        }

        public void AnaliticDrawMethod(double []x,double[]y){
            String name = "Аналитический Метод";
            if (this.clearGraph.Checked == true)
                this.resChart.Series.Clear();
            if (this.clearList.Checked == true)
                this.resList.Items.Clear();
            for (Random r = new Random(); (this.resChart.Series.IndexOf(name) >= 0); )
                name += r.Next(9).ToString();
            curSeries = new System.Windows.Forms.DataVisualization.Charting.Series(name);
            curSeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            for (int i = 0; i < x.Length; i++)
                curSeries.Points.AddXY(x[i], y[i]);
            resChart.Series.Add(curSeries);
        }


        private void drawGraph(string name)                     //Рисование графика методом обратных функций
        {
            if (this.clearGraph.Checked == true)
                this.resChart.Series.Clear();

            for(Random r=new Random();(this.resChart.Series.IndexOf(name)>=0);)
                name += r.Next(9).ToString();

            curSeries = new System.Windows.Forms.DataVisualization.Charting.Series(name);
            this.graphRands = new double[this.colNum];
            curSeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            double minR=rands.Min();
            double oneLen = (rands.Max() - minR) / (colNum-1);
            //9405 9428 9435 9435 9438 9420  9438 9441 9435 9427
            if (oneLen == 0)
            {
                curSeries.Points.AddXY(rands.Min(), rands.Length);
                return;
            }

            for (int i = 0; i < rands.Length; i++)
            {
                int index = (int)((rands[i] - minR) / oneLen);
                graphRands[index]++;
            }

            for (int i = 0; i < graphRands.Length; i++)
            {
                curSeries.Points.AddXY((minR+i*oneLen),(graphRands[i]/graphRands.Max()));
            }
            resChart.Series.Add(curSeries);
        }

        private void ResultForm_ResizeEnd(object sender, EventArgs e)
        {
            this.dockControls();
        }

        private void ResultForm_Resize(object sender, EventArgs e)
        {
            this.dockControls();
        }

        public void ResultForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            openedForm=false;
            ResultForm res = this;
            res =  new ResultForm();
        }

        private void ResultForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);
            e.Cancel = true;
            this.Hide();
        }
    }
}
