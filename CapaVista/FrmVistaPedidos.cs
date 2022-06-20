using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControl;
using CapaEntidad;
using System.Data.SqlClient;


namespace CapaVista
{
    public partial class FrmVistaPedidos : Form
    {
        PedidosMgr oControl = null;
        Pedidos oPedidos = null;
        public int filaActual;
        public FrmVistaPedidos()
        {
            InitializeComponent();
            ListarPedidos();
        }
        private void MostrarTablaDatos(int vop)
        {
            ClsGlobal.vgb_operacion = vop;
            /*configurar el objeto Pedidos, para enviar los datos a la ventana 
             *de ingresos*/
            oPedidos = new Pedidos();
            filaActual = dgvPedidos.CurrentCell.RowIndex;
            oPedidos.idPedido = (int)dgvPedidos.Rows[filaActual].Cells[0].Value;
            oPedidos.Nombre = (String)dgvPedidos.Rows[filaActual].Cells[1].Value;
            oPedidos.Fecha = (DateTime)dgvPedidos.Rows[filaActual].Cells[2].Value;
            oPedidos.Total = float.Parse(dgvPedidos.Rows[filaActual].Cells[3].Value.ToString());
            oPedidos.idCostos = (int)dgvPedidos.Rows[filaActual].Cells[4].Value;

            FrmPedidosDatos of = new FrmPedidosDatos(oPedidos);
            //of.FormClosed += new FormClosedEventHandler(of_FormClosed);
            of.StartPosition = FormStartPosition.CenterScreen;
            of.ShowDialog();

        }
        private void ListarPedidos()
        {
            try
            {
                oControl = new PedidosMgr();
                DataTable otablita = oControl.ListarPedidos(0);
                dgvPedidos.DataSource = null;
                dgvPedidos.DataSource = otablita;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MostrarTablaDatos(2);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MostrarTablaDatos(3);
        }

        private void btnCerra_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
