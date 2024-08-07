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
    public partial class SekretärLogin : Form
    {
        public SekretärLogin()
        {
            InitializeComponent();
        }

        sql sql = new sql();

        private void buttonEinloggen_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * From Tbl_Sekreter where SekreterNummer=@p1 and SekreterPass=@p2", sql.Connection());
            cmd.Parameters.AddWithValue("@p1", maskedId.Text);
            cmd.Parameters.AddWithValue("@p2", textPass.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
            SekretärDetails sekretärDetails = new SekretärDetails();
                sekretärDetails.IdNo = maskedId.Text;
                sekretärDetails.Show();
                this.Hide();    
           
            }
            else
            {
                MessageBox.Show("Error!");
            }
            sql.Connection().Close();

        }

        private void SekretärLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
