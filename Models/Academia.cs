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
        [DataType(DataType.Time)]
        public DateTime HorarioFunciona { get; set; }
        
        //UMA LISTA DE AULAS
        [ForeignKey("Aula")]
        public int Aula_Id { get; set; }
        public virtual ICollection<Aula> ListaAulas { get; set; }

        //LISTA DE CONTATOS
        [ForeignKey("Contato")]
        public int Contato_Id { get; set; }
        public virtual ICollection<Contato> ListaContatos { get; set; }
        
    }
}
