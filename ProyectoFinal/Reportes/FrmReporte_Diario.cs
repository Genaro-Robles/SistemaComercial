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
    public partial class FrmReporte_Diario : Form
    {
        public FrmReporte_Diario()
        {
            InitializeComponent();
        }

        private void crvReporte_Load(object sender, EventArgs e)
        {
            Reporte_Diario rpt = new Reporte_Diario();
            crvReporte.ReportSource = rpt;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
