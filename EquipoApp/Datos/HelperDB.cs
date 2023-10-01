using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquipoApp.Dominio;
using EquipoApp.Vistas;
using System.Data.SqlClient;
using System.Data;
using System.Net;

namespace EquipoApp.Datos
{
    public class HelperDB
    {
        private SqlConnection conexion;
        public HelperDB()
        {
            conexion = new SqlConnection(@"Data Source=FRACTAL-PC\SQLEXPRESS;Initial Catalog=EquipoApp;Integrated Security=True");
        }
        public DataTable ConsultarTabla(string nombreSP)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(nombreSP, conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            cmd.ExecuteNonQuery();
            conexion.Close();
            return tabla;
        }
        public bool InsertarJugador(Jugador jugador)
        {
            bool result = true;
            SqlTransaction t = null;
            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();


                SqlCommand cmdP = new SqlCommand("SP_INSERTAR_PERSONA", conexion, t);
                cmdP.CommandType = CommandType.StoredProcedure;

                cmdP.Parameters.AddWithValue("@nombre_completo", jugador.Persona.NombreCompleto);
                cmdP.Parameters.AddWithValue("@dni", jugador.Persona.Dni);
                cmdP.Parameters.AddWithValue("@fecha_nac", jugador.Persona.FechaNac);

                cmdP.ExecuteNonQuery();


                SqlCommand cmdJ = new SqlCommand("SP_INSERTAR_JUGADOR", conexion, t);
                cmdJ.CommandType = CommandType.StoredProcedure;

                cmdJ.Parameters.AddWithValue("@id_posicion", jugador.Posicion.IdPosicion);
                cmdJ.Parameters.AddWithValue("@dni", jugador.Persona.Dni);
                cmdJ.Parameters.AddWithValue("@camiseta", jugador.Camiseta);

                cmdJ.ExecuteNonQuery();

                t.Commit();
                
            }
            catch
            {
                if (t != null)
                    t.Rollback();
                result = false;
            }
            finally 
            { 
                if((conexion != null)  && (conexion.State  == ConnectionState.Open))
                    conexion.Close();
            }
            return result;
        }
        public void BorrarJugador(int dni)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SP_ELIMINAR_JUGADOR", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@dni", dni); 
            cmd.ExecuteNonQuery();

            conexion.Close();
        }
    }
}
