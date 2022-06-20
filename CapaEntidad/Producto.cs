using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public String Nombre { get; set; }
        public int Material { get; set; }
        public int Personal { get; set; }
        public int Impuestos { get; set; }
        public int Transporte { get; set; }
        public bool Suspendido { get; set; }
    }
}
