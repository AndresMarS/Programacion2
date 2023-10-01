using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipoApp
{
    public class Posicion
    {
        public string Nombre { get; set; }
        public int IdPosicion { get; set; }

        public Posicion()
        {
            Nombre = string.Empty;
            IdPosicion = 0;
        }
        public Posicion(string nombre, int idPosicion)
        {
            Nombre = nombre;
            IdPosicion = idPosicion;

        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
