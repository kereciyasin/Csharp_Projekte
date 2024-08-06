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
    public partial class Patientenanmeldung : Form
    {
        public Patientenanmeldung()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registrierungsformular registrierungsformular = new Registrierungsformular();
            registrierungsformular.Show();
            this.Close();
        }
    }
}
