using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbmAlumnos
{
    public class AlumnoServicio
    {
        AccesoDatos oBD;
        public AlumnoServicio()
        {
            oBD = new AccesoDatos();
        }

        public DataTable TraerTablaAux(string nomTabla)
        {
            return oBD.ConsultarBD("SELECT * FROM " + nomTabla);
        }

        public List<Alumno> TraerAlumnos()
        {
            List<Alumno> lista = new List<Alumno>();
            DataTable dt = oBD.ConsultarBD("SELECT * FROM Alumnos");
            foreach (DataRow dr in dt.Rows)
            {
                Alumno a = new Alumno();
                a.Apellido = dr["apellido"].ToString();
                a.Nombre = dr["nombre"].ToString();
                a.FechaNac = Convert.ToDateTime(dr["fecha_nac"]);
                a.Sexo = Convert.ToInt32(dr["sexo"]);
                a.TipoDocumento = Convert.ToInt32(dr["id_tipo_documento"]);
                a.NroDocumento = Convert.ToInt32(dr["documento"]);
                a.Calle = dr["calle"].ToString();
                a.NroCalle = Convert.ToInt32(dr["nro_calle"]);
                a.Actividad = Convert.ToBoolean(dr["actividad"]);
                a.Casado = Convert.ToBoolean(dr["casado"]);
                a.Hijos = Convert.ToBoolean(dr["hijos"]);
                a.CantidadHijos = Convert.ToInt32(dr["cantidad_hijos"]);
                a.Carrera = Convert.ToInt32(dr["id_carrera"]);

                lista.Add(a);
            }
            return lista;
        }

        public int Grabar(Alumno a, bool esNuevo)
        {
            if (esNuevo)
            {
                string consultaSql = "INSERT INTO Alumnos VALUES (@apellido, @nombre, @fechaNac, @sexo, @nroDocumento," +
                    " @calle, @nroCalle, @actividad, @casado, @hijos, @cantidadHijos, @carrera, @tipoDocumento)";
                List<Parametros> lp = new List<Parametros>();
                lp.Add(new Parametros("@apellido", a.Apellido));
                lp.Add(new Parametros("@nombre", a.Nombre));
                lp.Add(new Parametros("@fechaNac", a.FechaNac));
                lp.Add(new Parametros("@sexo", a.Sexo));
                lp.Add(new Parametros("@tipoDocumento", a.TipoDocumento));
                lp.Add(new Parametros("@nroDocumento", a.NroDocumento));
                lp.Add(new Parametros("@calle", a.Calle));
                lp.Add(new Parametros("@nroCalle", a.NroCalle));
                lp.Add(new Parametros("@actividad", a.Actividad));
                lp.Add(new Parametros("@casado", a.Casado));
                lp.Add(new Parametros("@hijos", a.Hijos));
                lp.Add(new Parametros("@cantidadHijos", a.CantidadHijos));
                lp.Add(new Parametros("@carrera", a.Carrera));

                return oBD.InsertarBD(consultaSql, lp);
            }
            else
            {
                string consultaSql = "UPDATE Alumnos SET " +
                    "apellido = @apellido," +
                    "nombre = @nombre," +
                    "fecha_nac = @fechaNac," +
                    "sexo = @sexo," +
                    "calle = @calle," +
                    "nro_calle = @nroCalle," +
                    "actividad = @actividad," +
                    "casado = @casado," +
                    "hijos = @hijos," +
                    "cantidad_hijos = @cantidadHijos," +
                    "id_carrera = @carrera" +
                    " WHERE documento = @nroDocumento";
                List<Parametros> lp = new List<Parametros>();
                lp.Add(new Parametros("@apellido", a.Apellido));
                lp.Add(new Parametros("@nombre", a.Nombre));
                lp.Add(new Parametros("@fechaNac", a.FechaNac));
                lp.Add(new Parametros("@sexo", a.Sexo));
                lp.Add(new Parametros("@nroDocumento", a.NroDocumento));
                lp.Add(new Parametros("@calle", a.Calle));
                lp.Add(new Parametros("@nroCalle", a.NroCalle));
                lp.Add(new Parametros("@actividad", a.Actividad));
                lp.Add(new Parametros("@casado", a.Casado));
                lp.Add(new Parametros("@hijos", a.Hijos));
                lp.Add(new Parametros("@cantidadHijos", a.CantidadHijos));
                lp.Add(new Parametros("@carrera", a.Carrera));

                return oBD.InsertarBD(consultaSql, lp);
            }
        }

        public int BorrarRegistro(int nroDocumento)
        {
            string consultaSql = "DELETE alumnos WHERE documento = " + nroDocumento;
            return oBD.ActualizarBD("alumnos", consultaSql);
        }
    }
}
