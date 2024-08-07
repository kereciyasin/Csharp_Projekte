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
    public partial class Mitteilungen : Form
    {
        public Mitteilungen()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        sql sql = new sql();
        private void Mitteilungen_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Mitteilung", sql.Connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
