using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebbAppEcommerce.Repository.impl;
using WebEcommerce.Data;

namespace WebbAppEcommerce.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly BancoContext _context;

        public ClienteRepository(BancoContext context)
        {
            _context = context;

        }
    }
}
