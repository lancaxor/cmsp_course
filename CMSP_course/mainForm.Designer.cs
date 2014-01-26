namespace CMSP_course
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.MuUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.SigmaUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.alnaliticBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.mainProgress = new System.Windows.Forms.ProgressBar();
            this.mainStatus = new System.Windows.Forms.Label();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.intervalUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.itersUpDown = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.iterationsNeu = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.rightBorderUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.leftBorderUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.upBorgerUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.authLbl = new System.Windows.Forms.Label();
            this.verLbl = new System.Windows.Forms.Label();
            this.copyLbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.showBtn = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.MuUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SigmaUpDown)).BeginInit();
            this.MainTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itersUpDown)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsNeu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightBorderUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftBorderUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upBorgerUpDown)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MuUpDown
            // 
            this.MuUpDown.DecimalPlaces = 5;
            this.MuUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.MuUpDown.Location = new System.Drawing.Point(224, 19);
            this.MuUpDown.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.MuUpDown.Minimum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            -2147483648});
            this.MuUpDown.Name = "MuUpDown";
            this.MuUpDown.Size = new System.Drawing.Size(168, 22);
            this.MuUpDown.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mu (параметр сдвига):";
            // 
            // SigmaUpDown
            // 
            this.SigmaUpDown.DecimalPlaces = 5;
            this.SigmaUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.SigmaUpDown.Location = new System.Drawing.Point(224, 47);
            this.SigmaUpDown.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.SigmaUpDown.Name = "SigmaUpDown";
            this.SigmaUpDown.Size = new System.Drawing.Size(168, 22);
            this.SigmaUpDown.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sigma (Масштаб) (>0):";
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(352, 277);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(105, 23);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // alnaliticBtn
            // 
            this.alnaliticBtn.Location = new System.Drawing.Point(228, 277);
            this.alnaliticBtn.Name = "alnaliticBtn";
            this.alnaliticBtn.Size = new System.Drawing.Size(105, 23);
            this.alnaliticBtn.TabIndex = 2;
            this.alnaliticBtn.Text = "Аналитич.";
            this.alnaliticBtn.UseVisualStyleBackColor = true;
            this.alnaliticBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(351, 248);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(105, 23);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start!";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Количество итераций:";
            // 
            // mainProgress
            // 
            this.mainProgress.Location = new System.Drawing.Point(12, 219);
            this.mainProgress.Name = "mainProgress";
            this.mainProgress.Size = new System.Drawing.Size(440, 23);
            this.mainProgress.TabIndex = 9;
            // 
            // mainStatus
            // 
            this.mainStatus.AutoSize = true;
            this.mainStatus.Location = new System.Drawing.Point(209, 222);
            this.mainStatus.Name = "mainStatus";
            this.mainStatus.Size = new System.Drawing.Size(46, 17);
            this.mainStatus.TabIndex = 10;
            this.mainStatus.Text = "label4";
            this.mainStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.tabPage1);
            this.MainTabControl.Controls.Add(this.tabPage2);
            this.MainTabControl.Controls.Add(this.tabPage3);
            this.MainTabControl.Location = new System.Drawing.Point(12, 12);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(444, 191);
            this.MainTabControl.TabIndex = 6;
            this.MainTabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.intervalUpDown);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.itersUpDown);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.MuUpDown);
            this.tabPage1.Controls.Add(this.SigmaUpDown);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(436, 162);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "МОФ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // intervalUpDown
            // 
            this.intervalUpDown.Location = new System.Drawing.Point(224, 106);
            this.intervalUpDown.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.intervalUpDown.Name = "intervalUpDown";
            this.intervalUpDown.Size = new System.Drawing.Size(168, 22);
            this.intervalUpDown.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Количество интервалов:";
            // 
            // itersUpDown
            // 
            this.itersUpDown.Location = new System.Drawing.Point(224, 78);
            this.itersUpDown.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.itersUpDown.Name = "itersUpDown";
            this.itersUpDown.Size = new System.Drawing.Size(168, 22);
            this.itersUpDown.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.iterationsNeu);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.rightBorderUpDown);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.leftBorderUpDown);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.upBorgerUpDown);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(436, 162);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Метод  Неймана";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // iterationsNeu
            // 
            this.iterationsNeu.Location = new System.Drawing.Point(224, 103);
            this.iterationsNeu.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.iterationsNeu.Name = "iterationsNeu";
            this.iterationsNeu.Size = new System.Drawing.Size(168, 22);
            this.iterationsNeu.TabIndex = 3;
            this.iterationsNeu.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Количество итераций:";
            // 
            // rightBorderUpDown
            // 
            this.rightBorderUpDown.Location = new System.Drawing.Point(224, 75);
            this.rightBorderUpDown.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.rightBorderUpDown.Name = "rightBorderUpDown";
            this.rightBorderUpDown.Size = new System.Drawing.Size(168, 22);
            this.rightBorderUpDown.TabIndex = 2;
            this.rightBorderUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Правая граница:";
            // 
            // leftBorderUpDown
            // 
            this.leftBorderUpDown.Location = new System.Drawing.Point(224, 47);
            this.leftBorderUpDown.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.leftBorderUpDown.Minimum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            -2147483648});
            this.leftBorderUpDown.Name = "leftBorderUpDown";
            this.leftBorderUpDown.Size = new System.Drawing.Size(168, 22);
            this.leftBorderUpDown.TabIndex = 1;
            this.leftBorderUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Левая граница:";
            // 
            // upBorgerUpDown
            // 
            this.upBorgerUpDown.Location = new System.Drawing.Point(224, 19);
            this.upBorgerUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.upBorgerUpDown.Name = "upBorgerUpDown";
            this.upBorgerUpDown.Size = new System.Drawing.Size(168, 22);
            this.upBorgerUpDown.TabIndex = 0;
            this.upBorgerUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Верхняя граница:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.authLbl);
            this.tabPage3.Controls.Add(this.verLbl);
            this.tabPage3.Controls.Add(this.copyLbl);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(436, 162);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "About...";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(246, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 142);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(46, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(192, 17);
            this.label15.TabIndex = 2;
            this.label15.Text = " стохастических процессов\"";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(219, 17);
            this.label14.TabIndex = 2;
            this.label14.Text = "\"Компьютерное моделирование";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(173, 17);
            this.label13.TabIndex = 2;
            this.label13.Text = "Курсовая по дисциплине";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Версия:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Разработал:";
            // 
            // authLbl
            // 
            this.authLbl.AutoSize = true;
            this.authLbl.Location = new System.Drawing.Point(137, 84);
            this.authLbl.Name = "authLbl";
            this.authLbl.Size = new System.Drawing.Size(46, 17);
            this.authLbl.TabIndex = 0;
            this.authLbl.Text = "label9";
            // 
            // verLbl
            // 
            this.verLbl.AutoSize = true;
            this.verLbl.Location = new System.Drawing.Point(137, 101);
            this.verLbl.Name = "verLbl";
            this.verLbl.Size = new System.Drawing.Size(46, 17);
            this.verLbl.TabIndex = 0;
            this.verLbl.Text = "label9";
            // 
            // copyLbl
            // 
            this.copyLbl.AutoSize = true;
            this.copyLbl.Location = new System.Drawing.Point(38, 127);
            this.copyLbl.Name = "copyLbl";
            this.copyLbl.Size = new System.Drawing.Size(46, 17);
            this.copyLbl.TabIndex = 0;
            this.copyLbl.Text = "label9";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(104, 277);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(105, 23);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save to...";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(104, 248);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(105, 23);
            this.loadBtn.TabIndex = 3;
            this.loadBtn.Text = "Load From...";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // showBtn
            // 
            this.showBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.showBtn.Location = new System.Drawing.Point(228, 248);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(105, 23);
            this.showBtn.TabIndex = 1;
            this.showBtn.Text = "Результат";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.CheckedChanged += new System.EventHandler(this.showBtn_CheckedChanged);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 315);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.mainStatus);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.mainProgress);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.alnaliticBtn);
            this.Controls.Add(this.exitBtn);
            this.Name = "mainForm";
            this.Text = "Hyperbolic Secant Distribution";
            ((System.ComponentModel.ISupportInitialize)(this.MuUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SigmaUpDown)).EndInit();
            this.MainTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itersUpDown)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsNeu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightBorderUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftBorderUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upBorgerUpDown)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown MuUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown SigmaUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button alnaliticBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar mainProgress;
        private System.Windows.Forms.Label mainStatus;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.NumericUpDown itersUpDown;
        private System.Windows.Forms.NumericUpDown intervalUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox showBtn;
        private System.Windows.Forms.NumericUpDown rightBorderUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown leftBorderUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown upBorgerUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown iterationsNeu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label copyLbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label verLbl;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label authLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

