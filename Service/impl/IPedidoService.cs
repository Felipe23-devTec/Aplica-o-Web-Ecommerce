using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebbAppEcommerce.Entities;

namespace WebbAppEcommerce.Service.impl
{
    public interface IPedidoService
    {
        public Pedido GetPedido();
        public void AdicionarItem(string codigo);
    }
}
