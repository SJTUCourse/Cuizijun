using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Automation.BDaq;
using System.Linq;
using System.Collections;


namespace AI_InstantAI
{
    public partial class InstantAIForm : Form
    {
        #region fields

        SimpleGraph m_simpleGraph;
        ListViewItem m_firstItem = new ListViewItem();
        ListViewItem m_firstItem2 = new ListViewItem();
        ListViewItem m_firstItem3 = new ListViewItem();
        ListViewItem m_secondItem = new ListViewItem();
        int time = 0;

        public const int CHANNEL_COUNT_MAX = 16;
        double[] m_dataScaled = new double[CHANNEL_COUNT_MAX];
        int chanCountSet = 0;
        ArrayList[] xreal = new ArrayList[16];
        ArrayList[] value = new ArrayList[16];
        ArrayList[] ivalue = new ArrayList[16];
        int num = 0;

        //指定日志文件的目录 
        string fname;

        #endregion

        public InstantAIForm()
        {
            InitializeComponent();
            for (int i = 0; i < 16; i++)
            {
                xreal[i] = new ArrayList();
                value[i] = new ArrayList();
                ivalue[i] = new ArrayList();
            }
            chart1.Visible = false;
            Filter.Enabled = false;
        }

        public InstantAIForm(int deviceNumber)
        {
            InitializeComponent();
            instantAiCtrl1.SelectedDevice = new DeviceInformation(deviceNumber);
            for (int i=0;i<16;i++)
            {
                xreal[i] = new ArrayList();
                value[i] = new ArrayList();
                ivalue[i] = new ArrayList();
            }
            chart1.Visible = false;
        }
        private void InstantAiForm_Load(object sender, EventArgs e)
        {
            //The default device of project is demo device, users can choose other devices according to their needs. 
            if (!instantAiCtrl1.Initialized)
            {
                MessageBox.Show("No device be selected or device open failed!", "AI_InstantAI");
                this.Close();
                return;
            }

            //set title of the form.
            this.Text = "Instant AI(" + instantAiCtrl1.SelectedDevice.Description + ")";

            button_start.Enabled = true;
            FFT.Enabled = false;

            //initialize a graph with a picture box control to draw Ai data. 
            m_simpleGraph = new SimpleGraph(pictureBox.Size, pictureBox);
            //initialize a timer which drive the data acquisition.
            timer_getData.Interval = trackBar.Value;

            textBox.ReadOnly = true;
            textBox.Text = trackBar.Value.ToString();

            //Add combo Box  to select start channel and channel count
            int chanCount = (instantAiCtrl1.ChannelCount <= CHANNEL_COUNT_MAX) ? instantAiCtrl1.ChannelCount : CHANNEL_COUNT_MAX;

            int count = 0;
            for (int i = 0; i < chanCount; ++i)
            {
                //comboBox_chanStart.Items.Add(i.ToString());
                count = i + 1;
                comboBox_chanCount.Items.Add(count.ToString());
            }

            //comboBox_chanStart.SelectedIndex = 0;
            comboBox_chanCount.SelectedIndex = 1;

            ConfigureGraph();
            InitListView();
        }

        private void ConfigureGraph()
        {
            m_simpleGraph.XCordTimeDiv = 1000;
            string[] X_rangeLabels = new string[2];
            Helpers.GetXCordRangeLabels(X_rangeLabels, trackBar1.Value, 0, TimeUnit.Second);
            label_XCoordinateMax.Text = X_rangeLabels[0];
            label_XCoordinateMin.Text = X_rangeLabels[1];

            ValueUnit unit = (ValueUnit)(1); // Don't show unit in the label.
            string[] Y_CordLables = new string[3];
            Helpers.GetYCordRangeLabels(Y_CordLables, trackBar2.Value, -trackBar2.Value, unit);
            label_YCoordinateMax.Text = Y_CordLables[0];
            label_YCoordinateMin.Text = Y_CordLables[1];
            label_YCoordinateMiddle.Text = Y_CordLables[2];
            
            m_simpleGraph.AmplificationFactor = 1;
            m_simpleGraph.XcordChangeRate = (float)(10.0 / trackBar1.Value);
            m_simpleGraph.YCordRangeMax = trackBar2.Value;
            m_simpleGraph.YCordRangeMin = -trackBar2.Value;

            m_simpleGraph.Clear();
        }

        private void timer_getData_Tick(object sender, EventArgs e)
        {
            PerformanceCounter performanceCounter = new PerformanceCounter();
            ErrorCode err;

            performanceCounter.Start();
            err = instantAiCtrl1.Read(0, chanCountSet, m_dataScaled);
            if (err != ErrorCode.Success)
            {
                HandleError(err);
                timer_getData.Stop();
            }
            m_simpleGraph.Chart(m_dataScaled, chanCountSet, 1, 1.0 * trackBar.Value / 1000);
            int chanCount = comboBox_chanCount.SelectedIndex + 1;
            using (FileStream fs = File.Open(fname, FileMode.OpenOrCreate))
            {
                StreamWriter w = new StreamWriter(fs);
                w.BaseStream.Seek(0, SeekOrigin.End);
                time += timer_getData.Interval;
                w.Write(time.ToString() + " ");
                for (int i = 0; i < chanCount; ++i)
                {
                    //写文件
                    w.Write((m_dataScaled[i]).ToString() + " ");
                    //写数组
                    xreal[i].Add(m_dataScaled[i]);
                }
                w.Write("\r\n");
                w.Flush();
                w.Close();
            }

            RefreshListView();
            performanceCounter.Stop();
            int interval = (int)(trackBar.Value - performanceCounter.Duration * 1000 - 0.5);
            if (interval > 1)
            {
                timer_getData.Interval = interval;
            }
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            m_simpleGraph.Clear();
            timer_getData.Interval = trackBar.Value;
            textBox.Text = trackBar.Value.ToString();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (button_start.Text == "Start")
            {
                timer_getData.Enabled = true;
                timer_getData.Start();
                FFT.Enabled = false;
                time = 0;
                chart1.Visible = false;
                Filter.Enabled = false;
                fname = @DateTime.Now.ToString("yyyy-MM-dd HH hour mm min ss s")+".txt";
                using (FileStream fs = File.Open(fname, FileMode.OpenOrCreate))
                {
                    fs.SetLength(0);
                }
                for (int i = 0; i < 16; i++)
                {
                    xreal[i].Clear();
                    value[i].Clear();
                    ivalue[i].Clear();
                }
                button_start.Text = "Pause";
            }
            else if(button_start.Text=="Pause")
            {
                timer_getData.Stop();
                FFT.Enabled = true;
                button_start.Text = "Start";
                //listBox2.Items.Clear();
            }
        }

        private void button_pause_Click(object sender, EventArgs e)
        {

        }

        private void button_stop_Click(object sender, EventArgs e)
        {

        }

        private void InitListView()
        {
            //control list view ,one grid indicates a channel which specials with color and value.
            listView.Clear();
            listView.FullRowSelect = false;
            listView.Width = 480;
            listView.Height = 21;
            listView.View = View.Details;// Set the view to show details.
            listView.HeaderStyle = ColumnHeaderStyle.None;
            listView.GridLines = true;
            // there are 8 columns for every item.
            for (int i = 0; i < 8; i++)
            {
                listView.Columns.Add("", 60);
            }

            // modify the grid's height with image Indirectly.
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, 21);//width and height.
            listView.SmallImageList = imgList; //use imgList to modify the height of listView grids.

            // create two ListViewItem objects,so there are 16 grids for listView.
            m_firstItem = new ListViewItem();
            m_firstItem.SubItems.Clear();
            m_firstItem.UseItemStyleForSubItems = false;
            m_firstItem.Font = new Font("SimSun", 10);
            m_firstItem.SubItems[0].Text = String.Format("{0:0.00}", m_dataScaled[0] * trackBar3.Value);
            m_firstItem.SubItems[0].BackColor = m_simpleGraph.Pens[0].Color;
            for (int i = 1; i < 8; i++)
            {
                if (i < chanCountSet)
                {
                    m_firstItem.SubItems.Add((String.Format("{0:0.00}", m_dataScaled[i] * trackBar3.Value)), Color.Black, Color.Honeydew, new Font("SimSun", 10));
                    m_firstItem.SubItems[i].BackColor = m_simpleGraph.Pens[i].Color;

                }
                else
                {
                    m_firstItem.SubItems.Add("");
                    m_firstItem.SubItems[i].BackColor = Color.White;
                }
            }

            m_secondItem = new ListViewItem();
            m_secondItem.SubItems.Clear();
            m_secondItem.Font = new Font("SimSun", 10);
            m_secondItem.UseItemStyleForSubItems = false;
            if (8 < chanCountSet)
            {
                m_secondItem.SubItems[0].Text = String.Format("{0:0.00}", m_dataScaled[8] * trackBar3.Value);
                m_secondItem.SubItems[0].BackColor = m_simpleGraph.Pens[8].Color;
            }
            else
            {
                m_secondItem.SubItems[0].Text = "";
                m_secondItem.SubItems[0].BackColor = Color.White;
            }
            for (int i = 9; i < 16; i++)
            {
                if (i < chanCountSet)
                {
                    m_secondItem.SubItems.Add((String.Format("{0:0.00}", m_dataScaled[i] * trackBar3.Value)), Color.Black, Color.Honeydew, new Font("SimSun", 10));
                    m_secondItem.SubItems[i - 8].BackColor = m_simpleGraph.Pens[i].Color;
                }
                else
                {
                    m_secondItem.SubItems.Add("");
                    m_secondItem.SubItems[i - 8].BackColor = Color.White;
                }
            }

            ListViewItem[] list = new ListViewItem[] { m_firstItem, m_secondItem };
            listView.Items.AddRange(list);
        }

        private void RefreshListView()
        {
            for (int i = 0; i < chanCountSet; i++)
            {
                if (i < 8)
                {
                    m_firstItem.SubItems[i].Text = String.Format("{0:0.00}", m_dataScaled[i] * trackBar3.Value);
                }
                else
                {
                    m_secondItem.SubItems[i % 8].Text = String.Format("{0:0.00}", m_dataScaled[i] * trackBar3.Value);
                }
            }
        }

        private void HandleError(ErrorCode err)
        {
            if (err != ErrorCode.Success)
            {
                MessageBox.Show("Sorry ! some errors happened, the error code is: " + err.ToString(), "AI_InstantAI");
            }
        }

        private void comboBox_chanCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            chanCountSet = comboBox_chanCount.SelectedIndex + 1;
            InitListView();
        }

        private void timer_outputData_Tick(object sender, EventArgs e)
        {

        }

        private void label_XCoordinateMax_Click(object sender, EventArgs e)
        {

        }

        private void label_XCoordinateMin_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            Point formPoint = this.PointToClient(Control.MousePosition);
            textBox2.Text = (formPoint.X - 50).ToString() + "," + (formPoint.Y - 40).ToString();
            textBox3.Text = ((float)((294.0/2 - (formPoint.Y - 40.0)) * trackBar2.Value / (294.0/2)) * trackBar3.Value).ToString();
            textBox4.Text = ((float)((formPoint.X - 50.0)) * trackBar1.Value / 467.0).ToString();
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            m_simpleGraph.XcordChangeRate = (float)(10.0 / trackBar1.Value);
            label_XCoordinateMax.Text = (trackBar1.Value).ToString() + " sec";
        }
        private void TrackBar2_Scroll(object sender, EventArgs e)
        {
            label_YCoordinateMax.Text = (trackBar2.Value).ToString() + "V";
            label_YCoordinateMin.Text = (-trackBar2.Value).ToString() + "V";
            label_YCoordinateMiddle.Text = ((trackBar2.Value - trackBar2.Value) / 2).ToString() + "V";
            m_simpleGraph.YCordRangeMax = trackBar2.Value;
            m_simpleGraph.YCordRangeMin = -trackBar2.Value;
        }
        private void TrackBar3_Scroll(object sender, EventArgs e)
        {
            m_simpleGraph.AmplificationFactor = trackBar3.Value;
            textBox1.Text = trackBar3.Value.ToString();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void FFT_Click(object sender, EventArgs e)
        {
            int chanCount = comboBox_chanCount.SelectedIndex + 1;
            for (int i = 0; i < chanCount; ++i)
            {
                double[] values = (double[])xreal[i].ToArray(typeof(double));
                double[] ivalues = new double[values.Length];
                num = values.Length;
                for (int j = 0; j < values.Length; j++)
                {
                    ivalues[j] = 0;
                }
                TWFFT.FFT(values, ivalues);
                //TWFFT.IFFT(values, ivalues);
                for (int j = 0; j < values.Length; j++)
                {
                    value[i].Add(values[j]);
                    ivalue[i].Add(ivalues[j]);
                }
            }
            string result = fname.Insert(fname.LastIndexOf('.'), " FFT");
            using (FileStream fs = File.Open(result, FileMode.OpenOrCreate))
            {
                StreamWriter w = new StreamWriter(fs);
                w.BaseStream.Seek(0, SeekOrigin.End);
                w.Write("\r\nFFT:\r\n");
                for (int i=0;i<chanCount;i++)
                {
                    w.BaseStream.Seek(0, SeekOrigin.End);
                    w.Write("channel "+i.ToString()+ "\r\n");
                    for (int j=0;j<num;j++)
                    {
                        //写文件
                        w.Write(value[i][j].ToString() + " ");
                        w.Write(ivalue[i][j].ToString() + " ");
                        w.Write("\r\n");
                    }
                }
                w.Flush();
                w.Close();
            }
            chart1.ChartAreas[0].AxisY.Maximum = trackBar2.Value;
// chart1.ChartAreas[0].AxisX.Maximum = trackBar1.Value;
            double[] Power = { 0, 0, 0, 0, 0, 0, 0, 0 };
            double[] Freq = { 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < chanCount; i++)
            {
                double power = 0;
                int frequency = 0;
                double[] values = (double[])value[i].ToArray(typeof(double));
                double[] ivalues = (double[])ivalue[i].ToArray(typeof(double));
                for (int j = 0; j < num; j++)
                {
                    if (power < values[j] * values[j] + ivalues[j] * ivalues[j])
                    {
                        power = (values[j] * values[j] + ivalues[j] * ivalues[j]);
                        frequency = j;
                    }
                }
                Power[i] = power;
                Freq[i] = frequency * 1000 / time;
            };

             //control list view ,one grid indicates a channel which specials with color and value.
                ListView2.Clear();
                ListView2.FullRowSelect = false;
                ListView2.Width = 480;
                ListView2.Height = 21;
                ListView2.View = View.Details;// Set the view to show details.
                ListView2.HeaderStyle = ColumnHeaderStyle.None;
                ListView2.GridLines = true;
                // there are 8 columns for every item.
                for (int k = 0; k < 8; k++)
                {
                    ListView2.Columns.Add("", 60);
                }

                // modify the grid's height with image Indirectly.
                ImageList imgList2 = new ImageList();
                imgList2.ImageSize = new Size(1, 21);//width and height.
                ListView2.SmallImageList = imgList2; //use imgList to modify the height of listView grids.

                // create two ListViewItem objects,so there are 16 grids for listView.
                m_firstItem2 = new ListViewItem();
                m_firstItem2.SubItems.Clear();
                m_firstItem2.UseItemStyleForSubItems = false;
                m_firstItem2.Font = new Font("SimSun", 10);
                m_firstItem2.SubItems[0].Text = String.Format("{0:0}", Power[0]);
                m_firstItem2.SubItems[0].BackColor = m_simpleGraph.Pens[0].Color;
                for (int k = 1; k < 8; k++)
                {
                    if (k < chanCountSet)
                    {
                        m_firstItem2.SubItems.Add((String.Format("{0:0}", Power[k])), Color.Black, Color.Honeydew, new Font("SimSun", 10));
                        m_firstItem2.SubItems[k].BackColor = m_simpleGraph.Pens[k].Color;

                    }
                    else
                    {
                        m_firstItem2.SubItems.Add("");
                        m_firstItem2.SubItems[k].BackColor = Color.White;
                    }
                }
                
                ListViewItem[] list2 = new ListViewItem[] { m_firstItem2 };
                ListView2.Items.AddRange(list2);

            ListView3.Clear();
            ListView3.FullRowSelect = false;
            ListView3.Width = 480;
            ListView3.Height = 21;
            ListView3.View = View.Details;// Set the view to show details.
            ListView3.HeaderStyle = ColumnHeaderStyle.None;
            ListView3.GridLines = true;
            // there are 8 columns for every item.
            for (int k = 0; k < 8; k++)
            {
                ListView3.Columns.Add("", 60);
            }

            // modify the grid's height with image Indirectly.
            ImageList imgList3 = new ImageList();
            imgList3.ImageSize = new Size(1, 21);//width and height.
            ListView3.SmallImageList = imgList3; //use imgList to modify the height of listView grids.

            // create two ListViewItem objects,so there are 16 grids for listView.
            m_firstItem3 = new ListViewItem();
            m_firstItem3.SubItems.Clear();
            m_firstItem3.UseItemStyleForSubItems = false;
            m_firstItem3.Font = new Font("SimSun", 10);
            m_firstItem3.SubItems[0].Text = String.Format("{0:0}", Freq[0]);
            m_firstItem3.SubItems[0].BackColor = m_simpleGraph.Pens[0].Color;
            for (int k = 1; k < 8; k++)
            {
                if (k < chanCountSet)
                {
                    m_firstItem3.SubItems.Add((String.Format("{0:0}", Freq[k])), Color.Black, Color.Honeydew, new Font("SimSun", 10));
                    m_firstItem3.SubItems[k].BackColor = m_simpleGraph.Pens[k].Color;

                }
                else
                {
                    m_firstItem3.SubItems.Add("");
                    m_firstItem3.SubItems[k].BackColor = Color.White;
                }
            }

            ListViewItem[] list3 = new ListViewItem[] { m_firstItem3 };
            ListView3.Items.AddRange(list3);

            FFT.Enabled = false;

        }

        public static class ConstVal
        {
            public const int Channel_Start = 0;
            public const int Channel_Count = 3;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text=="Low Pass")
            {
                LowFrequency.Text = "0";
                LowFrequency.Enabled = false;
                HighFrequency.Enabled = true;
                HighFrequency.Text = "99999";
                Filter.Enabled = true;

            }
            else if(comboBox1.Text == "High Pass")
            {
                HighFrequency.Text = Math.Floor(1000.0*num/time).ToString();
                HighFrequency.Enabled = false;
                LowFrequency.Enabled = true;
                LowFrequency.Text = "0";

            }
            else
            {
                LowFrequency.Enabled = true;
                HighFrequency.Enabled = true;
            }
            Filter.Enabled = true;
        }

   
        private void Filter_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            chart1.Visible = true;
            int chanCount = comboBox_chanCount.SelectedIndex + 1;
            for (int i = 0; i < chanCount; i++)
            {
                for (int j = 0; j < Convert.ToInt32(LowFrequency.Text)*time/1000; j++)
                {
                    value[i][j] = 0.0;
                    ivalue[i][j] = 0.0;
                }
                for (int j = Convert.ToInt32(HighFrequency.Text)*time/1000; j < num; j++)
                {
                    value[i][j] = 0.0;
                    ivalue[i][j] = 0.0;
                }
            }
            for (int i = 0; i < chanCount; i++)
            { 
                double[] values = (double[])value[i].ToArray(typeof(double));
                double[] ivalues = (double[])ivalue[i].ToArray(typeof(double));
                TWFFT.IFFT(values, ivalues);
                for(int j=0; j<num; j++)
                {
                    chart1.Series[i].Enabled = true;
                    if (values[j] != 0)
                    {
                        chart1.Series[i].Points.AddY(values[j]);
                    }
                }
            }
        }

        private void label_YCoordinateMin_Click(object sender, EventArgs e)
        {

        }

        private void LowFrequency_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void HighFrequency_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void doubleBufferListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ListView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void ListView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
