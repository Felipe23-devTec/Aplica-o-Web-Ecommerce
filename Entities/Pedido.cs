using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebbAppEcommerce.Entities
{
    [Table("tb_Pedido")]
    public class Pedido
    {
 
        [Key]
        public int IdPEdido { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual ItemPedido ItemPedido { get; set; }
    }
}
