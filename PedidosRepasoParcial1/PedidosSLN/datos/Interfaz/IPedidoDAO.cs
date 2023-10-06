using PedidosSLN.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosSLN.datos
{
    public interface IPedidoDAO
    {
        List<Cliente> GetListClientes(DateTime fDesde, DateTime fHasta);
        bool BajarEntregarPedido(int codigo, string bajaEntrega);
    }
}
