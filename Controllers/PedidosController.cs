using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebbAppEcommerce.Entities;
using WebbAppEcommerce.Repository.impl;
using WebbAppEcommerce.Service.impl;
using WebbAppEcommerce.Models.ViewModels;
using WebbAppEcommerce.Models;

namespace WebEcommerce.Controllers
{
    public class PedidosController : Controller
    {
        private readonly IProdutoService _produtoService;
        private readonly IPedidoService _pedidoService;
        private readonly IPedidoItemService _pedidoItemService;
        public PedidosController(IProdutoService produtoService, IPedidoService pedidoService, IPedidoItemService pedidoItemService)
        {
            _produtoService = produtoService;
            _pedidoService = pedidoService;
            _pedidoItemService = pedidoItemService;
        }
        public IActionResult Carrossel()
        {
            var listaprodutos = _produtoService.ListarProdutos();
            return View(listaprodutos);
        }

        public IActionResult Resumo()
        {
            var pedido = _pedidoService.GetPedido();
            return View(pedido);
        }
        public IActionResult Cadastro()
        {
            return View();
        }
        public IActionResult Carrinho(string codigo)
        {
            if (!string.IsNullOrEmpty(codigo))
            {
                _pedidoService.AdicionarItem(codigo);
            }
            var listaItensPedidos = _pedidoService.GetPedido();
            var itens = listaItensPedidos.Itens;
            CarrinhoViewModel carrinhoViewModel = new CarrinhoViewModel(itens);
            return View(carrinhoViewModel);
        }
        [HttpPost]
        public void UpdateQuantidade([FromBody] ItemPedido itemPedido)
        {
           _pedidoService.UpdateQuantidade(itemPedido);
        }
    } 
}
