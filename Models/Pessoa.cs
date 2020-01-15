using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace WebFight.Models
{
    public class Pessoa
    {
        [Key]
        public Guid Id_Pessoa { get; set; }

        [ForeignKey("Contato")]
        public int Contato_Id { get; set; }
        public virtual ICollection<Contato> ListaContatos { get; set; }

        [Required]
        public string Nome { get; set; }
        [Required]
        public string Sexo { get; set; }
        public string Sexualidade { get; set; }
        [Display(Name = "Apelido")]
        public string NickName { get; set; }
        [Required]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
        [Display(Name = "RG")]
        public long Rg { get; set; }
        [Display(Name = "CPF")]
        public long Cpf { get; set; }
        public float Peso { get; set; }
        public float Altura { get; set; }
        [Required]
        public bool Competidor { get; set; }
        public virtual ImagemPessoa Avatar { get; set; }
    }
}
