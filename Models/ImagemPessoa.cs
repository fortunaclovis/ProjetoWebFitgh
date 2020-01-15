using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebFight.Models
{
    public class ImagemPessoa
    {
        [Key]
        public Guid IdImagemPessoa { get; set; }
          [ForeignKey("Pessoa")]
        public int Pessoa_Id { get; set; }
        public byte[] Imagem { get; set; }
    }
}
}
