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

namespace Schule_Projekt
{
    public partial class FrmClub : Form
    {
        public FrmClub()
        {
            InitializeComponent();
        }
        SqlConnection verbinden = new SqlConnection(@"Data Source=kereci\SQLEXPRESS;Initial Catalog=Schule;Integrated Security=True;TrustServerCertificate=True");
        private void FrmClub_Load(object sender, EventArgs e)
        {


        }
       public void blick()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From Tbl_Club", verbinden);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void buttonBlick_Click(object sender, EventArgs e)
        {
            blick();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            verbinden.Open();
            SqlCommand cmd = new SqlCommand("Insert Into Tbl_Club (ClubName) values (@p1)",verbinden);
            cmd.Parameters.AddWithValue("@p1", textClubName.Text);
            cmd.ExecuteNonQuery();  
            verbinden.Close();
            MessageBox.Show("Club hinzugefügt");
        }
    }
}
