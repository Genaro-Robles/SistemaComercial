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
    public partial class FrmReporte_Semanal : Form
    {
        public FrmReporte_Semanal()
        {
            InitializeComponent();
        }

        private void crvReporte_Load(object sender, EventArgs e)
        {
            Reporte_Semanal rpt = new Reporte_Semanal();
            crvReporte.ReportSource = rpt;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
