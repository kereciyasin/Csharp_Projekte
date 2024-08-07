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
    public partial class Registrierungsformular : Form
    {
        public Registrierungsformular()
        {
            InitializeComponent();
        }

        sql sqlverbinden = new sql();
        private void buttonRegistrieren_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Patient (PatientVorname, PatientName, PatientNummer, PatientTelefon, PatientPass, PatientGender) values (@p1,@p2,@p3,@p4,@p5,@p6)", sqlverbinden.Connection());
            komut.Parameters.AddWithValue("@p1", textVorname.Text);
            komut.Parameters.AddWithValue("@p2", textNachname.Text);
            komut.Parameters.AddWithValue("@p3", maskedId.Text);
            komut.Parameters.AddWithValue("@p4", maskedTelefon.Text);
            komut.Parameters.AddWithValue("@p5", textPass.Text);
            komut.Parameters.AddWithValue("@p6", comboGender.Text);
            komut.ExecuteNonQuery();
            sqlverbinden.Connection().Close();
            MessageBox.Show("Ihre Registrierung war erfolgreich. Ihr Passwort lautet: " + textPass.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public string idno;
        private void Registrierungsformular_Load(object sender, EventArgs e)
        {
            maskedId.Text = idno; 
        }
    }
}
