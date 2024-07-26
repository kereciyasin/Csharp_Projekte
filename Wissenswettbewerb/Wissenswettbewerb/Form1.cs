using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wissenswettbewerb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int soruno = 0, dogru = 0 , yanlis = 0;

        private void button5_Click(object sender, EventArgs e)
        {
            soruno++;
            label4.Text = soruno.ToString();
            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet Kac yilinda ilan edilmistir ?";
                btnA.Text = "1920";
                btnB.Text = "1921";
                btnC.Text = "1922";
                btnD.Text = "1923";
            }


        }
    }
}
