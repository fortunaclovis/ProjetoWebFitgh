using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebFight.Models
{
    public class Graduacao
    {
        [Key]
        public Guid Id_Graduacao { get; set; }

        [Required]
        [ForeignKey("Categoria")]
        public int Categoria_Id { get; set; }
        // public virtual ICollection<Categoria> categoria { get; set; }

        [Required]
        [Display(Name = "Data de Graduação")]
        [DataType(DataType.Date)]
        public DateTime DataGraduacao { get; set; }

        [ForeignKey("Professor")]
        public int Professor_Id { get; set; }
    }
}
