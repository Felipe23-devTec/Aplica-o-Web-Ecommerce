using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebbAppEcommerce.Entities
{
    [Table("tb_Endereco")]
    public class Endereco
    {
        [Key]
        public int IdEndereco { get; set; }
        [Required]
        public string Cidade { get; set; } = "";
        [Required]
        public string Municipio { get; set; } = "";
        [Required]
        public string UF { get; set; } = "";
        [Required]
        public string Bairro { get; set; } = "";
        [Required]
        public string Cep { get; set; } = "";

    }

}
