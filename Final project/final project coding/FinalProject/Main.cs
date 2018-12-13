using AO_StaticAO;
using DO_StaticDO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AI_InstantAI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        Form frm;
        private void button1_Click(object sender, EventArgs e)
        {
            if(frm!=null)
                frm.Close();
            frm = new InstantAIForm();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (frm != null)
                frm.Close();
            frm = new StaticAOForm();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (frm != null)
                frm.Close();
            frm = new StaticDOForm();
            frm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
