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
    public partial class TerminListe : Form
    {
        public TerminListe()
        {
            InitializeComponent();
        }
        sql sql = new sql();
        private void TerminListe_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable(); 
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Termin", sql.Connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
    }
}
