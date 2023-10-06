using RecetasSLN.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.Servicios.Interfaz
{
    public interface IServicio
    {
        List<Cliente> GetListClientes();
        bool BajarEntregarPedido(int codigo, string bajaEntrega);
    }
}
