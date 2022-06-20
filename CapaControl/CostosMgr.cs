using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaModelo;
using CapaEntidad;
using System.Data;

namespace CapaControl
{
    public class CostosMgr
    {
        ClsDatos oDatos = new ClsDatos();

        public DataTable ListarCostos(int vId)
        {
            SqlParameter[] parParametros = new SqlParameter[1];
            parParametros[0] = new SqlParameter();
            parParametros[0].ParameterName = "@id";
            parParametros[0].SqlDbType = SqlDbType.Int;
            parParametros[0].Value = vId;
            //
            DataTable dtt = oDatos.RetornarTabla(parParametros, "sp_Costos_Listar");
            return dtt;
        }

        /********GuardarCostos******/
        public int GuardarCostos(Costos objCostos)
        {

            int idCost = 0;

            try
            {
                SqlParameter[] parParametros = new SqlParameter[6];
                parParametros[0] = new SqlParameter();
                parParametros[0].ParameterName = "@id";
                parParametros[0].SqlDbType = SqlDbType.Int;
                parParametros[0].Direction = ParameterDirection.Output;

                parParametros[1] = new SqlParameter();
                parParametros[1].ParameterName = "@material";
                parParametros[1].SqlDbType = SqlDbType.Int;
                parParametros[1].Size = 20;
                parParametros[1].SqlValue = objCostos.MaterialC;

                parParametros[2] = new SqlParameter();
                parParametros[2].ParameterName = "@personal";
                parParametros[2].SqlDbType = SqlDbType.Int;
                parParametros[2].Size = 20;
                parParametros[2].SqlValue = objCostos.PersonalC;

                parParametros[3] = new SqlParameter();
                parParametros[3].ParameterName = "@impuestos";
                parParametros[3].SqlDbType = SqlDbType.Int;
                parParametros[3].SqlValue = objCostos.ImpuestosC;

                parParametros[4] = new SqlParameter();
                parParametros[4].ParameterName = "@transporte";
                parParametros[4].SqlDbType = SqlDbType.Int;
                parParametros[4].Size = 50;
                parParametros[4].SqlValue = objCostos.TransporteC;

                parParametros[5] = new SqlParameter();
                parParametros[5].ParameterName = "@Suspendido";
                parParametros[5].SqlDbType = SqlDbType.Bit;
                parParametros[5].Size = 30;
                parParametros[5].SqlValue = objCostos.SuspendidoC;

                idCost = oDatos.ejecutarSP_Nuevo(parParametros, "sp_Costos_Adicionar");


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return idCost;
        }

        //ACTUALIZAR COSTOS

        public void ActualizarCostos(Costos objCostos)
        {

            oDatos = new ClsDatos();

            try
            {
                SqlParameter[] parParametros = new SqlParameter[6];
                parParametros[0] = new SqlParameter();
                parParametros[0].ParameterName = "@id";
                parParametros[0].SqlDbType = SqlDbType.Int;
                parParametros[0].SqlValue = objCostos.IdCostos;
                //

                parParametros[1] = new SqlParameter();
                parParametros[1].ParameterName = "@material";
                parParametros[1].SqlDbType = SqlDbType.Int;
                parParametros[1].Size = 20;
                parParametros[1].SqlValue = objCostos.MaterialC;

                parParametros[2] = new SqlParameter();
                parParametros[2].ParameterName = "@personal";
                parParametros[2].SqlDbType = SqlDbType.Int;
                parParametros[2].Size = 20;
                parParametros[2].SqlValue = objCostos.PersonalC;

                parParametros[3] = new SqlParameter();
                parParametros[3].ParameterName = "@impuestos";
                parParametros[3].SqlDbType = SqlDbType.Int;
                parParametros[3].SqlValue = objCostos.ImpuestosC;

                parParametros[4] = new SqlParameter();
                parParametros[4].ParameterName = "@transporte";
                parParametros[4].SqlDbType = SqlDbType.Int;
                parParametros[4].Size = 50;
                parParametros[4].SqlValue = objCostos.TransporteC;

                parParametros[5] = new SqlParameter();
                parParametros[5].ParameterName = "@Suspendido";
                parParametros[5].SqlDbType = SqlDbType.Bit;
                parParametros[5].Size = 30;
                parParametros[5].SqlValue = objCostos.SuspendidoC;

                oDatos.ejecutarSP_Nuevo(parParametros, "sp_Costos_Actualizar");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        //ELIMINAR COSTOS

        public void EliminarCostos(Costos objCostos)
        {
            oDatos = new ClsDatos();
            try
            {
                SqlParameter[] parParametros = new SqlParameter[1];
                parParametros[0] = new SqlParameter();
                parParametros[0].ParameterName = "@id";
                parParametros[0].SqlDbType = SqlDbType.Int;
                parParametros[0].SqlValue = objCostos.IdCostos;

                oDatos.EjecutarSP(parParametros, "sp_Costos_Eliminar");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
    }
}
