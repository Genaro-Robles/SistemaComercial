using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace CapaModelo
{
    public class ConexionBD
    {
        SqlConnection oConex = null;
        public ConexionBD()
        {
            oConex = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnConexion"].ConnectionString);
        }

        // conex = new SqlConnection(@"Data Source=LAB204-PCINST;DataBase=DBPrueba;User Id=sa;Password=123; Connection Timeout=30;");
        public SqlConnection GetConnection()
        {
            return oConex;
        }
    }
}
