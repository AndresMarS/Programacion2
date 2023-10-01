using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipoApp.Dominio
{
    public class Jugador : Persona
    {
        public Persona Persona { get; set; }
        public int Camiseta { get; set; }
        public Posicion Posicion { get; set; }
        public Jugador() : base()
        {
            Persona = new Persona();
            Camiseta = 0;
            Posicion = new Posicion();
        }
        public Jugador(string nombreCompleto, int dni, DateTime fechaNac, int camiseta, Posicion posicion) : base(nombreCompleto, dni,fechaNac) 
        {
            Camiseta = camiseta;
            Posicion = posicion;
        }
        public override string ToString()
        {
            return Persona.ToString() + " , Nro: " + Camiseta + ", " + Posicion.ToString();
        }
    }
}
