using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbmAlumnos
{
    public class Alumno
    {
        public string Apellido { get; set; }
        public string Nombre { get; set;}
        public DateTime FechaNac { get; set; }
        public int Sexo { get; set; }
        public int TipoDocumento { get; set; }
        public int NroDocumento { get; set; }
        public string Calle { get; set; }
        public int NroCalle { get; set; }
        public bool Actividad { get; set; }
        public bool Casado { get; set; }
        public bool Hijos { get; set; }
        public int CantidadHijos { get; set; }
        public int Carrera { get; set; }

        public Alumno()
        {
            Apellido = string.Empty;
            Nombre = string.Empty;
            FechaNac = new DateTime();
            Sexo = 0;
            TipoDocumento = 0;
            NroDocumento = 0;
            Calle = string.Empty;
            NroCalle = 0;
            Actividad = false;
            Casado = false;
            Hijos = false;
            CantidadHijos = 0;
            Carrera = 0;
        }
        public Alumno(string apellido, string nombre, DateTime fechaNac, int sexo, int tipoDocumento, int nroDocumento,
            string calle, int nroCalle, bool actividad, bool casado, bool hijos,int cantidadHijos, int carrera)
        {
            Apellido = apellido;
            Nombre = nombre;
            FechaNac = fechaNac;
            Sexo = sexo;
            TipoDocumento = tipoDocumento;
            NroDocumento = nroDocumento;
            Calle = calle;
            NroCalle = nroCalle;
            Actividad = actividad; 
            Casado = casado;
            Hijos = hijos;
            CantidadHijos = cantidadHijos;
            Carrera = carrera;
        }
        public override string ToString()
        {
            return Apellido + ", " + Nombre;
        }
    }
}
