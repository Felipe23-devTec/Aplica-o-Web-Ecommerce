using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebbAppEcommerce.Entities
{
    [Table("tb_ItemPedido")]
    public class ItemPedido
    {
        [Key]
        public int IdItemPedido { get; set; }
        public decimal PrecoUnitario { get; set; }
        public int Quantidade { get; set; }
        public Pedido Pedido { get;  set; }
        public Produto Produto { get;  set; }
    }
}
