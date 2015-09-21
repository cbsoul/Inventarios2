using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Conrado.DAO
{
    class AseguradoraDAO
    {
        private String SQL_CONASEGURADORAS = "select * from Aseguradora";
        private String cadena = Properties.Resources.CadenaConexion;
        public DataTable LoadAseguradoras()
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = cadena;
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_CONASEGURADORAS, con))
            {
                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                con.Close();
                return tbl;
            }



        }
    }
}
