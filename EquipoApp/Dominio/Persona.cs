using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipoApp.Dominio
{
    public class Persona
    {
        public string NombreCompleto {  get; set; }
        public int Dni { get; set; }
        public DateTime FechaNac { get; set; }

        public Persona()
        {
            NombreCompleto = string.Empty;
            Dni = 0;
            FechaNac = DateTime.Today;
        }
        public Persona(string nombreCompleto, int dni, DateTime fechaNac)
        {
            this.NombreCompleto = nombreCompleto;
            this.Dni = dni;
            this.FechaNac = fechaNac;
        }
        public override string ToString()
        {
            return NombreCompleto;
        }
    }
}
