﻿using System;
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
    public partial class Patientendetails : Form
    {
        public Patientendetails()
        {
            InitializeComponent();
        }
        sql sqlverbinden = new sql();

        public string id;
        private void Patientendetails_Load(object sender, EventArgs e)
        {
            labelId.Text = id;

            SqlCommand cmd = new SqlCommand("Select PatientVorname, PatientName From Tbl_Patient Where PatientNummer=@p1", sqlverbinden.Connection());
            cmd.Parameters.AddWithValue("@p1", labelId.Text);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
            
            labelNanme.Text = sqlDataReader[0] + " " + sqlDataReader[1];    

            }
            sqlverbinden.Connection().Close();  

            //Termin

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Termin where PatientNummer=" + id, sqlverbinden.Connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Branch

            SqlCommand sqlCommand2 = new SqlCommand("Select BranchName From Tbl_Branch", sqlverbinden.Connection());
            SqlDataReader sqlDataReader2 = sqlCommand2.ExecuteReader();

            while (sqlDataReader2.Read())
            {
                comboBranch.Items.Add(sqlDataReader2[0]);
            }
            sqlverbinden.Connection().Close();


        }

        private void comboBranch_SelectedIndexChanged(object sender, EventArgs e)


        {
            comboArzt.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select ArztVorname, ArztNachname From Tbl_Arzt where ArztAbteillung=@p1", sqlverbinden.Connection());
            cmd.Parameters.AddWithValue("@p1", comboBranch.Text);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read()) 
            {
            comboArzt.Items.Add(sqlDataReader[0] + " " + sqlDataReader[1]);
            }
            sqlverbinden.Connection().Close();  
        }

        private void comboArzt_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable(); 
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Termin where TerminBranch='" + comboBranch.Text+ "'" + " and TerminArzt='"+ comboArzt.Text + "' and TerminSitution=0", sqlverbinden.Connection());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registrierungsformular registrierungsformular = new Registrierungsformular();
            registrierungsformular.idno = labelId.Text;
            registrierungsformular.Show();
            
            
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int option = dataGridView2.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView2.Rows[option].Cells[0].Value.ToString();
        }

        private void buttonBuchen_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("update Tbl_Termin set TerminSitution=1, PatientNummer=@p1, PatientErk=@p2 where TerminId=@p3", sqlverbinden.Connection());  
            sqlCommand.Parameters.AddWithValue("@p1", labelId.Text);
            sqlCommand.Parameters.AddWithValue("@p2", richTextBox1.Text);
            sqlCommand.Parameters.AddWithValue("@p3", textBox1.Text);
            sqlCommand.ExecuteNonQuery();
            sqlverbinden.Connection().Close();
            MessageBox.Show("Erfolgreich!");

        }
    }
}
