using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebFight.Models
{
    public class Contato
    {
        [Key]
        public Guid Id_Contato { get; set; }
        public long Telefone { get; set; }
        public long Celular { get; set; }
        public string Email { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Endereço { get; set; }
    }
}
