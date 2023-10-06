using RecetasSLN.datos;
using RecetasSLN.Servicios.Implementacion;
using RecetasSLN.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.Servicios
{
    public class FactoryImp : Factory
    {
        public override IServicio GetServicio()
        {
            return new Servicio();
        }

    }
}
