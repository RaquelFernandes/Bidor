using Bidor.Dados.Configuracoes;
using Bidor.Dados.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bidor.Dados
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {
        }

        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Atividade> Atividade { get; set; }
        public DbSet<Materia> Materia { get; set; }
        public DbSet<TipoDeAtividade> TipoDeAtividade { get; set; }
        public DbSet<Turma> Turma { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoConfiguration());

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Contexto).Assembly);

        }
    }
}
