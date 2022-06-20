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
    public partial class FrmVistaProductos : Form
    {
        ProductoMgr oControl = null;
        Producto oProducto = null;
        public int filaActual;

        public FrmVistaProductos()
        {
            InitializeComponent();
            ListarProductos();
        }
        private void MostrarTablaDatos(int vop)
        {
            ClsGlobal.vgb_operacion = vop;
            /*configurar el objeto Producto, para enviar los datos a la ventana 
             *de ingresos*/
            oProducto = new Producto();
            filaActual = dgvProductos.CurrentCell.RowIndex;
            oProducto.IdProducto = (int)(dgvProductos.Rows[filaActual].Cells[0].Value);
            oProducto.Nombre = (String)(dgvProductos.Rows[filaActual].Cells[1].Value);
            oProducto.Material = (int)(dgvProductos.Rows[filaActual].Cells[2].Value);
            oProducto.Personal = (int)(dgvProductos.Rows[filaActual].Cells[3].Value);
            oProducto.Impuestos = (int)(dgvProductos.Rows[filaActual].Cells[4].Value);
            oProducto.Transporte = (int)(dgvProductos.Rows[filaActual].Cells[5].Value);

            FrmProductoDatos of = new FrmProductoDatos(oProducto);
            //of.FormClosed += new FormClosedEventHandler(of_FormClosed);
            of.StartPosition = FormStartPosition.CenterScreen;
            of.ShowDialog();

        }
        private void ListarProductos()
        {
            try
            {
                oControl = new ProductoMgr();
                DataTable otablita = oControl.ListarProductos(0);
                dgvProductos.DataSource = null;
                dgvProductos.DataSource = otablita;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private void btnAdicionarProd_Click(object sender, EventArgs e)
        {
            MostrarTablaDatos(1);
        }

        private void btnActualizarProd_Click(object sender, EventArgs e)
        {
            MostrarTablaDatos(2);
        }

        private void btnEliminarProd_Click(object sender, EventArgs e)
        {
            MostrarTablaDatos(3);
        }

        private void btnCerrarProd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
