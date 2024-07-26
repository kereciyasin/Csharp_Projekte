using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Wissenswettbewerb
{

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int frageNo = 0, frageTrue = 0, frageFalsch = 0;

        private void btnNext_Click(object sender, EventArgs e)
        {
            frageNo++;
            lblFrage.Text = frageNo.ToString();

            if (frageNo == 1)
            {
                richTextBox1.Text = "Was ist die Hauptstadt der Schweiz?";
                BtnA.Text = "Bern";
                BtnB.Text = "Zürich";
                BtnC.Text = "Basel";
                BtnD.Text = "Paris";
                label4.Text = "Bern";

            }
            if(frageNo == 2)
            {
                richTextBox1.Text = "Welche Sprache gehört nicht zu den offiziellen Sprachen der Schweiz?";
                BtnA.Text = "Englisch";
                BtnB.Text = "Deutsch";
                BtnC.Text = "Türkisch";
                BtnD.Text = "Französisch";
                label4.Text = "Deutsch";
            }
            if (frageNo == 3)
            {
                richTextBox1.Text = "Welcher ist der höchste Berg der Schweiz?";
                BtnA.Text = "Pilatus";
                BtnB.Text = "Matterhorn";
                BtnC.Text = "Jungfrau";
                BtnD.Text = "Dufourspitze";
                label4.Text = "Jungfrau";
            }
            }
    }
}
