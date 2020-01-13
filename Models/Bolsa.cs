using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebFight.Models
{
    public class Bolsa
    {
        [Key]
        public Guid Id_Bolsa { get; set; }
        public int Percentual { get; set; }
        // Id do usuário
        public string OwnerID { get; set; }

        [Required]
        [Display(Name = "Início da Bolsa")]
        [DataType(DataType.Date)]
        public DateTime DataInicio { get; set; }

        [Display(Name = "Período")]
        [DataType(DataType.Duration)]
        public DateTime Periodo { get; set; }


        public BolsaStatus Status { get; set; }
    }

    public enum BolsaStatus
    {
        Enviado,
        Aprovado,
        Rejeitado
    }
}
