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
            SqlCommand sqlCommand = new SqlCommand("update Tbl_Patient set PatientVorname=@p1, PatientName=@p2, PatientTelefon=@p3, PatientPass=@p4 where PatientNummer=@p5", sqlverbinden.Connection());
            sqlCommand.Parameters.AddWithValue("@p1", textVorname.Text);
            sqlCommand.Parameters.AddWithValue("@p2", textNachname.Text);
            sqlCommand.Parameters.AddWithValue("@p3", maskedTelefon.Text);
            sqlCommand.Parameters.AddWithValue("@p4", textPass.Text);
            sqlCommand.Parameters.AddWithValue("@p5", maskedId.Text);
            sqlCommand.ExecuteNonQuery();
            sqlverbinden.Connection().Close();
            MessageBox.Show("Die Daten wurden erfolgreich aktualisiert", "Information", MessageBoxButtons.OK,MessageBoxIcon.Warning);




        }
        public string idno;

        sql verbinden = new sql();
        private void Registrierungsformular_Load(object sender, EventArgs e)
        {
           
            maskedId.Text = idno;

         SqlCommand komut1 = new SqlCommand("Select * from Tbl_Patient where PatientNummer=@p1", verbinden.Connection());
            komut1.Parameters.AddWithValue("@p1", maskedId.Text);
            SqlDataReader reader = komut1.ExecuteReader();
            while (reader.Read())
            {
                textVorname.Text = reader[1].ToString();
                textNachname.Text = reader[2].ToString();
                maskedTelefon.Text = reader[4].ToString();
                textPass.Text = reader[5].ToString();
                comboGender.Text = reader[6].ToString();
            } 
            verbinden.Connection().Close();
        }

    }
}
