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
    public partial class FrmVistaCostos : Form
    {
        CostosMgr oControl = null;
        Costos oCostos = null;
        public int filaActual;
        public FrmVistaCostos()
        {
            InitializeComponent();
            ListarCostos();
        }
        private void MostrarTablaDatos(int vop)
        {
            ClsGlobal.vgb_operacion = vop;
            /*configurar el objeto Costos, para enviar los datos a la ventana 
             *de ingresos*/
            oCostos = new Costos();
            filaActual = dgvCostos.CurrentCell.RowIndex;
            oCostos.IdCostos = (int)dgvCostos.Rows[filaActual].Cells[0].Value;
            oCostos.MaterialC = (int)dgvCostos.Rows[filaActual].Cells[1].Value;
            oCostos.PersonalC = (int)dgvCostos.Rows[filaActual].Cells[2].Value;
            oCostos.ImpuestosC = (int)dgvCostos.Rows[filaActual].Cells[3].Value;
            oCostos.TransporteC = (int)dgvCostos.Rows[filaActual].Cells[4].Value;
            oCostos.SuspendidoC = (bool)dgvCostos.Rows[filaActual].Cells[5].Value;

            FrmCostosDatos of = new FrmCostosDatos(oCostos);
            //of.FormClosed += new FormClosedEventHandler(of_FormClosed);
            of.StartPosition = FormStartPosition.CenterScreen;
            of.ShowDialog();

        }
        private void ListarCostos()
        {
            try
            {
                oControl = new CostosMgr();
                DataTable otablita = oControl.ListarCostos(0);
                dgvCostos.DataSource = null;
                dgvCostos.DataSource = otablita;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            MostrarTablaDatos(1);
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
