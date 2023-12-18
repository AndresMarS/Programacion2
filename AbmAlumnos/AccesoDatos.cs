using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AbmAlumnos
{
    public class AccesoDatos
    {
        string cadenaConexion = @"Data Source=DESKTOP-GUCH5EE\SQLEXPRESS;Initial Catalog=Alumnos;Integrated Security=True";
        SqlConnection conexion;
        SqlCommand comando;

        public AccesoDatos()
        {
            conexion = new SqlConnection(cadenaConexion);
        }

        public void Conectar()
        {
            conexion.Open();
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }
        public void Desconectar()
        {
            conexion.Close();
        }
        public DataTable ConsultarBD(string consultaSql)
        {
            DataTable dt = new DataTable();
            Conectar();
            comando.CommandText = consultaSql;
            dt.Load(comando.ExecuteReader());
            Desconectar();
            return dt;
        }

        public int ActualizarBD(string nomTabla, string consulta)
        {
            int filasAfectadas = 0;
            Conectar();
            comando.CommandText = consulta;
            filasAfectadas = comando.ExecuteNonQuery();
            Desconectar();
            return filasAfectadas;
        }

        public int InsertarBD (string consultaSql, List<Parametros> lp)
        {
            int filasAfectadas = 0;
            Conectar();
            comando.CommandText = consultaSql;
            comando.Parameters.Clear();
            foreach (Parametros param in lp)
            {
                comando.Parameters.AddWithValue(param.Nombre, param.Valor);
            }
            filasAfectadas = comando.ExecuteNonQuery();
            Desconectar();
            return filasAfectadas;
        }

    }
}
