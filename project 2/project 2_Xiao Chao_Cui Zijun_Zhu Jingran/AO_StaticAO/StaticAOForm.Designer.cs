namespace AO_StaticAO
{
    partial class StaticAOForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaticAOForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.checkBox_triangleA = new System.Windows.Forms.CheckBox();
            this.trackBar_Scroll = new System.Windows.Forms.TrackBar();
            this.checkBox_squareA = new System.Windows.Forms.CheckBox();
            this.checkBox_sineA = new System.Windows.Forms.CheckBox();
            this.checkBox_sineB = new System.Windows.Forms.CheckBox();
            this.checkBox_squareB = new System.Windows.Forms.CheckBox();
            this.checkBox_triangleB = new System.Windows.Forms.CheckBox();
            this.timer_outputData = new System.Windows.Forms.Timer(this.components);
            this.textBox_amplitude2 = new System.Windows.Forms.TextBox();
            this.textBox_amplitude4 = new System.Windows.Forms.TextBox();
            this.label_interval = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.m_instantAoCtrl = new Automation.BDaq.InstantAoCtrl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label_chanB = new System.Windows.Forms.Label();
            this.label_chanA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.timer_file = new System.Windows.Forms.Timer(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Scroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox_triangleA
            // 
            this.checkBox_triangleA.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_triangleA.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_triangleA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBox_triangleA.BackgroundImage")));
            this.checkBox_triangleA.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox_triangleA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox_triangleA.Location = new System.Drawing.Point(291, 227);
            this.checkBox_triangleA.Margin = new System.Windows.Forms.Padding(1);
            this.checkBox_triangleA.Name = "checkBox_triangleA";
            this.checkBox_triangleA.Size = new System.Drawing.Size(53, 50);
            this.checkBox_triangleA.TabIndex = 0;
            this.checkBox_triangleA.UseVisualStyleBackColor = false;
            this.checkBox_triangleA.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBox_AoDataOut_MouseClick);
            // 
            // trackBar_Scroll
            // 
            this.trackBar_Scroll.AutoSize = false;
            this.trackBar_Scroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.trackBar_Scroll.Location = new System.Drawing.Point(103, 38);
            this.trackBar_Scroll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBar_Scroll.Maximum = 1000;
            this.trackBar_Scroll.Minimum = 10;
            this.trackBar_Scroll.Name = "trackBar_Scroll";
            this.trackBar_Scroll.Size = new System.Drawing.Size(206, 23);
            this.trackBar_Scroll.TabIndex = 24;
            this.trackBar_Scroll.TickFrequency = 100;
            this.trackBar_Scroll.Value = 50;
            this.trackBar_Scroll.Scroll += new System.EventHandler(this.trackBar_Scroll_Scroll);
            // 
            // checkBox_squareA
            // 
            this.checkBox_squareA.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_squareA.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_squareA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBox_squareA.BackgroundImage")));
            this.checkBox_squareA.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox_squareA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox_squareA.Location = new System.Drawing.Point(177, 227);
            this.checkBox_squareA.Margin = new System.Windows.Forms.Padding(1);
            this.checkBox_squareA.Name = "checkBox_squareA";
            this.checkBox_squareA.Size = new System.Drawing.Size(53, 50);
            this.checkBox_squareA.TabIndex = 28;
            this.checkBox_squareA.UseVisualStyleBackColor = false;
            this.checkBox_squareA.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBox_AoDataOut_MouseClick);
            // 
            // checkBox_sineA
            // 
            this.checkBox_sineA.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_sineA.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_sineA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBox_sineA.BackgroundImage")));
            this.checkBox_sineA.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox_sineA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox_sineA.Location = new System.Drawing.Point(63, 227);
            this.checkBox_sineA.Margin = new System.Windows.Forms.Padding(1);
            this.checkBox_sineA.Name = "checkBox_sineA";
            this.checkBox_sineA.Size = new System.Drawing.Size(53, 50);
            this.checkBox_sineA.TabIndex = 29;
            this.checkBox_sineA.UseVisualStyleBackColor = false;
            this.checkBox_sineA.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBox_AoDataOut_MouseClick);
            // 
            // checkBox_sineB
            // 
            this.checkBox_sineB.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_sineB.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_sineB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBox_sineB.BackgroundImage")));
            this.checkBox_sineB.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox_sineB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox_sineB.Location = new System.Drawing.Point(63, 363);
            this.checkBox_sineB.Margin = new System.Windows.Forms.Padding(1);
            this.checkBox_sineB.Name = "checkBox_sineB";
            this.checkBox_sineB.Size = new System.Drawing.Size(53, 50);
            this.checkBox_sineB.TabIndex = 32;
            this.checkBox_sineB.UseVisualStyleBackColor = false;
            this.checkBox_sineB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBox_AoDataOut_MouseClick);
            // 
            // checkBox_squareB
            // 
            this.checkBox_squareB.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_squareB.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_squareB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBox_squareB.BackgroundImage")));
            this.checkBox_squareB.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox_squareB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox_squareB.Location = new System.Drawing.Point(177, 363);
            this.checkBox_squareB.Margin = new System.Windows.Forms.Padding(1);
            this.checkBox_squareB.Name = "checkBox_squareB";
            this.checkBox_squareB.Size = new System.Drawing.Size(53, 50);
            this.checkBox_squareB.TabIndex = 31;
            this.checkBox_squareB.UseVisualStyleBackColor = false;
            this.checkBox_squareB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBox_AoDataOut_MouseClick);
            // 
            // checkBox_triangleB
            // 
            this.checkBox_triangleB.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_triangleB.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_triangleB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBox_triangleB.BackgroundImage")));
            this.checkBox_triangleB.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox_triangleB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox_triangleB.Location = new System.Drawing.Point(291, 363);
            this.checkBox_triangleB.Margin = new System.Windows.Forms.Padding(1);
            this.checkBox_triangleB.Name = "checkBox_triangleB";
            this.checkBox_triangleB.Size = new System.Drawing.Size(53, 50);
            this.checkBox_triangleB.TabIndex = 30;
            this.checkBox_triangleB.UseVisualStyleBackColor = false;
            this.checkBox_triangleB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBox_AoDataOut_MouseClick);
            // 
            // timer_outputData
            // 
            this.timer_outputData.Tick += new System.EventHandler(this.timer_outputData_Tick);
            // 
            // textBox_amplitude2
            // 
            this.textBox_amplitude2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_amplitude2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_amplitude2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox_amplitude2.Location = new System.Drawing.Point(111, 201);
            this.textBox_amplitude2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_amplitude2.Name = "textBox_amplitude2";
            this.textBox_amplitude2.Size = new System.Drawing.Size(74, 21);
            this.textBox_amplitude2.TabIndex = 38;
            this.textBox_amplitude2.Text = "5";
            this.textBox_amplitude2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_amplitude4
            // 
            this.textBox_amplitude4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_amplitude4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_amplitude4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox_amplitude4.Location = new System.Drawing.Point(111, 328);
            this.textBox_amplitude4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_amplitude4.Name = "textBox_amplitude4";
            this.textBox_amplitude4.Size = new System.Drawing.Size(74, 21);
            this.textBox_amplitude4.TabIndex = 40;
            this.textBox_amplitude4.Text = "5";
            this.textBox_amplitude4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_interval
            // 
            this.label_interval.AutoSize = true;
            this.label_interval.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_interval.Image = ((System.Drawing.Image)(resources.GetObject("label_interval.Image")));
            this.label_interval.Location = new System.Drawing.Point(315, 46);
            this.label_interval.Name = "label_interval";
            this.label_interval.Size = new System.Drawing.Size(39, 15);
            this.label_interval.TabIndex = 45;
            this.label_interval.Text = "0.5Hz";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "sine.bmp");
            this.imageList.Images.SetKeyName(1, "square.bmp");
            this.imageList.Images.SetKeyName(2, "triangle.bmp");
            this.imageList.Images.SetKeyName(3, "sine_down.bmp");
            this.imageList.Images.SetKeyName(4, "square_down.bmp");
            this.imageList.Images.SetKeyName(5, "triangle_down.bmp");
            // 
            // m_instantAoCtrl
            // 
            this.m_instantAoCtrl._StateStream = ((Automation.BDaq.DeviceStateStreamer)(resources.GetObject("m_instantAoCtrl._StateStream")));
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(26, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 25);
            this.label1.TabIndex = 48;
            this.label1.Text = "The points number of each waveform is";
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.SystemColors.Control;
            this.chart2.BorderlineColor = System.Drawing.SystemColors.Control;
            this.chart2.BorderSkin.PageColor = System.Drawing.SystemColors.Control;
            chartArea2.AxisX.Title = "Number of points";
            chartArea2.AxisY.Title = "Voltage（V）";
            chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(410, 25);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "channel0";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "channel1";
            this.chart2.Series.Add(series3);
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(729, 399);
            this.chart2.TabIndex = 50;
            this.chart2.Tag = "";
            this.chart2.Text = "chart2";
            title2.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title2.Name = "Filter";
            title2.Text = "Waveform";
            this.chart2.Titles.Add(title2);
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(254, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(37, 21);
            this.textBox1.TabIndex = 51;
            this.textBox1.Text = "32";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 26);
            this.button1.TabIndex = 52;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_chanB
            // 
            this.label_chanB.AutoSize = true;
            this.label_chanB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_chanB.ForeColor = System.Drawing.Color.BurlyWood;
            this.label_chanB.Image = ((System.Drawing.Image)(resources.GetObject("label_chanB.Image")));
            this.label_chanB.Location = new System.Drawing.Point(35, 299);
            this.label_chanB.Name = "label_chanB";
            this.label_chanB.Size = new System.Drawing.Size(72, 15);
            this.label_chanB.TabIndex = 43;
            this.label_chanB.Text = "Channel 1";
            // 
            // label_chanA
            // 
            this.label_chanA.AutoSize = true;
            this.label_chanA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_chanA.ForeColor = System.Drawing.Color.BurlyWood;
            this.label_chanA.Image = ((System.Drawing.Image)(resources.GetObject("label_chanA.Image")));
            this.label_chanA.Location = new System.Drawing.Point(35, 163);
            this.label_chanA.Name = "label_chanA";
            this.label_chanA.Size = new System.Drawing.Size(72, 15);
            this.label_chanA.TabIndex = 44;
            this.label_chanA.Text = "Channel 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 53;
            this.label2.Text = "Amplitude";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 56;
            this.label5.Text = "Amplitude";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 57;
            this.label6.Text = "Frequency";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 58;
            this.label7.Text = "Output type";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "continous output",
            "Assigned output period",
            "Import file"});
            this.comboBox1.Location = new System.Drawing.Point(213, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 23);
            this.comboBox1.TabIndex = 59;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 15);
            this.label8.TabIndex = 60;
            this.label8.Text = "Output period number";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(213, 96);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(142, 21);
            this.textBox3.TabIndex = 62;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(213, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 26);
            this.button2.TabIndex = 63;
            this.button2.Text = "Filename";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(288, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 26);
            this.button3.TabIndex = 64;
            this.button3.Text = "Upload";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 15);
            this.label9.TabIndex = 65;
            this.label9.Text = "Output file";
            // 
            // timer_file
            // 
            this.timer_file.Interval = 5;
            this.timer_file.Tick += new System.EventHandler(this.timer_file_Tick);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox2.Location = new System.Drawing.Point(271, 201);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(82, 21);
            this.textBox2.TabIndex = 66;
            this.textBox2.Text = "2.5";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(210, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 15);
            this.label10.TabIndex = 67;
            this.label10.Text = "Offset";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(210, 331);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 15);
            this.label11.TabIndex = 69;
            this.label11.Text = "Offset";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox4.Location = new System.Drawing.Point(271, 328);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(82, 21);
            this.textBox4.TabIndex = 68;
            this.textBox4.Text = "2.5";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // StaticAOForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 451);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_interval);
            this.Controls.Add(this.label_chanA);
            this.Controls.Add(this.label_chanB);
            this.Controls.Add(this.textBox_amplitude4);
            this.Controls.Add(this.textBox_amplitude2);
            this.Controls.Add(this.checkBox_sineB);
            this.Controls.Add(this.checkBox_squareB);
            this.Controls.Add(this.checkBox_triangleB);
            this.Controls.Add(this.checkBox_sineA);
            this.Controls.Add(this.checkBox_squareA);
            this.Controls.Add(this.checkBox_triangleA);
            this.Controls.Add(this.trackBar_Scroll);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StaticAOForm";
            this.Text = "Static AO";
            this.Load += new System.EventHandler(this.InstantAoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Scroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       private System.Windows.Forms.CheckBox checkBox_triangleA;
       private System.Windows.Forms.TrackBar trackBar_Scroll;
       private System.Windows.Forms.CheckBox checkBox_squareA;
       private System.Windows.Forms.CheckBox checkBox_sineA;
       private System.Windows.Forms.CheckBox checkBox_sineB;
       private System.Windows.Forms.CheckBox checkBox_squareB;
       private System.Windows.Forms.CheckBox checkBox_triangleB;
       private System.Windows.Forms.Timer timer_outputData;
       private  System.Windows.Forms.Timer temp;
       private System.Windows.Forms.TextBox textBox_amplitude2;
       private System.Windows.Forms.TextBox textBox_amplitude4;
       private System.Windows.Forms.Label label_interval;
       private System.Windows.Forms.ImageList imageList;
       private Automation.BDaq.InstantAoCtrl m_instantAoCtrl;
		 private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_chanB;
        private System.Windows.Forms.Label label_chanA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer_file;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox4;
    }
}

