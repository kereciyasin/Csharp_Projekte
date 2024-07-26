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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0;

        private void BtnA_Click(object sender, EventArgs e)
        {
            label5.Text = BtnA.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;   
            BtnD.Enabled = false;   
            soruno++;
            lblSoruno.Text = soruno.ToString(); 
            if (soruno == 1)
            {
                richTextBox1.Text = "Was ist die Hauptstadt der Schweiz?";
                BtnA.Text = "Zürich";
                BtnB.Text = "Bern";
                BtnC.Text = "Basel";
                BtnD.Text = "Madrid";
                label4.Text = "Bern";
            }
            if (soruno == 2) 
            {
                richTextBox1.Text = "Welche Sprache gehört nicht zu den offiziellen Sprachen der Schweiz?";
                BtnA.Text = "Englich";
                BtnB.Text = "Deutsch";
                BtnC.Text = "Türkce";
                BtnD.Text = "Madrid";
                label4.Text = "Deutsch";
            }
            if (soruno == 3) {
                richTextBox1.Text = "Welcher ist der höchste Berg der Schweiz?";
                BtnA.Text = "Jungfrau";
                BtnB.Text = "Matterhorn";
                BtnC.Text = "Asa";
                BtnD.Text = "Madrid";
                label4.Text = "Jungfrau";
            }
        }
    }
}
