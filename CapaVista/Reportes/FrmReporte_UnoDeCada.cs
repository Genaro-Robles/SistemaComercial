using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Reportes
{
    public partial class FrmReporte_UnoDeCada : Form
    {
        public FrmReporte_UnoDeCada()
        {
            InitializeComponent();
        }

        private void crvReporte_Load(object sender, EventArgs e)
        {
            Reporte_UnoDeCada rpt = new Reporte_UnoDeCada();
            crvReporte.ReportSource = rpt;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
