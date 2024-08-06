using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Projekt_Spital
{
    internal class sql
    {

        public SqlConnection Connection()
        {
            SqlConnection verbinden = new SqlConnection("Data Source=kereci\\SQLEXPRESS;Initial Catalog=Spital_Projekt;Integrated Security=True;Trust Server Certificate=True");
        
        verbinden.Open();
        return verbinden;   
        }


    }
}
