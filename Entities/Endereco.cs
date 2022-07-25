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
        public string Cidade { get; set; }
        public string Municipio { get; set; }
        public string UF { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
    
    }

}
