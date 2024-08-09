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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textClubId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textClubName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void buttonDelete(object sender, EventArgs e)
        {
            verbinden.Open();
            SqlCommand cmd2 = new SqlCommand("Delete from Tbl_Club where ClubId=@p1",verbinden);
            cmd2.Parameters.AddWithValue("@p1", textClubId.Text);
            cmd2.ExecuteNonQuery();
            verbinden.Close();
            MessageBox.Show("Das wurde gelöscht!");
            blick();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            verbinden.Open();
            SqlCommand sqlCommand1 = new SqlCommand("Update Tbl_Club set ClubName=@p1 where ClubId=@p2", verbinden);
            sqlCommand1.Parameters.AddWithValue("@p1", textClubName.Text);
            sqlCommand1.Parameters.AddWithValue("@p2", textClubId.Text);
            sqlCommand1.ExecuteNonQuery();
            verbinden.Close();
            blick();
        }
    }
}
