using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
    public class Pedido
    {
        public int Codigo { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string DireccionEntrega { get; set; }
        public DateTime FechaBaja { get; set; }
        public string Entregado { get; set; }

        public Pedido()
        {
            FechaBaja = DateTime.MinValue;
        }


    }
}
