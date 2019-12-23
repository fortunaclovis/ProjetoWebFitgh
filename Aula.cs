using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebFight.Models
{
    public class Aula
    {
        [Key]
        public Guid Id_Aula { get; set; }      
        
        [Display(Name = "Início da Aula")]
        [DataType(DataType.Time)]
        public DateTime HorarioInicial { get; set; }

        [Display(Name = "Fim da Aula")]
        [DataType(DataType.Time)]
        public DateTime HorarioFinal { get; set; }

        public enum DiaDaAula
        {
            Domingo = 0,
            Segunda = 1,
            Terca = 2,
            Quarta = 3,
            Quinta = 4,
            Sexta = 5,
            Sabado = 6
        }
    }
}
