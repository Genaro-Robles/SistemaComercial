using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaControl;
using System.Data.SqlClient;

namespace CapaVista
{

    public partial class FrmPedidosDatos : Form
    {
        #region "Declaraciones PedidosDatos"
        
        Pedidos objPedidos = null;
        PedidosMgr objPedidosMgr = null;
        DataSet dst = null;
        
        #endregion

        public FrmPedidosDatos(Pedidos oPed)
        {
            InitializeComponent();
            objPedidos = oPed;
            MostrarDatos();
        }

        /*Método verificarIngreso*/
        private Boolean verificarIngreso()
        {
            Boolean valor = true;
            foreach (TextBox item 
                in gbxDatos.Controls.OfType<TextBox>().OrderBy(tb => tb.TabIndex))
            {

                if (item.Text.Equals("") && !(item.Name.Equals("txtId")))
                    valor = false;
            }

            return valor;
        }
        /*Método CopiarDatosObjeto*/
        private Boolean CopiarDatosObjeto()
        {
            Boolean OK = false;
            if (verificarIngreso())
            {
                OK = true;
                if (ClsGlobal.vgb_operacion == 1)
                    objPedidos.idPedido = 0;
                else
                    objPedidos.idPedido = int.Parse(txtId.Text);
                ////////
                objPedidos.Nombre = txtNombre.Text;
                objPedidos.Fecha = DateTime.Parse(txtFecha.Text);
                objPedidos.Total = float.Parse(txtTotal.Text);
                objPedidos.idCostos = int.Parse(txtIdCosto.Text);

            }
            return OK;
        }

        //Metodo para llenar el formulario con los datos recibidos desde el formulario
        //FrmVistaEmpleados (se envia por el objeto)
        void MostrarDatos()
        {
            if (ClsGlobal.vgb_operacion == 2 || ClsGlobal.vgb_operacion == 3)
            {//Si es una operacion Actualizar o Eliminar empleado
                txtId.Text = objPedidos.idPedido.ToString();
                txtNombre.Text = objPedidos.Nombre.ToString();
                txtFecha.Text = objPedidos.Fecha.ToString();
                txtTotal.Text = objPedidos.Total.ToString();
                txtIdCosto.Text = objPedidos.idCostos.ToString();
            }
            /////////////////////////
            if (ClsGlobal.vgb_operacion == 2)//actualizar datos
            {
                gbxDatos.Enabled = true;
                this.Text = "Modificar Datos del Pedido";
                btnAceptar.Text = "Grabar Cambios";
                txtNombre.Focus();
            }
            else  //Eliminar empleado
            {
                gbxDatos.Enabled = false;
                this.Text = "Eliminar Pedido";
                btnAceptar.Text = "Eliminar Registro";

            }
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Tener en cuenta el tipo de operación al guardar los datos del empleado
            switch (ClsGlobal.vgb_operacion)
            {
                case 2: GuardarActualizar(); break;
                case 3: Eliminar(); break;
            }
        }
       
        private void GuardarActualizar()
        {
            try
            {
                if (CopiarDatosObjeto())
                {
                    MessageBox.Show("El Pedido se Actualizo correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    objPedidosMgr = new PedidosMgr();//

                    objPedidosMgr.ActualizarPedido(objPedidos);
                    
                }
                else
                {
                    MessageBox.Show("Falta Completar datos...");
                }
            }
            catch (Exception ex)
            {

                //throw new Exception(ex.Message);
            }

        }


        private void Eliminar()
        {
            try
            {
                if (CopiarDatosObjeto())
                {
                    MessageBox.Show("El Pedido se Elimino correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    objPedidosMgr = new PedidosMgr();
                    
                    objPedidosMgr.EliminarPedido(objPedidos);

                    
                }
            }
            catch (Exception ex)
            {

                //throw new Exception(ex.Message);
            }


        }
    }
}
