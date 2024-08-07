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
    public partial class ArztPanel : Form
    {
        public ArztPanel()
        {
            InitializeComponent();
        }
        sql sql = new sql();
        private void ArztPanel_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from Tbl_Arzt", sql.Connection());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            // Branch bringt
            SqlCommand command2 = new SqlCommand("Select BranchName from Tbl_Branch", sql.Connection());
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {
                comboBranch.Items.Add(dr2[0]);
            }
            sql.Connection().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Arzt (ArztVorname, ArztNachname, ArztAbteillung, ArztNummer, ArztPass) values (@p1,@p2,@p3,@p4,@p5)", sql.Connection());
            cmd.Parameters.AddWithValue("@p1", textVorname.Text);
            cmd.Parameters.AddWithValue("@p2", textNachname.Text);
            cmd.Parameters.AddWithValue("@p3", comboBranch.Text);
            cmd.Parameters.AddWithValue("@p4", maskedNummer.Text);
            cmd.Parameters.AddWithValue("@p5", textPass.Text);
            cmd.ExecuteNonQuery();
            sql.Connection().Close();
            MessageBox.Show("Arzt erfolgreich hinzugefügt");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int option = dataGridView1.SelectedCells[0].RowIndex;
            textVorname.Text = dataGridView1.Rows[option].Cells[1].Value.ToString();
            textNachname.Text = dataGridView1.Rows[option].Cells[2].Value.ToString();
            comboBranch.Text = dataGridView1.Rows[option].Cells[3].Value.ToString();
            maskedNummer.Text = dataGridView1.Rows[option].Cells[4].Value.ToString();
            textPass.Text = dataGridView1.Rows[option].Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand1 = new SqlCommand("Delete from Tbl_Arzt where ArztNummer=@p1", sql.Connection());
            sqlCommand1.Parameters.AddWithValue("@p1", maskedNummer.Text);
            sqlCommand1.ExecuteNonQuery();
            sql.Connection().Close();
            MessageBox.Show("Die Daten wurde gelöscht.", "Achtung!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button3_Click(object sender, EventArgs e)
        {
           SqlCommand cmd = new SqlCommand("Update Tbl_Arzt set ArztVorname=@p1, ArztNachname=@p2, ArztAbteillung=@p3, ArztPass=@p5 where ArztNummer=@p4", sql.Connection());
            cmd.Parameters.AddWithValue("@p1", textVorname.Text);
            cmd.Parameters.AddWithValue("@p2", textNachname.Text);
            cmd.Parameters.AddWithValue("@p3", comboBranch.Text);
            cmd.Parameters.AddWithValue("@p4", maskedNummer.Text);
            cmd.Parameters.AddWithValue("@p5", textPass.Text);
            cmd.ExecuteNonQuery();
            sql.Connection().Close();
            MessageBox.Show("Update ist erfolgreich!");
        }

        private void comboBranch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
