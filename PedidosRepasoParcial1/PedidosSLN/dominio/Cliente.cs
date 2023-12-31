﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosSLN.dominio
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public int CodigoPostal { get; set; }
        public List<Pedido> Pedidos { get; set; }

        public string NombreCompleto { get { return Apellido + ", " + Nombre; } }

        public Cliente()
        {
            Pedidos = new List<Pedido>();
        }

        public void AgregarPedido(Pedido oPedido)
        {
            if (oPedido != null)
                Pedidos.Add(oPedido);
        }

        public void QuitarPedido(Pedido oPedido)
        {
            if (oPedido != null)
                Pedidos.Remove(oPedido);
        }
        public override string ToString()
        {
            return Apellido + " ," + Nombre;
        }
    }
}
