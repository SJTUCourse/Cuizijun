using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Automation.BDaq;
using System.Linq;
using System.Collections;

namespace AO_StaticAO
{
   public partial class StaticAOForm : Form
   {
      #region fileds

      int m_channelStart = 0;
      int m_channelCount = 0;
      uint m_PointCountPerWave = 32; 
      double[] m_dataScaled = new double[2];
      int m_wavePointsIndexA = 0;
      int m_wavePointsIndexB = 0;
        // double m_highLevelA;
        //  double m_lowLevelA;
        // double m_highLevelB;
        //double m_lowLevelB;
        double m_amplitude2;
        double m_amplitude4;
        double m_offset2;
        double m_offset4;

        private bool m_isCheckedA;
      private bool m_isCheckedB;
      WaveformGenerator m_waveformGenerator;
      WaveformStyle m_formStyleA;
      WaveformStyle m_formStyleB;
      ErrorCode m_err = ErrorCode.Success;
      CheckBox[] m_waveSelectCheckBox = new CheckBox[6];
      ArrayList m_dataOnePeriod = new ArrayList();
        ArrayList file_time = new ArrayList();
        ArrayList file_data = new ArrayList();
        bool checked_numA = false;
        bool checked_numB = false;
        int output_num = -1;
        string filename;
        int time_file = 0;
        int count_file = 0;
        System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();


        #endregion

        public StaticAOForm()
      {
         InitializeComponent();
      }
        private void InstantAoForm_Load(object sender, EventArgs e)
      {
         //The default device of project is demo device, users can choose other devices according to their needs. 
         //initialize a timer which drive the data acquisition.
         timer_outputData.Interval = 50;
         //initialize the scrollbar
         trackBar_Scroll.Maximum = 1000;
         trackBar_Scroll.Minimum = 10;
         trackBar_Scroll.Value = 50;
         //initialize the checkbox
         m_waveSelectCheckBox[0] = checkBox_sineA;
         m_waveSelectCheckBox[1] = checkBox_squareA;
         m_waveSelectCheckBox[2] = checkBox_triangleA;
         m_waveSelectCheckBox[3] = checkBox_sineB;
         m_waveSelectCheckBox[4] = checkBox_squareB;
         m_waveSelectCheckBox[5] = checkBox_triangleB;
         // no device is selected
         if (!m_instantAoCtrl.Initialized)
         {
            MessageBox.Show("No device be selected or device open failed!", "StaticAO");
            this.Close();
            return;
         }
 
         m_waveformGenerator = new WaveformGenerator(m_PointCountPerWave);
         //set title of the form.
         string text = m_instantAoCtrl.SelectedDevice.Description;
         this.Text = "Static AO(" + text + ")";
            this.comboBox1.SelectedIndex = 0;
            textBox3.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            ConfigurePanel();
            timer_file.Stop();
      }

      private void ConfigurePanel()
      {
         if (m_instantAoCtrl.ChannelCount == 1)
         {
            m_channelStart = 0;
            m_channelCount = 1;
            for (int i = 3; i < 6; i++)
            {
               m_waveSelectCheckBox[i].Enabled = false;
            }
            textBox_amplitude4.Enabled = false;
            //textBox_lowLevelB.Enabled = false;
            textBox4.Enabled = false;
                //textBox_valueB.Enabled = false;
                //button_manualB.Enabled = false;
                label_chanB.Text = " ";
         }
         else
         {
            m_channelStart = 0;
            m_channelCount = 2;
            for (int i = 3; i < 6; i++)
            {
               m_waveSelectCheckBox[i].Enabled = true;
            }
            textBox_amplitude4.Enabled = true;
            //textBox_lowLevelB.Enabled = true;
                textBox4.Enabled = true;
                //textBox_valueB.Enabled = true;
                //button_manualB.Enabled = true;
                int chanNumberB = m_channelStart + 1;
            label_chanB.Text = "channel"+chanNumberB.ToString();
         }
         label_chanA.Text = "channel"+m_channelStart.ToString();
      }

      private void CheckError(ErrorCode err)
      {
         if (err != ErrorCode.Success)
         {
            timer_outputData.Stop();
            MessageBox.Show("Error: " + err.ToString());         
         }
      }

      private void timer_outputData_Tick(object sender, EventArgs e)
      {
            DateTime beforDT = System.DateTime.Now;
            watch.Start();
            if (m_isCheckedA)
         {
                double temp = m_amplitude2 / 2;
                if (temp <= m_offset2)
                {
                    m_dataScaled[0] = m_waveformGenerator.GetOnePoint(m_formStyleA, m_wavePointsIndexA++, m_amplitude2, m_offset2);
                    if (m_wavePointsIndexA == m_PointCountPerWave)
                    {
                        m_wavePointsIndexA = 0;
                        if (output_num > 0)
                            output_num--;
                        else if (output_num == 0)
                            timer_outputData.Stop();
                    }
                }
                else
                {
                    m_offset2 = temp;
                    m_dataScaled[0] = m_waveformGenerator.GetOnePoint(m_formStyleA, m_wavePointsIndexA++, m_amplitude2, m_offset2);
                    if (m_wavePointsIndexA == m_PointCountPerWave)
                    {
                        m_wavePointsIndexA = 0;
                        if (output_num > 0)
                            output_num--;
                        else if (output_num == 0)
                            timer_outputData.Stop();
                    }
                }
         }
         if (m_isCheckedB)
         {
            double    temp2 = m_amplitude4 / 2;
                if (temp2 <= m_offset4)
                {
                    if (m_channelCount > 1)
                    {
                        m_dataScaled[1] = m_waveformGenerator.GetOnePoint(m_formStyleB, m_wavePointsIndexB++, m_amplitude4, m_offset4);
                    }
                    if (m_wavePointsIndexB == m_PointCountPerWave)
                    {
                        m_wavePointsIndexB = 0;
                    }
                }
                else
                {
                    m_offset4 = temp2;

                    if (m_channelCount > 1)
                    {
                        m_dataScaled[1] = m_waveformGenerator.GetOnePoint(m_formStyleB, m_wavePointsIndexB++, m_amplitude4, m_offset4);
                    }
                    if (m_wavePointsIndexB == m_PointCountPerWave)
                    {
                        m_wavePointsIndexB = 0;
                    }
                }
         }
            
            m_err = m_instantAoCtrl.Write(m_channelStart,m_channelCount,m_dataScaled);
            DateTime afterDT = System.DateTime.Now;
            TimeSpan ts = afterDT.Subtract(beforDT);
            Console.WriteLine("DateTime总共花费{0}ms.", ts.TotalMilliseconds);

           
            CheckError(m_err);
            watch.Stop();  //停止监视
            TimeSpan timespan = watch.Elapsed;  //获取当前实例测量得出的总时间
            //listBox1.Items.Add((timespan.TotalMilliseconds.ToString()));  //总毫秒数  
        }

      private void checkBox_AoDataOut_MouseClick(object sender, MouseEventArgs e)
      {
         int index = Array.IndexOf(m_waveSelectCheckBox, sender);
         CheckBox currentcheckedBox = (CheckBox)sender;
         if (currentcheckedBox.Checked)
         {
                button1.Enabled = false;
                timer_outputData.Start();
                if (comboBox1.Text == "Assigned output period")
                {
                    output_num = Convert.ToInt32(textBox3.Text)-1;
                }
                if (index < 3)
                {
                    checked_numA = true;
                    // make all the checkBoxes is unchecked
                    for (int i = 0; i < 3; i++)
                    {
                        m_waveSelectCheckBox[i].Checked = false;
                        m_waveSelectCheckBox[i].BackgroundImage = imageList.Images[i];
                    }
                    // make the checkBox clicked is checked
                    m_waveSelectCheckBox[index].BackgroundImage = imageList.Images[index + 3];
                    // read the user input value
                    double.TryParse(textBox_amplitude2.Text, out m_amplitude2);
                    //double.TryParse(textBox_lowLevelA.Text, out m_lowLevelA);
                    double.TryParse(textBox2.Text, out m_offset2);
                    double temp = m_amplitude2 ;
                    if (temp<= m_offset2)
                    {
                        m_isCheckedA = true;
                        m_wavePointsIndexA = 0;
                        m_formStyleA = (WaveformStyle)(index % 3);
                        m_dataOnePeriod.Clear();
                        for (uint i = 0; i < m_PointCountPerWave; i++)
                        {
                            m_dataOnePeriod.Add(m_waveformGenerator.GetOnePoint(m_formStyleA, (int)i, m_amplitude2, m_offset2));
                        }
                    }
                    else if(temp+m_amplitude2>5)
                    {
                        m_amplitude2 = 2.5;
                        textBox_amplitude2.Text = System.Convert.ToString(m_amplitude2);
                        m_offset2 = 2.5;
                        textBox2.Text = System.Convert.ToString(m_offset2);
                        m_isCheckedA = true;
                        m_wavePointsIndexA = 0;
                        m_formStyleA = (WaveformStyle)(index % 3);
                        m_dataOnePeriod.Clear();
                        for (uint i = 0; i < m_PointCountPerWave; i++)
                        {
                            m_dataOnePeriod.Add(m_waveformGenerator.GetOnePoint(m_formStyleA, (int)i, m_amplitude2, m_offset2));
                        }
                     }
                    else
                    {
                        m_offset2 = temp;
                        textBox2.Text = System.Convert.ToString(temp);
                        m_isCheckedA = true;
                        m_wavePointsIndexA = 0;
                        m_formStyleA = (WaveformStyle)(index % 3);
                        m_dataOnePeriod.Clear();
                        for (uint i = 0; i < m_PointCountPerWave; i++)
                        {
                            m_dataOnePeriod.Add(m_waveformGenerator.GetOnePoint(m_formStyleA, (int)i, m_amplitude2, m_offset2));
                        }
                    }
                    
                }
            else
            {
                    checked_numB = true;
                    for (int j = 3; j < 6; j++)
               {
                  m_waveSelectCheckBox[j].Checked = false;
                  m_waveSelectCheckBox[j].BackgroundImage = imageList.Images[j - 3];
               }
               m_waveSelectCheckBox[index].BackgroundImage = imageList.Images[index];
               double.TryParse(textBox_amplitude4.Text, out m_amplitude4);
               //double.TryParse(textBox_lowLevelB.Text, out m_lowLevelB);
                    double.TryParse(textBox4.Text, out m_offset4);
                    double temp2 = m_amplitude4;
                    if (temp2 <= m_offset4)
                    {
                        m_isCheckedB = true;
                        m_wavePointsIndexB = 0;
                        m_formStyleB = (WaveformStyle)(index % 3);
                        m_dataOnePeriod.Clear();
                        for (uint i = 0; i < m_PointCountPerWave; i++)
                        {
                            m_dataOnePeriod.Add(m_waveformGenerator.GetOnePoint(m_formStyleB, (int)i, m_amplitude4, m_offset4));
                        }
                    }
                    else if(temp2+m_amplitude4>5)
                     {
                        m_amplitude4 = 2.5;
                        textBox_amplitude4.Text = System.Convert.ToString(m_amplitude4);
                        m_offset4 = 2.5;
                        textBox4.Text = System.Convert.ToString(m_offset4);
                        m_isCheckedB = true;
                        m_wavePointsIndexB = 0;
                        m_formStyleB = (WaveformStyle)(index % 3);
                        m_dataOnePeriod.Clear();
                        for (uint i = 0; i < m_PointCountPerWave; i++)
                        {
                            m_dataOnePeriod.Add(m_waveformGenerator.GetOnePoint(m_formStyleB, (int)i, m_amplitude4, m_offset4));
                        }



                    }
                    else
                    {
                        m_offset4 = temp2;
                        textBox4.Text = System.Convert.ToString(temp2);
                        m_isCheckedB = true;
                        m_wavePointsIndexB = 0;
                        m_formStyleB = (WaveformStyle)(index % 3);
                        m_dataOnePeriod.Clear();
                        for (uint i = 0; i < m_PointCountPerWave; i++)
                        {
                            m_dataOnePeriod.Add(m_waveformGenerator.GetOnePoint(m_formStyleB, (int)i, m_amplitude4, m_offset4));
                        }
                    }
            }
            currentcheckedBox.Checked = true;
                double[] values = (double[])m_dataOnePeriod.ToArray(typeof(double));
                chart2.Series[index / 3].Points.Clear();
                for (uint i = 0; i < m_PointCountPerWave; i++)
                    chart2.Series[index / 3].Points.AddXY(i * (100/trackBar_Scroll.Value/m_PointCountPerWave), values[i]);
         }
         else
         {
                chart2.Series[index / 3].Points.Clear();
                if (index < 3)
            {
                    checked_numA = false;
                    m_waveSelectCheckBox[index].BackgroundImage = imageList.Images[index];
               m_isCheckedA = false;           
            }
            else
            {
                    checked_numB = false;
                    m_waveSelectCheckBox[index].BackgroundImage = imageList.Images[index - 3];
               m_isCheckedB = false;              
            }
                if (!(checked_numA|checked_numB))
                {
                    button1.Enabled = true;
                    timer_outputData.Stop();
                }
            }
            /*double[] values = (double[])m_dataOnePeriod.ToArray(typeof(double));
            foreach (var series in chart2.Series)
            {
                series.Points.Clear();
            }
            chart2.Series[index / 3].Points.Clear();
            for (uint i = 0; i < m_PointCountPerWave; i++)
                chart2.Series[index/3].Points.AddXY(i*trackBar_Scroll.Value,values[i]);*/

        }

      private void trackBar_Scroll_Scroll(object sender, EventArgs e)
      {
            foreach (var series in chart2.Series)
            {
                series.Points.Clear();
            }
            timer_outputData.Interval = (int)(200000/( trackBar_Scroll.Value * m_PointCountPerWave));
         label_interval.Text = (trackBar_Scroll.Value/200.0).ToString() + "Hz";
      }
    
      /*private void button_manualA_Click(object sender, EventArgs e)
      {
         for (int i = 0; i < 3; i++)
         {
            m_waveSelectCheckBox[i].Checked = false;
            m_waveSelectCheckBox[i].BackgroundImage = imageList.Images[i];
         }
         m_isCheckedA = false;
         double.TryParse(textBox_valueA.Text, out m_dataScaled[0]);
      }

      private void button_manualB_Click(object sender, EventArgs e)
      {
         for (int i = 3; i < 6; i++)
         {
            m_waveSelectCheckBox[i].Checked = false;
            m_waveSelectCheckBox[i].BackgroundImage = imageList.Images[i-3];
         }
         m_isCheckedB = false;
         double.TryParse(textBox_valueB.Text, out m_dataScaled[1]);
      }*/

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m_PointCountPerWave = Convert.ToUInt32(textBox1.Text);
            m_waveformGenerator = new WaveformGenerator(m_PointCountPerWave);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text=="Assigned output period")
            {
                textBox3.Enabled = true;
                button2.Enabled = false;
                button3.Enabled = false;
            }
            else if(comboBox1.Text == "Import file")
            {
                textBox3.Enabled = false;
                button2.Enabled = true;
            }
            else
            {
                textBox3.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Title = "Please choose file";
            fileDialog.Filter = "txt file(*.txt)|*.txt";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] names = fileDialog.FileNames;

                foreach (string file in names)
                {
                    MessageBox.Show("Choose file:" + file, "Tips for file", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    filename = file;
                }
                button3.Enabled = true;
            }
            using (FileStream fs = File.Open(filename, FileMode.OpenOrCreate))
            {
                StreamReader r = new StreamReader(fs);
                //r.BaseStream.Seek(0, SeekOrigin.End);
                string line;
                //listBox1.Items.Add(  );
                while ((line=r.ReadLine())!=null)
                {
                    //line = r.ReadLine();
                    string[] sArray = line.Split(' ');
                    //listBox1.Items.Add(sArray[1]);
                    file_time.Add(Convert.ToInt32(sArray[0]));
                    file_data.Add(Convert.ToDouble(sArray[1]));
                }
                r.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer_file.Start();
            time_file = 0;
            count_file = 0;
            foreach (var series in chart2.Series)
            {
                series.Points.Clear();
            }
        }

        private void timer_file_Tick(object sender, EventArgs e)
        {
            time_file += 5;
            if (file_time.Count > count_file && (int)file_time[count_file] - time_file < 5)
            {
                chart2.Series[0].Points.AddXY((int)file_time[count_file], (double)file_data[count_file]);
                m_dataScaled[0] = (double)file_data[count_file];
                m_err = m_instantAoCtrl.Write(0, 1, m_dataScaled);
                CheckError(m_err);
                count_file++;
            }
            else if(file_time.Count > count_file)
            {
                chart2.Series[0].Points.AddXY(time_file, (double)file_data[count_file]);
                m_err = m_instantAoCtrl.Write(0, 1, m_dataScaled);
                CheckError(m_err);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }

}