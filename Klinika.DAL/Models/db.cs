using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Klinika.DAL.Models
{
    class db
    {
        SqlConnection con = new SqlConnection("Server=.;Initial Catalog=Klinika; Integrated Security=true;");
               // "DefaultConnection": "Server=.;Initial Catalog=Klinika; Integrated Security=true;"

        public DataTable GetRecord()
        {
            SqlCommand com = new SqlCommand("select * from Prijem", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();

            return dt;
        }

    }
}
