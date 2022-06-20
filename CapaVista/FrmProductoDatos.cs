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
    public partial class FrmProductoDatos : Form
    {
        #region "Declaraciones EmpleadosDatos"

        Producto objProducto = null;
        ProductoMgr objProductoMgr = null;
        DataSet dst = null;

        #endregion

        public FrmProductoDatos(Producto oProd)
        {
            InitializeComponent();
            objProducto = oProd;
            MostrarDatos();
        }
        
        /*Método verificarIngreso*/
        private Boolean verificarIngreso()
        {
            Boolean valor = true;
            foreach (TextBox item
                in gbxDatosProd.Controls.OfType<TextBox>().OrderBy(tb => tb.TabIndex))
            {

                if (item.Text.Equals("") && !(item.Name.Equals("txtIdprod")))
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
                    objProducto.IdProducto = 0;
                else
                    objProducto.IdProducto = int.Parse(txtIdprod.Text);
                ////////
                objProducto.Nombre = txtNomprod.Text;
                objProducto.Material = int.Parse(txtMaterial.Text);
                objProducto.Personal = int.Parse(txtPersonal.Text);
                objProducto.Impuestos = int.Parse(txtImpuestos.Text);
                objProducto.Transporte = int.Parse(txtTransporte.Text);
                objProducto.Suspendido = chkSuspendido.Checked ? true : false;

            }
            return OK;
        }
        //Metodo para llenar el formulario con los datos recibidos desde el formulario
        //FrmVistaEmpleados (se envia por el objeto)
        void MostrarDatos()
        {
            if (ClsGlobal.vgb_operacion == 2 || ClsGlobal.vgb_operacion == 3)
            {//Si es una operacion Actualizar o Eliminar empleado
                txtIdprod.Text = objProducto.IdProducto.ToString();
                txtNomprod.Text = objProducto.Nombre.ToUpper();
                txtMaterial.Text = objProducto.Material.ToString();
                txtPersonal.Text = objProducto.Personal.ToString();
                txtImpuestos.Text = objProducto.Impuestos.ToString();
                txtTransporte.Text = objProducto.Transporte.ToString();
                chkSuspendido.Checked = objProducto.Suspendido;
            }
            /////////////////////////
            if (ClsGlobal.vgb_operacion == 1)//ingresar nuevo
            {
                gbxDatosProd.Enabled = true;
                this.Text = "Ingreso de Nuevo Producto";
                btnAceptar.Text = "Grabar Nuevo";
                txtNomprod.Focus();
            }
            else if (ClsGlobal.vgb_operacion == 2)//actualizar datos
            {
                gbxDatosProd.Enabled = true;
                this.Text = "Modificar Datos del Producto";
                btnAceptar.Text = "Grabar Cambios";
                txtNomprod.Focus();
            }
            else  //Eliminar Producto
            {
                gbxDatosProd.Enabled = false;
                this.Text = "Eliminar Producto";
                btnAceptar.Text = "Eliminar Registro";

            }
        }
        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Tener en cuenta el tipo de operación al guardar los datos del empleado
            switch (ClsGlobal.vgb_operacion)
            {
               case 1: GuardarAdicionar(); break;
               case 2: GuardarActualizar(); break;
               case 3: Eliminar(); break;
            }
        }
        
        private void GuardarAdicionar()
        {
            try
            {
                if (MessageBox.Show("¿Esta Seguro que quiere Guardar Nuevo Producto!!!?",
                    "Aviso", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (CopiarDatosObjeto())
                    {
                        objProductoMgr = new ProductoMgr();//


                        int newObjId = objProductoMgr.GuardarProducto(objProducto);

                        txtIdprod.Text = newObjId.ToString();
                        MessageBox.Show("El Producto se Grabó correctamente....",
                            "Aviso", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Falta Completar los datos...");
                    }
                }

            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void GuardarActualizar()
        {
            try
            {
                if (CopiarDatosObjeto())
                {
                    objProductoMgr = new ProductoMgr();//

                    objProductoMgr.ActualizarProducto(objProducto);

                    MessageBox.Show("El Producto se Actualizó correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Falta Completar los datos...");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        
        private void Eliminar()
        {
            try
            {
                if (CopiarDatosObjeto())
                {
                    objProductoMgr = new ProductoMgr();//

                    objProductoMgr.EliminarProducto(objProducto);

                    MessageBox.Show("El Producto se Elimino correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


        }
    }
}
