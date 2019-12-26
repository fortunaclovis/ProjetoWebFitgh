using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebFight.Models
{
    
    public class Categoria
    {
        [Key]
        public Guid Id_Categoria { get; set; }

        [Required]
        public Idade Idade { get; set; }
        [Required]
        public Peso Peso { get; set; }
        [Required]
        public Faixas Faixa { get; set; }
        [Required]
        public Grau Grau { get; set; }
    }
}
