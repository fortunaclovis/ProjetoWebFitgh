using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebFight.Models
{
    public class Aluno
    {
        [Key]
        public Guid Id_Professor { get; set; }

        [Required]
        [ForeignKey("Pessoa")]
        public int Pessoa_Id { get; set; }
        

        [ForeignKey("Graduacao")]
        public int Graduacao_Id { get; set; }
        public virtual ICollection<Graduacao> HistoricoGraduacao { get; set; }

        [Required]
        [ForeignKey("Academia")]
        public int Academia_Id { get; set; }
        
        [ForeignKey("Inscricao")]
        public int Inscricao_Id { get; set; }
        public virtual ICollection<Inscricao> ListaInscricao { get; set; }

    }
}
