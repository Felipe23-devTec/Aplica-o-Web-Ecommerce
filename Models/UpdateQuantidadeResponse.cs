using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebbAppEcommerce.Entities;
using WebbAppEcommerce.Models.ViewModels;

namespace WebbAppEcommerce.Models
{
    public class UpdateQuantidadeResponse
    {
        public ItemPedido ItemPedido { get; }
        public CarrinhoViewModel CarrinhoViewModel { get; }

        public UpdateQuantidadeResponse(ItemPedido itemPedido,CarrinhoViewModel carrinhoViewModel)
        {
            ItemPedido = itemPedido;
            CarrinhoViewModel = carrinhoViewModel;
        }
    }
}
