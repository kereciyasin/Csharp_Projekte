using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Spital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPatient_Click(object sender, EventArgs e)
        {
            Patientenanmeldung patientenanmeldung = new Patientenanmeldung();
            patientenanmeldung.Show();
            this.Hide();    
        }

        private void buttonArzt_Click(object sender, EventArgs e)
        {
            Arzt arzt = new Arzt();
            arzt.Show();
            this.Hide();
        }
    }
}
