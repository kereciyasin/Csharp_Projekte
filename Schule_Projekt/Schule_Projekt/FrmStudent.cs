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
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();
        }
        SqlConnection verbinden = new SqlConnection(@"Data Source=kereci\SQLEXPRESS;Initial Catalog=Schule;Integrated Security=True;TrustServerCertificate=True");

        public string nummer;
        private void FrmStudent_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select UnterrichtName, Prufung1, Prufung2, Prufung3, Projekt, Durchschnit, Situation from Tbl_Note\r\nINNER JOIN Tbl_Unterricht ON Tbl_Unterricht.UnterrichtId=Tbl_Note.UnterrichtId WHERE StudentId=@p1", verbinden);
            cmd.Parameters.AddWithValue("@p1", nummer);
            SqlDataAdapter da = new SqlDataAdapter(cmd);  
            DataTable dt = new DataTable(); 
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //

            verbinden.Open();
            SqlCommand cmd2 = new SqlCommand("select StudentName, StudentVorname from Tbl_Student where StudentId=@p1", verbinden);
            cmd2.Parameters.AddWithValue("@p1", nummer);
            SqlDataReader reader = cmd2.ExecuteReader();
            while (reader.Read()) 
            {
            this.Text = reader[0] + " " + reader[1];
            }
            verbinden.Close();


        }
    }
}
