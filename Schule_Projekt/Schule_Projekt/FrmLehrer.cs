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
    public partial class FrmLehrer : Form
    {
        public FrmLehrer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmClub frmClub = new FrmClub();
            frmClub.Show();

        }
    }
}
