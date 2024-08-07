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
    public partial class SekretärDetails : Form
    {
        public SekretärDetails()
        {
            InitializeComponent();
        }

        public string IdNo;
        sql sql = new sql();

        private void SekretärDetails_Load(object sender, EventArgs e)
        {
            labelSek.Text = IdNo;

            // Vorname Nachname
            SqlCommand cmd = new SqlCommand("Select SekreterVorname, SekreterNachname from Tbl_Sekreter where SekreterNummer = @p1", sql.Connection());  
            cmd.Parameters.AddWithValue("@p1", labelSek.Text);
            SqlDataReader dr1 = cmd.ExecuteReader();
            while (dr1.Read()) {

                label4.Text = dr1[0].ToString() + dr1[1].ToString();

            }
            sql.Connection().Close();   


            // Branch

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Branch", sql.Connection());
            da.Fill(dt);    
            dataGridView1.DataSource = dt;  


            // Ärzte
            DataTable dt3 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from Tbl_Arzt", sql.Connection());
            da2.Fill(dt3);
            dataGridView2.DataSource= dt3;

        }
    }
}
