﻿using RecetasSLN.datos;
using RecetasSLN.dominio;
using RecetasSLN.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.Servicios.Implementacion
{
    public class Servicio : IServicio
    {
        IPedidoDAO dao;
        public Servicio()
        {
            dao = new PedidoDAO();
        }

        public bool BajarEntregarPedido(int codigo, string bajaEntrega)
        {
            return dao.BajarEntregarPedido(codigo, bajaEntrega);
        }

        public List<Cliente> GetListClientes()
        {
            return dao.GetListClientes();
        }
    }
}
