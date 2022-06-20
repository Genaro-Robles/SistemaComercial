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
    public class ProductoMgr
    {
        ClsDatos oDatos = new ClsDatos();

        public DataTable ListarProductos(int vId)
        {
            SqlParameter[] parParametros = new SqlParameter[1];
            parParametros[0] = new SqlParameter();
            parParametros[0].ParameterName = "@id";
            parParametros[0].SqlDbType = SqlDbType.Int;
            parParametros[0].Value = vId;
            //
            DataTable dtt = oDatos.RetornarTabla(parParametros, "sp_Productos_Listar");
            return dtt;
        }
        
        /********GuardarProducto******/
        public int GuardarProducto(Producto objProducto)
        {

            int idProd = 0;

            try
            {
                SqlParameter[] parParametros = new SqlParameter[7];
                parParametros[0] = new SqlParameter();
                parParametros[0].ParameterName = "@id";
                parParametros[0].SqlDbType = SqlDbType.Int;
                parParametros[0].Direction = ParameterDirection.Output;
                //

                parParametros[1] = new SqlParameter();
                parParametros[1].ParameterName = "@Nombre";
                parParametros[1].SqlDbType = SqlDbType.NVarChar;
                parParametros[1].Size = 20;
                parParametros[1].SqlValue = objProducto.Nombre;

                parParametros[2] = new SqlParameter();
                parParametros[2].ParameterName = "@Material";
                parParametros[2].SqlDbType = SqlDbType.Int;
                parParametros[2].Size = 20;
                parParametros[2].SqlValue = objProducto.Material;

                parParametros[3] = new SqlParameter();
                parParametros[3].ParameterName = "@Personal";
                parParametros[3].SqlDbType = SqlDbType.Int;
                parParametros[3].Size = 20;
                parParametros[3].SqlValue = objProducto.Personal;

                parParametros[4] = new SqlParameter();
                parParametros[4].ParameterName = "@Impuestos";
                parParametros[4].SqlDbType = SqlDbType.Int;
                parParametros[4].SqlValue = objProducto.Impuestos;

                parParametros[5] = new SqlParameter();
                parParametros[5].ParameterName = "@Transporte";
                parParametros[5].SqlDbType = SqlDbType.Int;
                parParametros[5].Size = 50;
                parParametros[5].SqlValue = objProducto.Transporte;

                parParametros[6] = new SqlParameter();
                parParametros[6].ParameterName = "@Suspendido";
                parParametros[6].SqlDbType = SqlDbType.Bit;
                parParametros[6].Size = 30;
                parParametros[6].SqlValue = objProducto.Suspendido;

                idProd = oDatos.ejecutarSP_Nuevo(parParametros, "sp_Producto_Adicionar");


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return idProd;
        }

        //ACTUALIZAR Producto

        public void ActualizarProducto(Producto objProducto)
        {

            oDatos = new ClsDatos();

            try
            {
                SqlParameter[] parParametros = new SqlParameter[7];
                parParametros[0] = new SqlParameter();
                parParametros[0].ParameterName = "@id";
                parParametros[0].SqlDbType = SqlDbType.Int;
                parParametros[0].SqlValue = objProducto.IdProducto;
                //

                parParametros[1] = new SqlParameter();
                parParametros[1].ParameterName = "@Nombre";
                parParametros[1].SqlDbType = SqlDbType.NVarChar;
                parParametros[1].Size = 20;
                parParametros[1].SqlValue = objProducto.Nombre;

                parParametros[2] = new SqlParameter();
                parParametros[2].ParameterName = "@Material";
                parParametros[2].SqlDbType = SqlDbType.Int;
                parParametros[2].Size = 20;
                parParametros[2].SqlValue = objProducto.Material;

                parParametros[3] = new SqlParameter();
                parParametros[3].ParameterName = "@Personal";
                parParametros[3].SqlDbType = SqlDbType.Int;
                parParametros[3].Size = 20;
                parParametros[3].SqlValue = objProducto.Personal;

                parParametros[4] = new SqlParameter();
                parParametros[4].ParameterName = "@Impuestos";
                parParametros[4].SqlDbType = SqlDbType.Int;
                parParametros[4].SqlValue = objProducto.Impuestos;

                parParametros[5] = new SqlParameter();
                parParametros[5].ParameterName = "@Transporte";
                parParametros[5].SqlDbType = SqlDbType.Int;
                parParametros[5].Size = 50;
                parParametros[5].SqlValue = objProducto.Transporte;

                parParametros[6] = new SqlParameter();
                parParametros[6].ParameterName = "@Suspendido";
                parParametros[6].SqlDbType = SqlDbType.Bit;
                parParametros[6].Size = 30;
                parParametros[6].SqlValue = objProducto.Suspendido;

                oDatos.ejecutarSP_Nuevo(parParametros, "sp_Producto_Actualizar");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        //ELIMINAR PRODUCTO

        public void EliminarProducto(Producto objProducto)
        {
            oDatos = new ClsDatos();
            try
            {
                SqlParameter[] parParametros = new SqlParameter[1];
                parParametros[0] = new SqlParameter();
                parParametros[0].ParameterName = "@id";
                parParametros[0].SqlDbType = SqlDbType.Int;
                parParametros[0].SqlValue = objProducto.IdProducto;

                oDatos.EjecutarSP(parParametros, "sp_Producto_Eliminar");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
    }
}
