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
        [ForeignKey("PESSOA")]
        public int Pessoa_Id { get; set; }
        //public virtual ICollection<Pessoa> pessoa { get; set; }
        [ForeignKey("GRADUACAO")]
        public int Graduacao_Id { get; set; }
        //public virtual ICollection<GRADUACAO> graduacao { get; set; }
        [ForeignKey("ACADEMIA")]
        public int Academia_Id { get; set; }
        //public virtual ICollection<ACADEMIA> academia { get; set; }
        [ForeignKey("INSCRICAO")]
        public int Inscricao_Id { get; set; }
        //public virtual ICollection<Inscricao> inscricao { get; set; }

    }
}
