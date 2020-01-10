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

        [DataType(DataType.PhoneNumber)]
        public long Telefone { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public long Celular { get; set; }

        [DataType(DataType.Url)]
        public string Facebook { get; set; }

        [DataType(DataType.Url)]
        public string Instagram { get; set; }

        [Required]
        public string Endereço { get; set; }
        public string Complemtento { get; set; }
        [Required]
        public string Cidade { get; set; }
        [Required]
        public string Estado { get; set; }
        [DataType(DataType.PostalCode)]
        public string CEP { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
