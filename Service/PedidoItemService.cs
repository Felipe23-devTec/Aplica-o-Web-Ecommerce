using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebbAppEcommerce.Repository.impl;
using WebbAppEcommerce.Service.impl;

namespace WebbAppEcommerce.Service
{
    public class PedidoItemService : IPedidoItemService
    {
        private readonly IPedidoItemRepository _pedidoItemRepository;

        public PedidoItemService(IPedidoItemRepository pedidoItemRepository)
        {
            _pedidoItemRepository = pedidoItemRepository;
        }
    }
}
