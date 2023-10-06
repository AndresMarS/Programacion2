using PedidosSLN.Servicios.Implementacion;
using PedidosSLN.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosSLN.Servicios
{
    public class FactoryImp : Factory
    {
        public override IServicio GetServicio()
        {
            return new Servicio();
        }

    }
}
