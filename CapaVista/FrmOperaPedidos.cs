using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModelo;

namespace CapaVista
{
    public partial class FrmOperaPedidos : Form
    {

        #region "Variables"
        //Definir variables Y Objetos para la clase del formulario
        private ClsProcesosPedidos objPedido = new ClsProcesosPedidos();
        private DataTable Dtb = null;
        private DataRow Drw= null;
        private DataSet Dst = new DataSet();
        private double total;
        private int unidades;
        private short fila;
        #endregion
        #region "Procedimientos"
        private void NuevoPedido()
        {
            //Limpiar controles
            foreach (Control xCtrl in GroupBox1.Controls)
            {
                //if (xCtrl.GetType() == typeof(TextBox) || xCtrl.GetType() == typeof(ComboBox))
                //    xCtrl.Text = "";
                if (xCtrl is TextBox || xCtrl is ComboBox)
                {
                    xCtrl.Text = "";
                }
            }
            foreach (Control xCtrl in GroupBox2.Controls)
            {
                //if (xCtrl.GetType() == typeof(TextBox) || xCtrl.GetType() == typeof(ComboBox))
                //    xCtrl.Text = "";
                if (xCtrl is TextBox || xCtrl is ComboBox)
                {
                    xCtrl.Text = "";
                }
            }
            txtfecha.Text = DateTime.Now.ToShortDateString();
            txtprecio.Text = "0.00";
            cboCostos.Text = "1";
            Cant.Value = 0;
            Dtb.Rows.Clear();
            txttotal.Clear();
            total = 0;
            
            fila = -1;
        } //fin del método NuevoPedido
        private void LlenarListas()
        {
            cboP.DataSource = objPedido.getListas().Tables["tProductos"];
            cboP.DisplayMember = "Nombre";
            cboP.ValueMember = "id";

            cboCostos.DataSource = objPedido.getListas().Tables["tCostos"];
            cboCostos.DisplayMember = "id";
            cboCostos.ValueMember = "id";

        }
        private void ConfigurarTabla()
        {
            /*Definir la estructura de los campos que estará formado la tabla virtual (DTB)
             * y este objeto Dtb se construye, mediante el metodo Add, de la colección
             * Tables de un un objeto DataSet (Dst)
             */
            Dtb = Dst.Tables.Add();
            /*Luego Agregamos las columnas a la colleción columns del datatable virtual */
            Dtb.Columns.Add("Código", System.Type.GetType("System.Int32"));
            Dtb.Columns.Add("Nombre", System.Type.GetType("System.String"));
            Dtb.Columns.Add("Precio", System.Type.GetType("System.Decimal"));
            Dtb.Columns.Add("Cantidad", System.Type.GetType("System.Int32"));
            Dtb.Columns.Add("Importe", System.Type.GetType("System.Decimal"));

            /*Ahora se enlaza el objeto DataTable con el control DataGrid*/
            dgdDetalle.DataSource = Dtb;
        }               
        #endregion
        /***************************Constructor del formulario*******************************************************/
        public FrmOperaPedidos()
        {
            InitializeComponent();
            LlenarListas();
            ConfigurarTabla();
            NuevoPedido();
            CargarCBO();
        }

        private void CargarCBO(){
            //Crear una tablita para los datos del producto seleccionado para el detalle
            DataTable tablita1 = objPedido.getProducto(int.Parse(cboP.SelectedValue.ToString()));
            DataTable tablitaC = objPedido.getCostos(int.Parse(cboCostos.SelectedValue.ToString()));
            /*Pasamos el IdProducto al método
             * Aqui tablita tendrá una sola fila con los datos del Producto
             * estos se copiaran en los controles del groupBox Detalle
             */
            int Mat1 = int.Parse(tablita1.Rows[0][2].ToString());
            int Per1 = int.Parse(tablita1.Rows[0][3].ToString());
            int Imp1 = int.Parse(tablita1.Rows[0][4].ToString());
            int Tra1 = int.Parse(tablita1.Rows[0][5].ToString());

            double MatC = double.Parse(tablitaC.Rows[0][1].ToString());
            double PerC = double.Parse(tablitaC.Rows[0][2].ToString());
            double ImpC = double.Parse(tablitaC.Rows[0][3].ToString());
            double TraC = double.Parse(tablitaC.Rows[0][4].ToString());

            double MatF = Mat1 * MatC;
            double PerF = Per1 * PerC;
            double ImpF = Imp1 * ImpC;
            double TraF = Tra1 * TraC;

            txtprecio.Text = (MatF + PerF + ImpF + TraF).ToString();
            Cant.Value = 0;
            txtmonto.Text = "0.00";
            Cant.Focus();
        }

        private void cboP_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                CargarCBO();

            }
            catch (Exception)
            {
                //Dejar Vacio para evitar el error al inicio de llenarListas 
            }
        }

        private void cboCostos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CargarCBO();

            }
            catch (Exception)
            {
                //Dejar Vacio para evitar el error al inicio de llenarListas 
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if ( Decimal.Parse(txtmonto.Text) > 0)
            {
                //Instanciar el objeto DataRow
                Drw = Dtb.NewRow();
                Drw[0] = cboP.SelectedValue;
                Drw[1] = cboP.Text;
                Drw[2] = float.Parse(txtprecio.Text);
                Drw[3] = Cant.Value;
                Drw[4] = float.Parse(txtmonto.Text);
                //Esta fila que es se la clase DataRow la agregamos a la collección Rows
                //del DataTable Dtb
                Dtb.Rows.Add(Drw);
                /*como el copntrol DataGrid se encuentra enlazado con el DatTable
                 estos datos agregados por la nueva fila se visualizan automaticamente
                 en la Grilla*/
                total += double.Parse(txtmonto.Text);
                unidades += int.Parse(Cant.Value.ToString());
                txttotal.Text = total.ToString("#,##0.00");
                txtuni.Text = unidades.ToString();
                txtprecio.Text = "0.00";
                Cant.Value = 0;
                txtmonto.Text = "0.00";
                cboP.Text = "";
                cboP.Focus();
                
            }
            else
            {
                MessageBox.Show("Falta Ingresar datos obligatorios en el Detalle", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Determina que fila de la grilla esta selecionada para ser eliminada
            fila = short.Parse(dgdDetalle.CurrentCell.RowNumber.ToString());
            if (fila > -1 && Dtb.Rows.Count > 0)
            {
                total -= double.Parse(dgdDetalle[fila, 4].ToString());
                unidades -= int.Parse(dgdDetalle[fila,3].ToString());
                txttotal.Text = total.ToString("#,##0.00");
                txtuni.Text = unidades.ToString();
                Dtb.Rows.RemoveAt(fila);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                int nfilas = Dtb.Rows.Count;
                int CodiPro;
                float PreUni;
                short cantidad;
                float monto;
                if (nfilas > 0)
                {//Se deberá grabar el pedido
                    txtnroP.Text = objPedido.setPedido(txtnombreP.Text, DateTime.Parse(txtfecha.Text), 
                        float.Parse(txttotal.Text), int.Parse(cboCostos.SelectedValue.ToString())).ToString();
                    //Aqui Grabar el detalle del Pedido
                    for (int i = 0; i < nfilas; i++)
                    {
                        CodiPro = int.Parse(dgdDetalle[i, 0].ToString());
                        PreUni = float.Parse(dgdDetalle[i, 2].ToString());
                        cantidad = short.Parse(dgdDetalle[i, 3].ToString());
                        monto = float.Parse(dgdDetalle[i, 4].ToString());
                        //Aqui grabamos cada fila a a la tabla deTallePedido
                        objPedido.setDetalle(int.Parse(txtnroP.Text), CodiPro, PreUni, cantidad,monto);
                        
                        
                    }
                }
                else
                {
                    MessageBox.Show(this,"No Hay Filas en el Detalle del pedido","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                MessageBox.Show("El Pedido se Registro correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NuevoPedido();

            }
            catch (Exception ex)
            {
                throw new Exception("Error:"+ex.Message);
            }
           
        }

        private void lnkSalir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoPedido();
        }

        private void Cant_ValueChanged(object sender, EventArgs e)
        {
            if (Cant.Value > 0)
            {
                txtmonto.Text = (decimal.Parse(txtprecio.Text) * Cant.Value).ToString("#,##0.00");
            }
            else
                txtmonto.Text = "0.00";
        }

        private void btnAdministrar_Click(object sender, EventArgs e)
        {
            FrmVistaPedidos of = new FrmVistaPedidos();
            of.Show();
        }
    }
}
