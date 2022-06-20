using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaModelo
{
    /*
    ' Métodos a Programar en la clase:
    ' getListas   -->Devuelve Datables:Empleados,Clientes y Productos =(DataSet)
    ' getProducto -->Devuelve los Datos de un Producto según su Id.
    ' setPedido   -->Registrar los datos de un nuevo Pedido
    ' setDetalle  -->Registrar los Detalles del Pedido.
    ' SetActualizarProducto --> Actualizar stock del Producto.
    '------------------------------------------------------------------
    */

    public class ClsProcesosPedidos
    {
        private const String Conex = "Integrated Security=true;Server=REXAR151;User=sa;Password=123;DataBase=LPFinal";
        public DataSet getListas()
        {
            try
            {
                SqlConnection cn = new SqlConnection(Conex);
                SqlDataAdapter Dap = new SqlDataAdapter("sp_Productos_Listado", cn);
                DataSet Dst = new DataSet();
                //Llenar el dataset
                Dap.Fill(Dst, "tProductos");
                Dap.SelectCommand.CommandText = "sp_Costos_Listado";
                Dap.Fill(Dst, "tCostos");
                return Dst;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public DataTable getProducto(int vIdPro)
        {
            try
            {
                SqlConnection cn = new SqlConnection(Conex);
                SqlDataAdapter Dap = new SqlDataAdapter("sp_Producto_Dato", cn);
                DataTable Dt = new DataTable();
                Dap.SelectCommand.CommandType = CommandType.StoredProcedure;
                Dap.SelectCommand.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = vIdPro;
                Dap.Fill(Dt);
                return Dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable getCostos(int vIdC)
        {
            try
            {
                SqlConnection cn = new SqlConnection(Conex);
                SqlDataAdapter Dap = new SqlDataAdapter("sp_Costos_Dato", cn);
                DataTable Dt = new DataTable();
                Dap.SelectCommand.CommandType = CommandType.StoredProcedure;
                Dap.SelectCommand.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = vIdC;
                Dap.Fill(Dt);
                return Dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int setPedido(String vNom, DateTime vFecha, Double vTotal, Double vIdCostos)
        {
            try
            {

                SqlConnection cn = new SqlConnection(Conex);
                SqlCommand Cmd = new SqlCommand("sp_Pedido_Adicionar", cn);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@IdPedido", SqlDbType.Int)).Direction = ParameterDirection.Output;
                Cmd.Parameters.Add(new SqlParameter("@NombrePedido", SqlDbType.VarChar, 30)).Value = vNom;
                Cmd.Parameters.Add(new SqlParameter("@Fecha", SqlDbType.SmallDateTime)).Value = vFecha;
                Cmd.Parameters.Add(new SqlParameter("@Total", SqlDbType.Money)).Value = vTotal;
                Cmd.Parameters.Add(new SqlParameter("@idcostos", SqlDbType.Int)).Value = vIdCostos;
                cn.Open();
                Cmd.ExecuteScalar();
                return int.Parse(Cmd.Parameters["@IdPedido"].Value.ToString());
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public void setDetalle(int vIdPedido, int vIdPro, double vPrecio, short vCantidad, Double vImporte)
        {
            try
            {
                SqlConnection cn = new SqlConnection(Conex);
                SqlCommand Cmd = new SqlCommand("sp_Detalle_Adicionar", cn);

                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@IdPedido", SqlDbType.Int)).Value = vIdPedido;
                Cmd.Parameters.Add(new SqlParameter("@IdProducto", SqlDbType.Int)).Value = vIdPro;
                Cmd.Parameters.Add(new SqlParameter("@PrecioUnidad", SqlDbType.Money)).Value = vPrecio;
                Cmd.Parameters.Add(new SqlParameter("@Cantidad", SqlDbType.SmallInt)).Value = vCantidad;
                Cmd.Parameters.Add(new SqlParameter("@Importe", SqlDbType.Money)).Value = vImporte;
                cn.Open();
                Cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /*************************************************/

    }
}
