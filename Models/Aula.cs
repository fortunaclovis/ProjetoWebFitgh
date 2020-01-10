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
            Domingo,
            [Display(Name = "Segunda-Feira")]
            Segunda,
            [Display(Name = "Terça-Feira")]
            Terca,
            [Display(Name = "Quarta-Feira")]
            Quarta,
            [Display(Name = "Quinta-Feira")]
            Quinta,
            [Display(Name = "Sexta-Feira")]
            Sexta,
            [Display(Name = "Sábado")]
            Sabado
        }
    }
}
