using CarpinteriaApp.datos;
using RecetasSLN.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.datos
{
    public class PedidoDAO : IPedidoDAO
    {
        public bool BajarEntregarPedido(int codigo, string bajaEntrega)
        {
            string sp = string.Empty;
            switch (bajaEntrega)
            {
                case "baja":
                    sp = "SP_REGISTRAR_BAJA";
                    break;
                case "entrega":
                    sp = "SP_REGISTRAR_ENTREGA";
                    break;
            }

            bool result = false;

            List<Parametro> l = new List<Parametro>
            {
                new Parametro("@codigo", codigo),
            };

            if (HelperDB.ObtenerInstancia().EjecutarSQL(sp, l) != 0)
                result = true;

            return result;
        }

        public List<Cliente> GetListClientes()
        {
            DataTable dtClientes = HelperDB.ObtenerInstancia().ConsultaSQL("SP_CONSULTAR_CLIENTES");

            List<Cliente> lClientes = new List<Cliente>();

            foreach (DataRow dr in dtClientes.Rows)
            {
                Cliente c = new Cliente();
                c.Id = Convert.ToInt32(dr["id_cliente"]);
                c.Nombre = dr["nombre"].ToString();
                c.Apellido = dr["apellido"].ToString();
                c.Dni = Convert.ToInt32(dr["dni"]);
                c.CodigoPostal = Convert.ToInt32(dr["cod_postal"]);


                List<Parametro> l = new List<Parametro>
                {
                new Parametro("@cliente", c.Id),
                new Parametro("@fecha_desde",DateTime.Now.AddYears(-200)),
                new Parametro("@fecha_hasta",DateTime.Now)
                };

                DataTable dtPedidos = HelperDB.ObtenerInstancia().ConsultaSQL("SP_CONSULTAR_PEDIDOS", l);

                foreach (DataRow dr2 in dtPedidos.Rows)
                {
                    Pedido p = new Pedido();
                    p.Codigo = Convert.ToInt32(dr2["codigo"]);
                    p.FechaEntrega = Convert.ToDateTime(dr2["fec_entrega"]);
                    p.DireccionEntrega = dr2["dir_entrega"].ToString();
                    if (DBNull.Value != dr2["fecha_baja"])
                        p.FechaBaja = Convert.ToDateTime(dr2["fecha_baja"]);
                    p.Entregado = dr2["entregado"].ToString();
                    c.Pedidos.Add(p);
                }
                lClientes.Add(c);
            }
            return lClientes;
        }
    }
}
