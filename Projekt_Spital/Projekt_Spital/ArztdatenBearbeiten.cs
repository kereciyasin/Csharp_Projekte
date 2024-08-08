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
    public partial class ArztdatenBearbeiten : Form
    {
        public ArztdatenBearbeiten()
        {
            InitializeComponent();
        }
        sql sql = new sql();
        public string NummerNo;
        private void ArztdatenBearbeiten_Load(object sender, EventArgs e)
        {
            maskedId.Text = NummerNo;
        }
    }
}
