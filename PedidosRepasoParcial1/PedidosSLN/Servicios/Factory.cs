using RecetasSLN.datos;
using RecetasSLN.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.Servicios
{
    public abstract class Factory
    {
        public abstract IServicio GetServicio();
    }
}
