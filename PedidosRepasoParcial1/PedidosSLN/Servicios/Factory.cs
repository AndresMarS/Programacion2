﻿using PedidosSLN.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosSLN.Servicios
{
    public abstract class Factory
    {
        public abstract IServicio GetServicio();
    }
}
