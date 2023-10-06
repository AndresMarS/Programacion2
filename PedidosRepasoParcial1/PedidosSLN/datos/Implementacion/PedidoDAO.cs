using PedidosSLN.datos;
using PedidosSLN.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosSLN.datos
{
    public class PedidoDAO : IPedidoDAO
    {
        public bool BajarEntregarPedido(int codigo, string bajaEntrega)
        {
            // Da de baja o entrega, según el parametró bajaEntrega

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

        public List<Cliente> GetListClientes(DateTime fDesde, DateTime fHasta)
        {
            // Trae una lista de clientes, y a cada cliente le carga la list de Pedidos con sus respectivos pedidos

            if (fDesde == DateTime.Now.AddDays(-30) && fHasta == DateTime.Now)
            {
                fDesde = DateTime.Now.AddYears(-200);
                fHasta = DateTime.Now;
            }

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
                new Parametro("@fecha_desde",fDesde),
                new Parametro("@fecha_hasta",fHasta)
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
