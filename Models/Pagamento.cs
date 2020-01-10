using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebFight.Models
{
    public class Pagamento
    {
        [Key]
        public Guid Id_Pagamento { get; set; }
        [ForeignKey("BOLSA")]
        public int Bolsa_Id { get; set; }
        public float Valor { get; set; }
        public float MultaMora { get; set; }
        public float JurosMora { get; set; }

        [Display(Name = "Data de Vencimento")]
        [DataType(DataType.Date)]
        public DateTime DataVencimento { get; set; }

        [Display(Name = "Data de Pagamento")]
        [DataType(DataType.Date)]
        public DateTime DataPagamento { get; set; }
    }
}
