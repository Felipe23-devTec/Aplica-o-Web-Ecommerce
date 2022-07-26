using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebbAppEcommerce.Repository.impl;
using WebEcommerce.Data;

namespace WebbAppEcommerce.Repository
{
    public class PedidoItemRepository : IPedidoItemRepository
    {
        private readonly BancoContext _context;

        public PedidoItemRepository(BancoContext context)
        {
            _context = context;

        }
    }
}
