using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projekt_Spital
{
    public partial class Patientenanmeldung : Form
    {
        public Patientenanmeldung()
        {
            InitializeComponent();
        }
        sql sqlverbinden = new sql();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registrierungsformular registrierungsformular = new Registrierungsformular();
            registrierungsformular.Show();
            this.Close();
        }


        private void buttonEinloggen_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * From Tbl_Patient Where PatientNummer=@p1 AND PatientPass=@p2", sqlverbinden.Connection());
            command.Parameters.AddWithValue("@p1", maskedId.Text);
            command.Parameters.AddWithValue("@p2", textPass.Text);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read()) {
            
            Patientendetails patientendetails = new Patientendetails();
                patientendetails.id = maskedId.Text;
                patientendetails.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Benutzername oder Passwort fehlerhaft!");
            }
            sqlverbinden.Connection().Close(); 


        }

        private void Patientenanmeldung_Load(object sender, EventArgs e)
        {

        }
    }
}
