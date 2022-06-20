using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.Reportes;


namespace CapaVista
{
    public partial class FrmMdiPrincipal : Form
    {
        public FrmMdiPrincipal()
        {
            InitializeComponent();
        }

        private void siToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void artículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVistaProductos of = new FrmVistaProductos();
            of.MdiParent = this;
            of.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVistaCostos of = new FrmVistaCostos();
            of.MdiParent = this;
            of.Show();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOperaPedidos of = new FrmOperaPedidos();
            of.MdiParent = this;
            of.Show();
        }

        private void semanalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporte_Semanal of = new FrmReporte_Semanal();
            of.MdiParent = this;
            of.Show();
        }

        private void mensualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporte_Mensual of = new FrmReporte_Mensual();
            of.MdiParent = this;
            of.Show();
        }

        private void unoDeCadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporte_UnoDeCada of = new FrmReporte_UnoDeCada();
            of.MdiParent = this;
            of.Show();
        }

        private void diarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporte_Diario of = new FrmReporte_Diario();
            of.MdiParent = this;
            of.Show();
        }
    }
}
