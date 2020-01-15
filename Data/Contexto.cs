using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebFight.Models;

namespace WebFight.Data
{
    public class Contexto : DbContext
    {
        public Contexto (DbContextOptions<Contexto> options)
            : base(options)
        {
        }

        public DbSet<WebFight.Models.Academia> Academia { get; set; }

        public DbSet<WebFight.Models.Aluno> Aluno { get; set; }

        public DbSet<WebFight.Models.Aula> Aula { get; set; }

        public DbSet<WebFight.Models.Bolsa> Bolsa { get; set; }

        public DbSet<WebFight.Models.Categoria> Categoria { get; set; }

        public DbSet<WebFight.Models.Certificado> Certificado { get; set; }

        public DbSet<WebFight.Models.Contato> Contato { get; set; }

        public DbSet<WebFight.Models.Graduacao> Graduacao { get; set; }

        public DbSet<WebFight.Models.ImagemPessoa> ImagemPessoa { get; set; }

        public DbSet<WebFight.Models.Professor> Professor { get; set; }

        public DbSet<WebFight.Models.Pessoa> Pessoa { get; set; }

        public DbSet<WebFight.Models.Pagamento> Pagamento { get; set; }
    }
}
