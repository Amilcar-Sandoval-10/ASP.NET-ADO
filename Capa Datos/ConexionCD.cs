using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Capa_Datos
{
    public class ConexionCD
    {

        private static ConexionCD objConexionCD = null;
        private SqlConnection con;

        private ConexionCD ()
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=ventas;Integrated Security=True");

        }

        public static ConexionCD SaberEstado()
        {
            if (objConexionCD == null)
            {
                objConexionCD = new ConexionCD();
            }
            return objConexionCD;
        }

        public SqlConnection getCon()
        {
            return con;
        }

        public void closeCD()
        {
            objConexionCD = null;
        }

    }
}
