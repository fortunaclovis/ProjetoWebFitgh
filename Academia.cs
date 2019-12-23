using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebFight.Models
{
    public class Academia
    {
        [Key]
        public Guid Id_Academia { get; set; }
        public string Nome { get; set; }
        [Display(Name = "Data de Inauguração")]
        [DataType(DataType.Date)]
        public DateTime DataInicio { get; set; }
        [Display(Name = "Horário de Funcionamento")]
        public string HorarioFunciona { get; set; }
        
        //UMA LISTA DE AULAS
        [ForeignKey("AULA")]
        public int Aula_Id { get; set; }
        //LinkedList<Aula> sentence = new LinkedList<Aula>(Aula_Id);

        [ForeignKey("CONTATO")]
        public int Contato_Id { get; set; }
        
    }
}
