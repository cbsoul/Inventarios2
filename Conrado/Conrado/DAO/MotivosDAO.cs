using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Conrado.DAO
{
    class MotivosDAO
    {
        private String SQL_CONMOTIVO = "select * from Motivos";
        private String cadena = Properties.Resources.CadenaConexion;
        public DataTable LoadMotivo()
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = cadena;
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_CONMOTIVO, con))
            {
                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                con.Close();
                return tbl;
            }
        }

    }
}
