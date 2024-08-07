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
    public partial class Branch : Form
    {
        public Branch()
        {
            InitializeComponent();
        }

        sql sql = new sql();    

        private void Branch_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable(); 
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Branch", sql.Connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Branch (BranchName) values (@b1)", sql.Connection()); 
            cmd.Parameters.AddWithValue("@b1", textName.Text);
            cmd.ExecuteNonQuery();
            sql.Connection().Close();
            MessageBox.Show("Branch wurde gestellt.");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int option = dataGridView1.SelectedCells[0].RowIndex;
            textBranch.Text = dataGridView1.Rows[option].Cells[0].Value.ToString();
            textName.Text = dataGridView1.Rows[option].Cells[1].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Delete from Tbl_Branch where BranchId =@b1", sql.Connection());
            sqlCommand.Parameters.AddWithValue("@b1", textBranch.Text);
            sqlCommand.ExecuteNonQuery();   
            sql.Connection().Close();
            MessageBox.Show("Delete!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update Tbl_Branch set BranchName=@p1 where BranchId=@p2", sql.Connection());
            command.Parameters.AddWithValue("@p1", textName.Text);
            command.Parameters.AddWithValue("@p2", textBranch.Text);
            command.ExecuteNonQuery();  
            sql.Connection().Close();
            MessageBox.Show("Update!");

        }
    }
}
