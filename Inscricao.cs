using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebFight.Models
{
    public class Inscricao
    {
        [Key]
        public Guid Id_Inscricao { get; set; }
        [ForeignKey("ALUNO")]
        public int Aluno_id { get; set; }
        //public virtual ICollection<Aluno> aluno { get; set; }
        [ForeignKey("PROFESSOR")]
        public int Aula_id { get; set; }
        //public virtual ICollection<Aula> aula { get; set; }
    }
}
