using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Collections;
using System.Reflection;

namespace CMSP_course
{
    public partial class mainForm : Form
    {
        double sig, mu;
        Thread computeTh;
        System.Windows.Forms.Timer timer;
        long _iters = 1;
        int intervals=1;
        bool runCount=false;
        Random r;
        ResultForm resForm;
        bool endCounting = false;
        int currentProgPos = 0;
        string methName = "";
        double upBorder, leftBorder, rightBorder;
        double[] resRands;
        int methodChar = 0;
        List<PointF> points;
        private double dXmin = 0.0, dXmax = 1.0, dStep = 0.1;
        private long xnum = 100;
        private double[] dXvals, dYvals;

        public mainForm()
        {
            InitializeComponent();
            dXvals = new double[10];
            dYvals = fillYArray(dXvals);
            sig = 1.0;
            mu = 0.0;
            this.SigmaUpDown.Value = new decimal(1.0);
            this.itersUpDown.Value = new decimal(1000);
            this.intervalUpDown.Value = new decimal(20);
            this.mainStatus.Text = "Ready";
            methName = "Hiperbolic Secant Distribution (c)";
            initTimer();
            resForm = new ResultForm();
            this.r = new Random();
            points = new List<PointF>();
            upBorder = 1.0;
            leftBorder = 0.0;
            rightBorder = 1.0;
        }

        private void initTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Tick += this.TickTimer;
            timer.Interval = 200;
        }

        private void TickTimer(object sender, EventArgs e)              //обработка тика таймера (тут будет рисовка прогресс-бара)
        {
            this.mainProgress.Value = currentProgPos;
            if (endCounting || (!runCount))
            {
                this.timer.Stop();
                this.initTimer();
                this.startBtn.Text = "Start";
                this.mainStatus.Text = "Finished!";
                this.setStatusCenter();
                this.runCount = false;
                this.endCounting = true;
                if (endCounting)
                    switch (methodChar)
                    {
                        case 0:             //IFM
                            sendDataToResultDlg();
                            break;
                        case 1:             //Neuman
                            sendNeumanDataToResDlg();
                            break;
                        case 2:
                            sendAnaliticDataToResDlg();
                            break;
                        default:
                            MessageBox.Show("Some incorrect...");
                            break;
                    }
            }

        }

        public double sech(double x)        //гиперболический секанс (равен 1/ch(x))
        {
            return (2 / (Math.Pow(Math.E, x) + Math.Pow(Math.E, -x)));
        }

        public double hsPlotRasp(double x)                              // Плотность распределения гиперсеканс распределения
        {
            double shParam = ((Math.PI * (x - mu)) / (2 * sig)) / (2 * sig);
            return sech(shParam);
        }

        public double hsIntegralPlotRasp(double x){
            return (2/Math.PI*Math.Atan(Math.Exp((Math.PI*(x-mu)/(2*sig)))));
        }

        public double hsGetRand()
        {
            double res = 0.0;
            double dRand = r.NextDouble();
            res = mu + (2 * sig / Math.PI) * Math.Log(Math.Abs(Math.Tan((Math.PI * dRand) / 2)), Math.E);
            return res;
        }

        public double hsObratFooRasp(double p)
        {
            if (p < 0 || p > 1)
            {
                MessageBox.Show("Bad value of P in hsObratFooRasp(): " + p.ToString());
                return -100.500;
            }
            return (mu + (2.0 * sig / Math.PI * Math.Log(Math.Tan(Math.PI / 2.0 * p))));
        }

        private void SetValues()
        {
            sig = Double.Parse(this.SigmaUpDown.Value.ToString());
            mu = Double.Parse(this.MuUpDown.Value.ToString());
            this._iters = Int32.Parse(this.itersUpDown.Value.ToString());
            this.intervals=Int32.Parse(this.intervalUpDown.Value.ToString());
            this.upBorder = Double.Parse(this.upBorgerUpDown.Value.ToString());
            this.leftBorder= Double.Parse(this.leftBorderUpDown.Value.ToString());
            this.rightBorder = Double.Parse(this.rightBorderUpDown.Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)      //Показать аналитический график
        {
            System.Diagnostics.Process.Start("Help.txt");
        }
        
        private void button5_Click(object sender, EventArgs e)          // Начать/завершить рассчет
        {
            SetValues();
            int curTab = MainTabControl.SelectedIndex;
            this.endCounting = false;
            this.timer.Start();
            if (!runCount)                                  // Not running
            {
                this.startBtn.Text = "Stop";
                this.currentProgPos = 0;
                this.mainProgress.Value = 0;                
                this.mainStatus.Text = "Running...";
                runCount = true;
            }
            else                                            // running: do stop!
            {
                this.startBtn.Text = "Start";
                this.mainStatus.Text = "Stopped";
                runCount = false;
                this.endCounting = true;
                return;
            }
            methodChar = curTab;
            switch (curTab)
            {
                case 0:
                    this.mainProgress.Maximum = (int)this._iters;
                    methName = "Метод Обратных Функций";
                    this.computeTh = new Thread(delegate()
                    {
                        this.countIFMVals();
                    });
                    resRands = new double[_iters];
                    break;
                case 1:
                    this.methName = "Метод Неймана";
                    this.points.Clear();
                    this._iters = Int32.Parse(iterationsNeu.Value.ToString());
                    this.mainProgress.Maximum = (int)this._iters;
                    if (this.leftBorder > this.rightBorder)
                    {
                        MessageBox.Show("Левая граница должна быть меньше правой!");
                        this.mainStatus.Text = "Counting failed!";
                        timer.Stop();
                        this.setStatusCenter();
                        runCount = false;
                        endCounting = true;
                        return;
                    }
                    this.computeTh = new Thread(delegate()
                    {
                       this.countNeumanMethod();
                    });
                    break;
                case 2:
                    this.methName = "Аналитический метод";
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
                    /****************** Вычисление и сопряженные с ним трудности... ***************/
                    mainProgress.Minimum = 0;
                    mainProgress.Maximum = 2 * (int)xnum;
                    currentProgPos = 0;
                    computeTh = new Thread(delegate()
                    {
                        this.CountAndDraw();
                    });
                    break;

                default:
                    MessageBox.Show("Def");
                    this.computeTh = new Thread(delegate()
                    {
                        int axax_He_geJIau_eTo = 100500;
                    });
                    break;
            }
            
            this.computeTh.Start();
            this.setStatusCenter();
        }
        /********************************************************************************\
         *                  COUNT IFM (Метод Обратных Функций)                          *
        \********************************************************************************/
        private void countIFMVals()
        {
            for (int i = 0; i < this._iters; i++)
            {
                currentProgPos = i;
                this.resRands[i] = hsGetRand();
                if (this.endCounting)
                    return;
            }
            this.endCounting = true;
        }

        /********************************************************************************\
         *                   COUNT Neuman (Метод Неймана)                               *
        \********************************************************************************/
        private void countNeumanMethod()
        {
            for (int i = 0; i < _iters; i++)
            {
                if (this.endCounting)
                    return;
                currentProgPos = i;
                double xExp = 0.0, yExp = 0.0;
                xExp = (this.rightBorder - this.leftBorder) * r.NextDouble() + this.leftBorder;
                yExp = this.upBorder * r.NextDouble();
                if (yExp <= this.hsPlotRasp(xExp))
                    points.Add(new PointF((float)xExp, (float)yExp));
                else continue;
            }
            this.endCounting = true;
        }

        /********************************************************************************\
         *                   COUNT Analitic (Аналитический метод)                       *
        \********************************************************************************/
        private void CountAndDraw()
        {
            if (this.endCounting)
                return;
            dXvals = new double[xnum];
            double d = dXmin;
            for (long l = 0; l < xnum; d += dStep, l++)
            {
                if (this.endCounting)
                    return;
                dXvals[l] = d;
                currentProgPos++;
            }
            dYvals = fillYArray(dXvals);
            for (long i = 0; i < xnum; i++)
            {
                if (this.endCounting)
                    return;
                currentProgPos++;
            }
            this.endCounting = true;
        }

        private double[] fillYArray(double[] x)
        {
            long len = x.Length;
            double[] y = new double[len];
            for (long l = 0; l < len; l++)
                y[l] = this.hsPlotRasp(x[l]);
            return y;
        }

        /********************************************************************************/

        private void button3_Click(object sender, EventArgs e)  //Save current to file
        {
            SetValues();
            this.mainStatus.Text = "Saving...";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files|*.txt|Hyperbolic Secant Distribution Data|*.hsdat|All Files|*.*";
            StreamWriter sf;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                switch (methodChar)
                {
                    case 0:             //IFM
                        if (resRands == null)
                        {
                            MessageBox.Show("Сначала необходимо выполнить рассчет! Нажмите кнопку Start.");
                            this.mainStatus.Text = "Saving failed";
                            this.setStatusCenter();
                            return;
                        }
                        sf = new StreamWriter(sfd.FileName);
                        for(int i=0;i<resRands.Length;i++)
                            sf.WriteLine(resRands[i]);
                        sf.Close();
                        break;
                    case 1:             //Neuman
                        if (points == null)
                        {
                            MessageBox.Show("Сначала необходимо выполнить рассчет! Нажмите кнопку Start.");
                            this.mainStatus.Text = "Saving failed";
                            this.setStatusCenter();
                            return;
                        }
                        sf = new StreamWriter(sfd.FileName);
                        for (int i = 0; i < points.Count; i++)
                            sf.WriteLine(points[i].X);
                        sf.Close();
                        break;
                    default:
                        break;
                }
                if(ResultForm.openedForm)
                    this.resForm.saveGraphToBmp(sfd.FileName);
                this.mainStatus.Text = "Data successfully saved!";
            }
            this.setStatusCenter();
        }

        private void setStatusCenter()
        {
            this.mainStatus.Left = this.mainProgress.Left + (this.mainProgress.Width - this.mainStatus.Width) / 2;
        }
        private void button4_Click(object sender, EventArgs e)  //Load From File
        {
            this.mainStatus.Text = "Loading file...";
            setStatusCenter();
            SetValues();
            StreamReader sr;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files|*.txt|Hyperbolic Secant Distribution Data|*.hsdat|All Files|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                switch (methodChar)
                {
                    case 0:             //IFM
                        sr = new StreamReader(ofd.FileName);
                        double tmpmu=0.0,tmpsig=0.0,tmpiters=0.0,tmpcols=0.0;
                        if ((!Double.TryParse(sr.ReadLine(), out tmpmu))||
                            (!Double.TryParse(sr.ReadLine(), out tmpsig))||
                            (!Double.TryParse(sr.ReadLine(), out tmpiters))||
                            (!Double.TryParse(sr.ReadLine(), out tmpcols)))
                        {
                            MessageBox.Show("Bad input file format!");
                            this.mainStatus.Text = "Loading Failed!";
                            setStatusCenter();
                            return;
                        }
                        sr.Close();
                        if (((tmpmu > Double.Parse(MuUpDown.Maximum.ToString())) || (tmpmu < Double.Parse(MuUpDown.Minimum.ToString()))) ||
                            ((tmpsig > Double.Parse(SigmaUpDown.Maximum.ToString())) || (tmpsig < Double.Parse(SigmaUpDown.Minimum.ToString()))) ||
                            ((tmpiters > Double.Parse(itersUpDown.Maximum.ToString())) || (tmpiters < Double.Parse(itersUpDown.Minimum.ToString()))) ||
                            ((tmpcols > Double.Parse(intervalUpDown.Maximum.ToString())) || (tmpcols < Double.Parse(intervalUpDown.Minimum.ToString()))))
                        {
                            MessageBox.Show("Прочитанные из файла значения лежат вне допустимых пределов.");
                            this.mainStatus.Text = "Loading Failed!";
                            setStatusCenter();
                            return;
                        }
                        this.MuUpDown.Value = new decimal(tmpmu);
                        this.SigmaUpDown.Value = new decimal(tmpsig);
                        this.itersUpDown.Value = new decimal(tmpiters);
                        this.intervalUpDown.Value = new decimal(tmpcols);
                        this.SetValues();
                        break;
                    case 1:             //Neuman
                        sr = new StreamReader(ofd.FileName);
                        double tmpup = 0.0, tmpleft= 0.0, tmpright = 0.0, tmpits = 0.0;
                        if ((!Double.TryParse(sr.ReadLine(), out tmpup)) ||
                            (!Double.TryParse(sr.ReadLine(), out tmpleft)) ||
                            (!Double.TryParse(sr.ReadLine(), out tmpright)) ||
                            (!Double.TryParse(sr.ReadLine(), out tmpits)))
                        {
                            MessageBox.Show("Bad input file format!");
                            this.mainStatus.Text = "Loading Failed!";
                            setStatusCenter();
                            return;
                        }
                        sr.Close();
                        if (((tmpup > Double.Parse(upBorgerUpDown.Maximum.ToString())) || (tmpup < Double.Parse(upBorgerUpDown.Minimum.ToString()))) ||
                            ((tmpleft > Double.Parse(leftBorderUpDown.Maximum.ToString())) || (tmpleft < Double.Parse(leftBorderUpDown.Minimum.ToString()))) ||
                            ((tmpright > Double.Parse(rightBorderUpDown.Maximum.ToString())) || (tmpright < Double.Parse(rightBorderUpDown.Minimum.ToString()))) ||
                            ((tmpits > Double.Parse(iterationsNeu.Maximum.ToString())) || (tmpits < Double.Parse(iterationsNeu.Minimum.ToString()))))
                        {
                            MessageBox.Show("Прочитанные из файла значения лежат вне допустимых пределов.");
                            this.mainStatus.Text = "Loading Failed!";
                            setStatusCenter();
                            return;
                        }
                        this.upBorgerUpDown.Value = new decimal(tmpup);
                        this.leftBorderUpDown.Value = new decimal(tmpleft);
                        this.rightBorderUpDown.Value = new decimal(tmpright);
                        this.iterationsNeu.Value = new decimal(tmpits);
                        this.SetValues();
                        break;
                    default:
                        break;
                }
            }
            this.mainStatus.Text = "File loaded successfull!";
            setStatusCenter();
        }

        private void sendDataToResultDlg(){
            this.resForm.rands = new double[_iters];
            this.resForm.colNum = intervals;
            this.resForm.rands = this.resRands;
            this.resForm.mainReDrawMethod();
        }

        private void sendNeumanDataToResDlg()
        {
            this.resForm.points = this.points;
            this.resForm.borders[0] = (int)this.upBorder + 1;
            this.resForm.borders[1] = (int)this.leftBorder - 1;
            this.resForm.borders[2] = (int)this.rightBorder + 1;
            this.resForm.NeumanDrawMethod();
        }

        private void sendAnaliticDataToResDlg()
        {
            this.resForm.AnaliticDrawMethod(this.dXvals, dYvals);
        }

        private void showBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (this.showBtn.Checked)
            {
                this.resForm.Show();
            }
            else
            {
                this.resForm.Hide();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            methodChar = this.MainTabControl.SelectedIndex;
            if (this.MainTabControl.SelectedTab == tabPage3)
            {
                loadBtn.Enabled = false;
                saveBtn.Enabled = false;
                startBtn.Enabled = false;
                showBtn.Enabled = false;
                alnaliticBtn.Enabled = false;
                verLbl.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
                copyLbl.Text = ((AssemblyCopyrightAttribute) Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false)[0]).Copyright;
                authLbl.Text = "Ляшенко А.Ю.";
            }
            else
            {
                loadBtn.Enabled = true;
                saveBtn.Enabled = true;
                startBtn.Enabled = true;
                showBtn.Enabled = true;
                alnaliticBtn.Enabled = true;
            }
        }

        private void DefaultBtn_Click(object sender, EventArgs e)
        {
            this.xminUpDown.Value = -10;
            this.xmaxUpDown.Value = 10;
            this.stepUpDown.Value = new Decimal(0.1);
        }
    }
}