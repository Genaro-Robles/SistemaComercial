using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;

namespace CapaControl
{
    public class PedidosMgr
    {
        ClsDatos oDatos = new ClsDatos();

        public DataTable ListarPedidos(int vId)
        {
            SqlParameter[] parParametros = new SqlParameter[1];
            parParametros[0] = new SqlParameter();
            parParametros[0].ParameterName = "@id";
            parParametros[0].SqlDbType = SqlDbType.Int;
            parParametros[0].Value = vId;
            //
            DataTable dtt = oDatos.RetornarTabla(parParametros, "sp_Pedidos_Listar");
            return dtt;
        }

        //ACTUALIZAR PEDIDO

        public void ActualizarPedido(Pedidos objPedido)
        {

            oDatos = new ClsDatos();

            try
            {
                SqlParameter[] parParametros = new SqlParameter[5];
                parParametros[0] = new SqlParameter();
                parParametros[0].ParameterName = "@idPedido";
                parParametros[0].SqlDbType = SqlDbType.Int;
                parParametros[0].SqlValue = objPedido.idPedido;
                //

                parParametros[1] = new SqlParameter();
                parParametros[1].ParameterName = "@NombrePedido";
                parParametros[1].SqlDbType = SqlDbType.NVarChar;
                parParametros[1].Size = 30;
                parParametros[1].SqlValue = objPedido.Nombre;

                parParametros[2] = new SqlParameter();
                parParametros[2].ParameterName = "@Fecha";
                parParametros[2].SqlDbType = SqlDbType.Date;
                parParametros[2].Size = 20;
                parParametros[2].SqlValue = objPedido.Fecha;

                parParametros[3] = new SqlParameter();
                parParametros[3].ParameterName = "@Total";
                parParametros[3].SqlDbType = SqlDbType.Money;
                parParametros[3].Size = 20;
                parParametros[3].SqlValue = objPedido.Total;

                parParametros[4] = new SqlParameter();
                parParametros[4].ParameterName = "@idcostos";
                parParametros[4].SqlDbType = SqlDbType.Int;
                parParametros[4].SqlValue = objPedido.idCostos;


                oDatos.ejecutarSP_Nuevo(parParametros, "sp_Pedidos_Actualizar");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        //ELIMINAR PEDIDOS

        public void EliminarPedido(Pedidos objPedidos)
        {
            oDatos = new ClsDatos();
            try
            {
                SqlParameter[] parParametros = new SqlParameter[1];
                parParametros[0] = new SqlParameter();
                parParametros[0].ParameterName = "@idPedido";
                parParametros[0].SqlDbType = SqlDbType.Int;
                parParametros[0].SqlValue = objPedidos.idPedido;

                oDatos.EjecutarSP(parParametros, "sp_Pedidos_Eliminar");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
    }
}
