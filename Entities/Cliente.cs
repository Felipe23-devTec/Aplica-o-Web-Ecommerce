using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebbAppEcommerce.Entities
{
    [Table("tb_Cliente")]
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        [Required]
        public string Nome { get; set; } = "";
        [Required]
        public string Email { get; set; } = "";
        [Required]
        public string Telefone { get; set; } = "";
        [Required]
        public Endereco Endereco { get; set; } 


    }
}
