using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebbAppEcommerce.Entities;

namespace WebbAppEcommerce.Repository.impl
{
    public interface IProdutoRepository
    {
        public List<Produto> ListarProdutos();
    }
}
