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




        }
    }
}
