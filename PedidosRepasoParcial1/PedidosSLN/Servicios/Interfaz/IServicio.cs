using PedidosSLN.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosSLN.Servicios.Interfaz
{
    public interface IServicio
    {
        List<Cliente> GetListClientes(DateTime fDesde, DateTime fHasta);
        bool BajarEntregarPedido(int codigo, string bajaEntrega);
    }
}
