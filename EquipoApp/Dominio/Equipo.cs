using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipoApp.Dominio
{
    public class Equipo
    {
        public string Nombre { get; set; }
        public string DirectorTecnico { get; set; }

        public List<Jugador> Jugadores { get; set; }
        public Equipo()
        {
            Nombre = string.Empty;
            DirectorTecnico = string.Empty;
            Jugadores = new List<Jugador>();
        }
        public Equipo(string nombre, string DT)
        {
            Nombre = nombre;
            DirectorTecnico = DT;
            Jugadores = new List<Jugador>();
        }
        public void AgregarJugador(Jugador jugador)
        {
            Jugadores.Add(jugador);
        }
        public void QuitarJugador(int index)
        {
            Jugadores.RemoveAt(index);
        }
        public override string ToString()
        {
            return Nombre + " , DT: " + DirectorTecnico;
        }
    }
}
