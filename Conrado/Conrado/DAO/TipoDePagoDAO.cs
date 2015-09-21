using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Conrado.DAO
{
    class TipoDePagoDAO
    {
        private String SQL_CONTIPODEPAGO = "select * from Tpago";
        private String cadena = Properties.Resources.CadenaConexion;
        public DataTable LoadTipoDePago()
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = cadena;
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_CONTIPODEPAGO, con))
            {
                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                con.Close();
                return tbl;
            }
        }
    }
}
