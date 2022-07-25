using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebbAppEcommerce.Repository.impl;
using WebbAppEcommerce.Service.impl;

namespace WebEcommerce.Controllers
{
    public class PedidosController : Controller
    {
        private readonly IProdutoService _produtoService;

        public PedidosController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }
        public IActionResult Carrossel()
        {
            var listaprodutos = _produtoService.ListarProdutos();
            return View(listaprodutos);
        }

        public IActionResult Resumo()
        {
            return View();
        }
        public IActionResult Cadastro()
        {
            return View();
        }
        public IActionResult Carrinho()
        {
            return View();
        }
    }
}
