namespace AI_InstantAI
{
   partial class InstantAIForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstantAIForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.timer_getData = new System.Windows.Forms.Timer(this.components);
            this.button_start = new System.Windows.Forms.Button();
            this.label_YCoordinateMax = new System.Windows.Forms.Label();
            this.label_YCoordinateMin = new System.Windows.Forms.Label();
            this.label_XCoordinateMax = new System.Windows.Forms.Label();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.label_XCoordinateMin = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label_YCoordinateMiddle = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_chanCount = new System.Windows.Forms.ComboBox();
            this.label_chanCount = new System.Windows.Forms.Label();
            this.instantAiCtrl1 = new Automation.BDaq.InstantAiCtrl(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.FFT = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LowFrequency = new System.Windows.Forms.TextBox();
            this.HighFrequency = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Filter = new System.Windows.Forms.Button();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ListView3 = new DoubleBufferListView();
            this.ListView2 = new DoubleBufferListView();
            this.listView = new DoubleBufferListView();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_getData
            // 
            this.timer_getData.Tick += new System.EventHandler(this.timer_getData_Tick);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(251, 372);
            this.button_start.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(69, 29);
            this.button_start.TabIndex = 2;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label_YCoordinateMax
            // 
            this.label_YCoordinateMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.label_YCoordinateMax.Location = new System.Drawing.Point(-2, 35);
            this.label_YCoordinateMax.Name = "label_YCoordinateMax";
            this.label_YCoordinateMax.Size = new System.Drawing.Size(52, 15);
            this.label_YCoordinateMax.TabIndex = 6;
            this.label_YCoordinateMax.Text = "5V";
            this.label_YCoordinateMax.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_YCoordinateMin
            // 
            this.label_YCoordinateMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.label_YCoordinateMin.Location = new System.Drawing.Point(-2, 321);
            this.label_YCoordinateMin.Name = "label_YCoordinateMin";
            this.label_YCoordinateMin.Size = new System.Drawing.Size(52, 15);
            this.label_YCoordinateMin.TabIndex = 7;
            this.label_YCoordinateMin.Text = "0V";
            this.label_YCoordinateMin.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label_YCoordinateMin.Click += new System.EventHandler(this.label_YCoordinateMin_Click);
            // 
            // label_XCoordinateMax
            // 
            this.label_XCoordinateMax.AutoSize = true;
            this.label_XCoordinateMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.label_XCoordinateMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_XCoordinateMax.Location = new System.Drawing.Point(482, 338);
            this.label_XCoordinateMax.Name = "label_XCoordinateMax";
            this.label_XCoordinateMax.Size = new System.Drawing.Size(46, 18);
            this.label_XCoordinateMax.TabIndex = 10;
            this.label_XCoordinateMax.Text = "1 Sec";
            this.label_XCoordinateMax.Click += new System.EventHandler(this.label_XCoordinateMax_Click);
            // 
            // trackBar
            // 
            this.trackBar.AutoSize = false;
            this.trackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.trackBar.Location = new System.Drawing.Point(646, 141);
            this.trackBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBar.Maximum = 1000;
            this.trackBar.Minimum = 10;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(129, 23);
            this.trackBar.SmallChange = 10;
            this.trackBar.TabIndex = 12;
            this.trackBar.Tag = "ghgfh";
            this.trackBar.TickFrequency = 100;
            this.trackBar.Value = 10;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // label_XCoordinateMin
            // 
            this.label_XCoordinateMin.AutoSize = true;
            this.label_XCoordinateMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.label_XCoordinateMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_XCoordinateMin.Location = new System.Drawing.Point(48, 338);
            this.label_XCoordinateMin.Name = "label_XCoordinateMin";
            this.label_XCoordinateMin.Size = new System.Drawing.Size(46, 18);
            this.label_XCoordinateMin.TabIndex = 14;
            this.label_XCoordinateMin.Text = "0 Sec";
            this.label_XCoordinateMin.Click += new System.EventHandler(this.label_XCoordinateMin_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBox.Location = new System.Drawing.Point(50, 39);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(467, 295);
            this.pictureBox.TabIndex = 18;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // label_YCoordinateMiddle
            // 
            this.label_YCoordinateMiddle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.label_YCoordinateMiddle.Location = new System.Drawing.Point(-2, 177);
            this.label_YCoordinateMiddle.Name = "label_YCoordinateMiddle";
            this.label_YCoordinateMiddle.Size = new System.Drawing.Size(52, 15);
            this.label_YCoordinateMiddle.TabIndex = 19;
            this.label_YCoordinateMiddle.Text = "0V";
            this.label_YCoordinateMiddle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(574, 146);
            this.textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(36, 28);
            this.textBox.TabIndex = 20;
            this.textBox.Text = "10";
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.label1.Location = new System.Drawing.Point(614, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "ms";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(523, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 27);
            this.label2.TabIndex = 22;
            this.label2.Text = "Sample  interval:";
            // 
            // comboBox_chanCount
            // 
            this.comboBox_chanCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_chanCount.FormattingEnabled = true;
            this.comboBox_chanCount.Location = new System.Drawing.Point(129, 375);
            this.comboBox_chanCount.Name = "comboBox_chanCount";
            this.comboBox_chanCount.Size = new System.Drawing.Size(75, 30);
            this.comboBox_chanCount.TabIndex = 26;
            this.comboBox_chanCount.SelectedIndexChanged += new System.EventHandler(this.comboBox_chanCount_SelectedIndexChanged);
            // 
            // label_chanCount
            // 
            this.label_chanCount.AutoSize = true;
            this.label_chanCount.Location = new System.Drawing.Point(58, 379);
            this.label_chanCount.Name = "label_chanCount";
            this.label_chanCount.Size = new System.Drawing.Size(106, 22);
            this.label_chanCount.TabIndex = 39;
            this.label_chanCount.Text = "ChanCount:";
            // 
            // instantAiCtrl1
            // 
            this.instantAiCtrl1._StateStream = ((Automation.BDaq.DeviceStateStreamer)(resources.GetObject("instantAiCtrl1._StateStream")));
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.trackBar1.Location = new System.Drawing.Point(646, 44);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(129, 23);
            this.trackBar1.SmallChange = 15;
            this.trackBar1.TabIndex = 40;
            this.trackBar1.Tag = "ghgfh";
            this.trackBar1.TickFrequency = 100;
            this.trackBar1.Value = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            // 
            // label5
            // 
            this.label5.AllowDrop = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(566, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 27);
            this.label5.TabIndex = 41;
            this.label5.Text = "X coordinate change rate:";
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(564, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 27);
            this.label3.TabIndex = 43;
            this.label3.Text = "Y coordinate change rate:";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // trackBar2
            // 
            this.trackBar2.AutoSize = false;
            this.trackBar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.trackBar2.Location = new System.Drawing.Point(646, 95);
            this.trackBar2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(129, 23);
            this.trackBar2.SmallChange = 20;
            this.trackBar2.TabIndex = 44;
            this.trackBar2.Tag = "ghgfh";
            this.trackBar2.TickFrequency = 100;
            this.trackBar2.Value = 10;
            this.trackBar2.Scroll += new System.EventHandler(this.TrackBar2_Scroll);
            // 
            // FFT
            // 
            this.FFT.Location = new System.Drawing.Point(356, 373);
            this.FFT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FFT.Name = "FFT";
            this.FFT.Size = new System.Drawing.Size(49, 26);
            this.FFT.TabIndex = 45;
            this.FFT.Text = "FFT";
            this.FFT.UseVisualStyleBackColor = true;
            this.FFT.Click += new System.EventHandler(this.FFT_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(50, 40);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Enabled = false;
            series1.Legend = "Legend1";
            series1.Name = "channel0";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Enabled = false;
            series2.Legend = "Legend1";
            series2.Name = "channel1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Enabled = false;
            series3.Legend = "Legend1";
            series3.Name = "channel2";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Enabled = false;
            series4.Legend = "Legend1";
            series4.Name = "channel3";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Enabled = false;
            series5.Legend = "Legend1";
            series5.Name = "channel4";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Enabled = false;
            series6.Legend = "Legend1";
            series6.Name = "channel5";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Enabled = false;
            series7.Legend = "Legend1";
            series7.Name = "channel6";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Series.Add(series7);
            this.chart1.Size = new System.Drawing.Size(467, 294);
            this.chart1.TabIndex = 46;
            this.chart1.Tag = "";
            this.chart1.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title1.Name = "ÂË²¨";
            title1.Text = "ÂË²¨ºóÍ¼Ïñ";
            this.chart1.Titles.Add(title1);
            this.chart1.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(583, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 22);
            this.label4.TabIndex = 48;
            this.label4.Text = "Filter Type:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Low Pass",
            "High Pass",
            "Band Pass"});
            this.comboBox1.Location = new System.Drawing.Point(656, 383);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(75, 30);
            this.comboBox1.TabIndex = 47;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // LowFrequency
            // 
            this.LowFrequency.Location = new System.Drawing.Point(655, 426);
            this.LowFrequency.Name = "LowFrequency";
            this.LowFrequency.Size = new System.Drawing.Size(75, 28);
            this.LowFrequency.TabIndex = 49;
            this.LowFrequency.TextChanged += new System.EventHandler(this.LowFrequency_TextChanged);
            // 
            // HighFrequency
            // 
            this.HighFrequency.Location = new System.Drawing.Point(655, 464);
            this.HighFrequency.Name = "HighFrequency";
            this.HighFrequency.Size = new System.Drawing.Size(76, 28);
            this.HighFrequency.TabIndex = 50;
            this.HighFrequency.TextChanged += new System.EventHandler(this.HighFrequency_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(566, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 22);
            this.label6.TabIndex = 51;
            this.label6.Text = "Low Freq (Hz)";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(565, 467);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 22);
            this.label7.TabIndex = 52;
            this.label7.Text = "High Freq(Hz)";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Filter
            // 
            this.Filter.Location = new System.Drawing.Point(658, 504);
            this.Filter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(73, 29);
            this.Filter.TabIndex = 53;
            this.Filter.Text = "Filter";
            this.Filter.UseVisualStyleBackColor = true;
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // trackBar3
            // 
            this.trackBar3.AutoSize = false;
            this.trackBar3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.trackBar3.Location = new System.Drawing.Point(646, 180);
            this.trackBar3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBar3.Minimum = 1;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(130, 23);
            this.trackBar3.SmallChange = 20;
            this.trackBar3.TabIndex = 54;
            this.trackBar3.Tag = "ghgfh";
            this.trackBar3.TickFrequency = 100;
            this.trackBar3.Value = 1;
            this.trackBar3.Scroll += new System.EventHandler(this.TrackBar3_Scroll);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(595, 180);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(42, 28);
            this.textBox1.TabIndex = 55;
            this.textBox1.Text = "1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AllowDrop = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(523, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 27);
            this.label8.TabIndex = 56;
            this.label8.Text = "Amplification factor:";
            // 
            // label9
            // 
            this.label9.AllowDrop = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(592, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "Voltage :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(656, 316);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 28);
            this.textBox3.TabIndex = 59;
            // 
            // label10
            // 
            this.label10.AllowDrop = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(591, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 58;
            this.label10.Text = "Point :";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(655, 231);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 28);
            this.textBox2.TabIndex = 57;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label11
            // 
            this.label11.AllowDrop = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(591, 277);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 62;
            this.label11.Text = "Time :";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(655, 272);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 28);
            this.textBox4.TabIndex = 61;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 484);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 22);
            this.label12.TabIndex = 65;
            this.label12.Text = "Freq(Hz)";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 455);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 22);
            this.label13.TabIndex = 66;
            this.label13.Text = "Power(W)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 424);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 22);
            this.label14.TabIndex = 67;
            this.label14.Text = "Value(V)";
            // 
            // ListView3
            // 
            this.ListView3.ForeColor = System.Drawing.Color.Black;
            this.ListView3.Location = new System.Drawing.Point(70, 481);
            this.ListView3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ListView3.Name = "ListView3";
            this.ListView3.Size = new System.Drawing.Size(480, 21);
            this.ListView3.TabIndex = 64;
            this.ListView3.UseCompatibleStateImageBehavior = false;
            // 
            // ListView2
            // 
            this.ListView2.ForeColor = System.Drawing.Color.Black;
            this.ListView2.Location = new System.Drawing.Point(70, 452);
            this.ListView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ListView2.Name = "ListView2";
            this.ListView2.Size = new System.Drawing.Size(480, 21);
            this.ListView2.TabIndex = 63;
            this.ListView2.UseCompatibleStateImageBehavior = false;
            this.ListView2.SelectedIndexChanged += new System.EventHandler(this.doubleBufferListView1_SelectedIndexChanged);
            // 
            // listView
            // 
            this.listView.ForeColor = System.Drawing.Color.Black;
            this.listView.Location = new System.Drawing.Point(70, 423);
            this.listView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(480, 21);
            this.listView.TabIndex = 42;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // InstantAIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(761, 431);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ListView3);
            this.Controls.Add(this.ListView2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.HighFrequency);
            this.Controls.Add(this.LowFrequency);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.FFT);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label_chanCount);
            this.Controls.Add(this.comboBox_chanCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.label_XCoordinateMax);
            this.Controls.Add(this.label_YCoordinateMin);
            this.Controls.Add(this.label_YCoordinateMax);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.label_YCoordinateMiddle);
            this.Controls.Add(this.label_XCoordinateMin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InstantAIForm";
            this.Text = "Instant AI";
            this.Load += new System.EventHandler(this.InstantAiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Timer timer_getData;
      private System.Windows.Forms.Button button_start;
      private System.Windows.Forms.Label label_YCoordinateMax;
      private System.Windows.Forms.Label label_YCoordinateMin;
      private System.Windows.Forms.Label label_XCoordinateMin;
      private System.Windows.Forms.TrackBar trackBar;
       private System.Windows.Forms.PictureBox pictureBox;
      private System.Windows.Forms.Label label_YCoordinateMiddle;
      private System.Windows.Forms.TextBox textBox;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
		public System.Windows.Forms.Label label_XCoordinateMax;
      private System.Windows.Forms.ComboBox comboBox_chanCount;
      private System.Windows.Forms.Label label_chanCount;
		private Automation.BDaq.InstantAiCtrl instantAiCtrl1;
        private System.Windows.Forms.Label label5;
        private DoubleBufferListView listView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Button FFT;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox LowFrequency;
        private System.Windows.Forms.TextBox HighFrequency;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Filter;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox4;
        private DoubleBufferListView ListView2;
        private DoubleBufferListView ListView3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TrackBar trackBar1;
    }
}

