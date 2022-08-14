using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebbAppEcommerce.Entities;
namespace WebbAppEcommerce.Models.ViewModels
{
    public class CarrinhoViewModel
    {
        public List<ItemPedido> Itens { get;}
        public decimal Total => Itens.Sum(i => i.Quantidade * i.PrecoUnitario);
        public int Quantidade => Itens.Count();


        public CarrinhoViewModel(List<ItemPedido> itemPedidos)
        {
            Itens = itemPedidos;
        }
    }

}
