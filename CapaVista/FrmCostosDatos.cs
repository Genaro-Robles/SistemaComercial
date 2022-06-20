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

    public partial class FrmCostosDatos : Form
    {
        #region "Declaraciones CostosDatos"
        
        Costos objCostos = null;
        CostosMgr objCostosMgr = null;
        DataSet dst = null;
        
        #endregion

        public FrmCostosDatos(Costos oCost)
        {
            InitializeComponent();
            objCostos = oCost;
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
                    objCostos.IdCostos = 0;
                else
                    objCostos.IdCostos = int.Parse(txtId.Text);
                ////////
                objCostos.MaterialC = int.Parse(txtMaterialC.Text);
                objCostos.PersonalC = int.Parse(txtPersonalC.Text);
                objCostos.ImpuestosC = int.Parse(txtImpuestosC.Text);
                objCostos.TransporteC = int.Parse(txtTransporteC.Text);
                objCostos.SuspendidoC = chkSus.Checked ? true : false;

            }
            return OK;
        }
        //Metodo para llenar el formulario con los datos recibidos desde el formulario
        //FrmVistaEmpleados (se envia por el objeto)
        void MostrarDatos()
        {
            if (ClsGlobal.vgb_operacion == 2 || ClsGlobal.vgb_operacion == 3)
            {//Si es una operacion Actualizar o Eliminar empleado
                txtId.Text = objCostos.IdCostos.ToString();
                txtMaterialC.Text = objCostos.MaterialC.ToString();
                txtPersonalC.Text = objCostos.PersonalC.ToString();
                txtImpuestosC.Text = objCostos.ImpuestosC.ToString();
                txtTransporteC.Text = objCostos.TransporteC.ToString();
                chkSus.Checked = objCostos.SuspendidoC;
            }
            /////////////////////////
            if (ClsGlobal.vgb_operacion == 1)//ingresar nuevo
            {
                gbxDatos.Enabled = true;
                this.Text = "Ingreso de Nuevos Costos";
                btnAceptar.Text = "Grabar Nuevo";
                txtMaterialC.Focus();
            }
            else if (ClsGlobal.vgb_operacion == 2)//actualizar datos
            {
                gbxDatos.Enabled = true;
                this.Text = "Modificar Datos de los Costos";
                btnAceptar.Text = "Grabar Cambios";
                txtMaterialC.Focus();
            }
            else  //Eliminar empleado
            {
                gbxDatos.Enabled = false;
                this.Text = "Eliminar Costos";
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
        private void GuardarAdicionar() {
            try
            {
                if (MessageBox.Show("¿Esta Seguro que quiere Guardar Nuevos Costos!!!?", 
                    "Aviso", MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (CopiarDatosObjeto())
                    {
                        objCostosMgr = new CostosMgr();


                        int newCostId = objCostosMgr.GuardarCostos(objCostos);

                        txtId.Text = newCostId.ToString();
                        MessageBox.Show("Los Costos se Grabaron correctamente....", 
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
                    objCostosMgr = new CostosMgr();//

                    objCostosMgr.ActualizarCostos(objCostos);

                    MessageBox.Show("Los Costos se Actualizaron correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    objCostosMgr = new CostosMgr();

                    objCostosMgr.EliminarCostos(objCostos);

                    MessageBox.Show("Los Costos se Eliminaron correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


        }
    }
}
