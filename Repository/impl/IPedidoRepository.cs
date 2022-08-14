using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebbAppEcommerce.Entities;
using WebbAppEcommerce.Models;

namespace WebbAppEcommerce.Repository.impl
{
    public interface IPedidoRepository
    {
        public int? GetPedidoId();
        public void SetPedidoId(int pedidoId);
        public Pedido GetPedido();
        public void AdicionarItem(string codigo);
        public void UpdateQuantidade(ItemPedido itemPedido);
    }
}
