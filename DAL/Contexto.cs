﻿using WebFight.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WebFight.DAL
{
    public class Contexto : DbContext
    {
        public Contexto() : base("Contexto")
        {
            public DbSet<Academia> Academias { get; set; }
            public DbSet<Aluno> Alunos { get; set; }
            public DbSet<Aula> Aulas { get; set; }
            public DbSet<Bolsa> Bolsas { get; set; }
            public DbSet<Categoria> Categorias { get; set; }
            public DbSet<Contato> Contatos { get; set; }
            public DbSet<Graduacao> Graduacoes { get; set; }
            public DbSet<Inscricao> Inscricoes { get; set; }
            public DbSet<Lessiona> Lecionam { get; set; }
            public DbSet<Pagamento> Pagamentos { get; set; }
            public DbSet<Pessoa> Pessoas { get; set; }
            public DbSet<Professor> Professores { get; set; }
            public DbSet<Certificado> Certificados { get; set; }
            public DbSet<ImagemPessoa> AvatarFotos { get; set; }


        //metodo para não pluralizar as classes de view e controler com base nos nomes da model
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.using System.Data.Entity.ModelConfiguration.Conventions;
        }
    }
    }
}
