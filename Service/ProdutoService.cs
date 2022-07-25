using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebbAppEcommerce.Entities;
using WebbAppEcommerce.Repository.impl;
using WebbAppEcommerce.Service.impl;

namespace WebbAppEcommerce.Service
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
        public List<Produto> ListarProdutos()
        {
            return _produtoRepository.ListarProdutos();
        }
    }
}
