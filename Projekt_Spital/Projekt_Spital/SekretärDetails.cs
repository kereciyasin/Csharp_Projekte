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

            // Branch bringt
            SqlCommand command2 = new SqlCommand("Select BranchName from Tbl_Branch", sql.Connection());
            SqlDataReader dr2 = command2.ExecuteReader();
            while(dr2.Read())
            {
                comboBranch.Items.Add(dr2[0]);   
            }
            sql.Connection().Close ();


            // Ärzte
            DataTable dt3 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from Tbl_Arzt", sql.Connection());
            da2.Fill(dt3);
            dataGridView2.DataSource= dt3;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("insert into Tbl_Termin (TerminDate, TerminUhr, TerminBranch, TerminArzt) values (@p1,@p2,@p3,@p4)", sql.Connection());
            cmd1.Parameters.AddWithValue("@p1", maskedDatum.Text);
            cmd1.Parameters.AddWithValue("@p2", maskedUhr.Text);
            cmd1.Parameters.AddWithValue("@p3", comboBranch.Text);
            cmd1.Parameters.AddWithValue("@p4", comboArzt.Text);
            cmd1.ExecuteNonQuery();
            sql.Connection().Close();
            MessageBox.Show("Der Termin wurde erstellt.");
    
        }

        private void comboBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboArzt.Items.Clear();
            SqlCommand cmd2 = new SqlCommand("Select ArztVorname, ArztNachname from Tbl_Arzt where ArztAbteillung=@p1", sql.Connection());
            cmd2.Parameters.AddWithValue("@p1", comboBranch.Text);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read()) 
            {

                comboArzt.Items.Add(dr2[0] + " " + dr2[1]);

            }
            sql.Connection().Close();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand mitteilung = new SqlCommand("insert into Tbl_Mitteilung (Mitteilung) values (@d1)", sql.Connection());
            mitteilung.Parameters.AddWithValue("@d1", richTextBox1.Text);
            mitteilung.ExecuteNonQuery();
            sql.Connection().Close();
            MessageBox.Show("Die Mitteilung wurde erstellt!");
        }

        private void buttonArzt_Click(object sender, EventArgs e)
        {
            ArztPanel arztPanel = new ArztPanel();  
            arztPanel.Show();   

        }

        private void buttonBranch_Click(object sender, EventArgs e)
        {
            Branch branch = new Branch();
            branch.Show();
            this.Hide();    
        }

        private void buttonTerminliste_Click(object sender, EventArgs e)
        {
            TerminListe liste = new TerminListe();  
            liste.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonMitteilung_Click(object sender, EventArgs e)
        {
            Mitteilungen mitteilungen = new Mitteilungen(); 
            mitteilungen.Show();
            this.Hide();
        }
    }
}
