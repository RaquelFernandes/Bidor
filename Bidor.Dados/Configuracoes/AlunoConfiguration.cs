using Bidor.Dados.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bidor.Dados.Configuracoes
{
    public class AlunoConfiguration : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("Aluno");
            builder.HasKey(aluno => aluno.Id);

            builder.Property(aluno => aluno.Id)
                .UseIdentityColumn();

            builder.Property(aluno => aluno.Nome)
                .HasMaxLength(100);

            builder.Property(aluno => aluno.DataDeNascimento);
            builder.Property(aluno => aluno.DataDeRegistro);
        }
    }
}
