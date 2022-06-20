using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Pedidos
    {
        public int idPedido { get; set; }
        public String Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public float Total { get; set; }
        public int idCostos { get; set; }
    }
}
