using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebbAppEcommerce.Entities;
using WebbAppEcommerce.Repository.impl;
using WebEcommerce.Data;

namespace WebbAppEcommerce.Repository
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly BancoContext _context;
        private readonly IHttpContextAccessor _httpContext;

        public PedidoRepository(BancoContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContext = httpContextAccessor;

        }
        public int? GetPedidoId()
        {
            return _httpContext.HttpContext.Session.GetInt32("pedidoId");
        }

        public void SetPedidoId(int pedidoId)
        {
            _httpContext.HttpContext.Session.SetInt32("pedidoId", pedidoId);
        }
        public Pedido GetPedido()
        {
            var pedidoId = GetPedidoId();
            var pedido = _context.Pedido
                .Include(p => p.Itens)
                    .ThenInclude(i => i.Produto)
                .Where(p => p.IdPEdido == pedidoId)
                .SingleOrDefault();

            if(pedido == null)
            {
                pedido = new Pedido();
                _context.Add(pedido);
                _context.SaveChanges();
                SetPedidoId(pedido.IdPEdido);
            }
            return pedido;
        }
        public void AdicionarItem(string codigo)
        {
            var produto =_context.Produto.Where(p => p.CodigoProduto == codigo).SingleOrDefault();
            if(produto == null)
            {
                throw new ArgumentException("Produto não encontrado");
            }
            var pedido = GetPedido();
            var itemPedido = _context.ItemPedidos.Where(i => i.Produto.IdProduto == produto.IdProduto && i.Pedido.IdPEdido == pedido.IdPEdido).SingleOrDefault();

            if (itemPedido == null)
            {
                 var itemPedidoNovo = new ItemPedido();
                itemPedidoNovo.Pedido = pedido;
                itemPedidoNovo.PrecoUnitario = produto.Preco;
                itemPedidoNovo.Produto = produto;
                itemPedidoNovo.Quantidade = 1;
                _context.ItemPedidos.Add(itemPedidoNovo);
                _context.SaveChanges();
            }
            else
            {
                return;

            }
        }
    }
}
