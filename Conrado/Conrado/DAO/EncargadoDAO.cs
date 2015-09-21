using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Conrado.DAO
{
    class EncargadoDAO
    {

        private String SQL_CONENCARGADO = "select * from Encargado";
        private String cadena = Properties.Resources.CadenaConexion;
        public DataTable LoadEncargado()
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = cadena;
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_CONENCARGADO, con))
            {
                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                con.Close();
                return tbl;
            }
        }
    }
}
