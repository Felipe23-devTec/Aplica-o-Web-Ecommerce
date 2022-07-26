using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebbAppEcommerce.Repository.impl;
using WebEcommerce.Data;

namespace WebbAppEcommerce.Repository
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly BancoContext _context;

        public PedidoRepository(BancoContext context)
        {
            _context = context;

        }
    }
}
