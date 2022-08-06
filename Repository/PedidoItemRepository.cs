using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebbAppEcommerce.Entities;
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

        public void AtualizarQuantidade(ItemPedido itemPedido)
        {
            var itemPedidoBanco = _context.ItemPedidos.Where(i => i.IdItemPedido == itemPedido.IdItemPedido).FirstOrDefault();
            if(itemPedidoBanco != null)
            {
                itemPedidoBanco.Quantidade = itemPedido.Quantidade;
                _context.SaveChanges();
            }

        }
    }
}
