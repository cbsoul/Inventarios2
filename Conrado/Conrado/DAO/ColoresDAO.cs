using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Conrado.DTO;

namespace Conrado.DAO
{
    class ColoresDAO
    {
        private String SQL_CONCOLORES = "select * from colores";
        private String cadena = Properties.Resources.CadenaConexion;
        public DataTable LoadColores()
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = cadena;
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_CONCOLORES, con))
            {
                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                con.Close();
                return tbl;
            }



        }
        public void newColor(ColoresDTO new_proy)
        {
            String SQL_NewProyeccion = "insert into colores values ('"+ new_proy.color +"')";

            SqlConnection con = getConexion();
            SqlCommand cmd = new SqlCommand(SQL_NewProyeccion, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        private SqlConnection getConexion()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = cadena;
            con.Open();
            return con;
        }
    }
}
