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

        private void btnA_Click(object sender, EventArgs e)
        {
            label8.Text = btnA.Text;
            if (label7.Text == label5.Text)
            {
                dogru++;
                label5.Text = dogru.ToString(); 
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

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
                label7.Text = "1923";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Hangisi ege bölgesinde bulunmaz?";
                btnA.Text = "Izmir";
                btnB.Text = "Balikesir";
                btnC.Text = "Aydin";
                btnD.Text = "Manisa";
                label7.Text = "Balikesir";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Son Kuslar hangi yazara aiitir?";
                btnA.Text = "Sait Faik";
                btnB.Text = "Cemal Süreyya";
                btnC.Text = "Atilla Ilhan";
                btnD.Text = "Resat Nuri";
                label7.Text = "Sait Faik";
            }


        }
    }
}
