using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Conrado.DAO
{
    class EntradasDAO
    {

        private String SQL_CONENTRADAS = "usp_consultaEntradas";
        private String cadena = Properties.Resources.CadenaConexion;
        public DataTable LoadEntradas()
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = cadena;
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_CONENTRADAS, con))
            {
                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                con.Close();
                return tbl;
            }


        }
    }
}

