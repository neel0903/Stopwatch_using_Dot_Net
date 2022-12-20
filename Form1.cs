using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stopwatch
{
    public partial class Form1 : Form
    {
        int ch = 0, cm = 0, cs = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            Timers.Stop();
        }

        private void Timers_Tick(object sender, EventArgs e)
        {
            if (cs < 60)
            {
                cs += 1;
            }
            else if (cm<60)
            {
                cm += 1;
                cs = 0;
            }

            
            else
            {
                ch += 1;
                cm = 0;
            }
                txts.Text = Convert.ToString(cs);
                txtm.Text = Convert.ToString(cm);
                txth.Text = Convert.ToString(ch);
            
        }

        private void Btnstart_Click(object sender, EventArgs e)
        {
            Timers.Start();
        }
    }
}
