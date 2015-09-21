using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Conrado.DAO
{
    class CorralonDAO
    {
        private String SQL_CONCORRALON = "select * from Corralon";
        private String cadena = Properties.Resources.CadenaConexion;
        public DataTable LoadCorralon()
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = cadena;
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_CONCORRALON, con))
            {
                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                con.Close();
                return tbl;
            }
        }
    }
}
