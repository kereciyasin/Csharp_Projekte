using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeUhr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int uhr, minute, sekunde;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sekunde++;
            label1.Text = sekunde.ToString();
            if(sekunde== 60)
            {
                minute++;
                label2.Text = minute.ToString();    
                sekunde = 0;
                if (minute == 5)
                {
                    uhr = uhr + 1;
                }
            }
        }
    }
}
