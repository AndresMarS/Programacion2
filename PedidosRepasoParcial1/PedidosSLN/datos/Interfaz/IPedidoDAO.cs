using RecetasSLN.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.datos
{
    public interface IPedidoDAO
    {
        List<Cliente> GetListClientes();
        bool BajarEntregarPedido(int codigo, string bajaEntrega);
    }
}
