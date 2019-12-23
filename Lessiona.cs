using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebFight.Models
{
    public class Lessiona
    {
        [Key]
        public Guid Id_Inscricao { get; set; }
        [ForeignKey("PROFESSOR")]
        public int Professor_id { get; set; }
        //public virtual ICollection<Professor> professor { get; set; }
        [ForeignKey("PROFESSOR")]
        public int Aula_id { get; set; }
        //public virtual ICollection<Aula> aula { get; set; }
    }
}
