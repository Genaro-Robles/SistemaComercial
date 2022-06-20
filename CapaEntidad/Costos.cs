using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Costos
    {
        public int IdCostos { get; set; }
        public int MaterialC { get; set; }
        public int PersonalC { get; set; }
        public int ImpuestosC { get; set; }
        public int TransporteC { get; set; }
        public bool SuspendidoC { get; set; }
    }
}
