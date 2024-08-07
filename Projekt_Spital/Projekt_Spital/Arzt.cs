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
    public partial class Arzt : Form
    {
        public Arzt()
        {
            InitializeComponent();
        }

        sql sql = new sql();    
        private void buttonEinloggen_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Tbl_Arzt where ArztNummer = @p1 And ArztPass = @p2", sql.Connection());
            cmd.Parameters.AddWithValue("@p1",maskedId.Text);
            cmd.Parameters.AddWithValue("@p2", textPass.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read()) 
            {
             ArztDetails arztDetails = new ArztDetails();
                arztDetails.Show();

            }
            else
            {
                MessageBox.Show("Error!");
            }
            sql.Connection().Close();   

        }
    }
}
