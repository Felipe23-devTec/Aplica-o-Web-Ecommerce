using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebbAppEcommerce.Entities;
using WebbAppEcommerce.Models;
using WebbAppEcommerce.Repository.impl;
using WebbAppEcommerce.Service.impl;

namespace WebbAppEcommerce.Service
{
    public class PedidoService : IPedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;

        public PedidoService(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }
        public Pedido GetPedido()
        {
            return _pedidoRepository.GetPedido();
        }
        public void AdicionarItem(string codigo)
        {
            _pedidoRepository.AdicionarItem(codigo);
        }
        public void UpdateQuantidade(ItemPedido itemPedido)
        {
            _pedidoRepository.UpdateQuantidade(itemPedido);
        }
    }
}
