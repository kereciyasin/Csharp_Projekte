using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntragAufVerkauf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // global
        int rechnung = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            int popcorn, ticket, wasser, tee, total;
            popcorn = Convert.ToInt32(textPopcorn.Text);
            ticket = Convert.ToInt32(textTicket.Text);
            wasser = Convert.ToInt32(textWasser.Text);
            tee = Convert.ToInt32(textTee.Text);
            total = popcorn * 4 + ticket * 10 + wasser * 1 + tee * 4;
            labelTotal.Text = total.ToString() + "CHF";
            rechnung = rechnung + total;
            labelRechnung.Text = rechnung.ToString() + "CHF";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textPopcorn.Text = "";
            textTee.Text = "";
            textTicket.Text = "";
            textWasser.Text = "";
            textPopcorn.Focus();
        }
    }
}
