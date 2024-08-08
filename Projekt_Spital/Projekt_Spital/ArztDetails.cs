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
    public partial class ArztDetails : Form
    {
        public ArztDetails()
        {
            InitializeComponent();
        }
        sql sql = new sql();
        public string ID;

        private void labelId_Click(object sender, EventArgs e)
        {
            

        }

        private void ArztDetails_Load(object sender, EventArgs e)
        {
            labelId.Text = ID;

            // Arzt Vor-Nachname

            SqlCommand cmd = new SqlCommand("Select ArztVorname, ArztNachname from Tbl_Arzt where ArztNummer=@p1", sql.Connection());
            cmd.Parameters.AddWithValue("@p1", labelId.Text );
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) 
            {
            labelArztname.Text = dr[0].ToString() + " " +  dr[1].ToString();
            }
            sql.Connection().Close();


            //Termin

            DataTable dt = new DataTable();
           SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From Tbl_Termin where TerminArzt='" + labelArztname.Text + "'", sql.Connection());   
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button_Click(object sender, EventArgs e)
        {
            ArztdatenBearbeiten arztdatenBearbeiten = new ArztdatenBearbeiten();
            arztdatenBearbeiten.NummerNo = labelId.Text;    
            arztdatenBearbeiten.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mitteilungen mitteilungen = new Mitteilungen(); 
            mitteilungen.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int option = dataGridView1.SelectedCells[0].RowIndex;
            richTextBox1.Text = dataGridView1.Rows[option].Cells[7].Value.ToString();
        }
    }
}
