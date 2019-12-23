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
        [ForeignKey("CONTATO")]
        public int Contato_Id { get; set; }
        public string Nome { get; set; }
        [Display(Name = "Apelido")]
        public string NickName { get; set; }
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
        [Display(Name = "RG")]
        public long Rg { get; set; }
        [Display(Name = "CPF")]
        public long Cpf { get; set; }
        public float Peso { get; set; }
        public float Altura { get; set; }
        public bool Competidor { get; set; }
        public System.IO.MemoryStream Ft_Avatar { get; set; }
    }
}
