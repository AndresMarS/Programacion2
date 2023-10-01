using OrdenesRepasoParcial1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesRepasoParcial1.Datos.Interfaz
{
    public interface IOrdenRetiroDAO
    {
        List<Material> GetMateriales();
        int Crear(OrdenRetiro orden);
    }
}
