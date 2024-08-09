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
        DataSet1TableAdapters.Tbl_UnterrichtTableAdapter unterricht = new DataSet1TableAdapters.Tbl_UnterrichtTableAdapter();
        private void FrmUnterricht_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = unterricht.UnterrichtList();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonHin_Click(object sender, EventArgs e)
        {
            unterricht.UnterrichtInsert(textClubName.Text);
            MessageBox.Show("Der Unterricht wurde hingefügzt.");
            
        }

        private void buttonBlick_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = unterricht.UnterrichtList();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            unterricht.UnterrichtDelete(byte.Parse(textClubId.Text));
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            unterricht.UnterrichtUpdate(textClubName.Text, byte.Parse(textClubId.Text));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textClubId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textClubName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
