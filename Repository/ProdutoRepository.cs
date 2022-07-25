using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebbAppEcommerce.Entities;
using WebbAppEcommerce.Repository.impl;
using WebEcommerce.Data;


namespace WebbAppEcommerce.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly BancoContext _context;

        public ProdutoRepository(BancoContext context)
        {
            _context = context;

        }

        public List<Produto> ListarProdutos()
        {
            return _context.Produto.ToList();
        }
    }
}
