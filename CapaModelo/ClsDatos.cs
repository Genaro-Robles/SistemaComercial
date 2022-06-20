using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace CapaModelo
{
    public class ClsDatos
    {
        #region "Declaraciones"
        /*Aqui en esta clase se crean las operaciones genéricas de la Aplicación*/
        SqlConnection conex = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnConexion"].ConnectionString);
        SqlCommand cmd = null;
        SqlDataAdapter dap = null;
        DataTable dt = null;
        DataSet ds = null;
        #endregion
        #region "Métodos Funcionales"
        public void EjecutarSP(SqlParameter[] parParametros, String spNombre)
        {
            try
            {
                //Instanciar Objetos
                cmd = new SqlCommand();
                cmd.Connection = conex;
                //Abrir conexión
                conex.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = spNombre;
                cmd.Parameters.AddRange(parParametros);
                //Ejecutar el sp mediante cmd
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conex.Dispose();
                cmd.Dispose();
            }

        }//fin del método

        /*********Listar las tablas para la vista de los combos****/
        public DataSet RetornarTablitas()
        {
            try
            {
                //Instanciar Objetos para las operaciones de listar pedidos para los combos
                ds = new DataSet();
                dap = new SqlDataAdapter("sp_Lista_Pedidos", conex);
                dap.Fill(ds, "tpedidos");
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                //conex.Dispose();
                //cmd.Dispose();
            }
            return ds;
        }

        public int ejecutarSP_Nuevo(SqlParameter[] parParametros, String spNombre)
        {
            try
            {
                //Instanciar Objetos
                cmd = new SqlCommand();
                cmd.Connection = conex;
                conex.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = spNombre;
                cmd.Parameters.AddRange(parParametros);
                //Ejecutar el sp mediante cmd
                cmd.ExecuteNonQuery();
                return (int)cmd.Parameters[0].Value;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                conex.Dispose();
                cmd.Dispose();
            }
        }
        
        /*Método para que retorne una tabla de datos: Ejecute Select*/
        public DataTable RetornarTabla(SqlParameter[] parparametros, String nomSP)
        {
            try
            {
                //Instanciar Objetos
                dt = new DataTable();
                cmd = new SqlCommand();
                cmd.Connection = conex;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nomSP;
                cmd.Parameters.AddRange(parparametros);
                dap = new SqlDataAdapter(cmd);
                dap.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conex.Dispose();
                cmd.Dispose();
            }
            return dt;
        }
        /***----------------------------***/
        public SqlDataReader RetornarDatos(SqlParameter[] parparametros, String nomSP)
        {
            SqlDataReader dr = null;
            try
            {
                SqlCommand cmd = new SqlCommand(nomSP, conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(parparametros);
                conex.Open();
                dr = cmd.ExecuteReader();
                return dr;
                dr.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
    }
}
