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
    public partial class ArztdatenBearbeiten : Form
    {
        public ArztdatenBearbeiten()
        {
            InitializeComponent();
        }
        sql sql = new sql();
        public string NummerNo;
        private void ArztdatenBearbeiten_Load(object sender, EventArgs e)
        {
            maskedId.Text = NummerNo;

            SqlCommand cmd = new SqlCommand("Select * From Tbl_Arzt where ArztNummer=@p1", sql.Connection());
            cmd.Parameters.AddWithValue("@p1", maskedId.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textVorname.Text = reader[1].ToString();
                textNachname.Text = reader[2].ToString();
                comboBox1.Text = reader[3].ToString();
                textPass.Text = reader[5].ToString();
            }
            sql.Connection().Close();   
        }

        private void buttonRegistrieren_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update Tbl_Arzt set ArztVorname=@p1, ArztNachname=@p2, ArztAbteillung=@p3, ArztPass=@p4 where ArztNummer=@p5", sql.Connection());
            cmd.Parameters.AddWithValue("@p1", textVorname.Text);
            cmd.Parameters.AddWithValue("@p2", textNachname.Text);
            cmd.Parameters.AddWithValue("@p3", comboBox1.Text);
            cmd.Parameters.AddWithValue("@p4", textPass.Text);
            cmd.Parameters.AddWithValue("@p5", maskedId.Text);
            cmd.ExecuteNonQuery();
            sql.Connection().Close();
            MessageBox.Show("Update!");
                                          }
        
    }
}
