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

        }
    }
}
