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
    public class PedidoItemService : IPedidoItemService
    {
        private readonly IPedidoItemRepository _pedidoItemRepository;

        private readonly IPedidoRepository _pedidoRepository;

        public PedidoItemService(IPedidoItemRepository pedidoItemRepository, IPedidoRepository pedidoRepository)
        {
            _pedidoItemRepository = pedidoItemRepository;
            _pedidoRepository = pedidoRepository;
        }
        /*void IPedidoItemService.AtualizarQuantidade(ItemPedido itemPedido)
        {
            _pedidoItemRepository.AtualizarQuantidade(itemPedido);
        }*/
    }
}
