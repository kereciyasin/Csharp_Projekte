using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schule_Projekt
{
    public partial class FrmUnterricht : Form
    {
        public FrmUnterricht()
        {
            InitializeComponent();
        }

        private void FrmUnterricht_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Tbl_UnterrichtTableAdapter unterricht = new DataSet1TableAdapters.Tbl_UnterrichtTableAdapter();
            dataGridView1.DataSource = unterricht.UnterrichtList();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
