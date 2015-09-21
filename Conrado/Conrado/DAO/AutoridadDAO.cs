using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Conrado.DAO
{
    class AutoridadDAO
    {
        private String SQL_CONAUTORIDAD = "select * from Autoridad";
        private String cadena = Properties.Resources.CadenaConexion;
        public DataTable LoadAutoridad()
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = cadena;
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_CONAUTORIDAD, con))
            {
                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                con.Close();
                return tbl;
            }
        }
    }
}
