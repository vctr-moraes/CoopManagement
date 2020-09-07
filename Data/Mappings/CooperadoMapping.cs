using CoopManagement.Models.Cooperados;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoopManagement.Data.Mappings
{
    public class CooperadoMapping : IEntityTypeConfiguration<Cooperado>
    {
        public void Configure(EntityTypeBuilder<Cooperado> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(c => c.Sexo)
                .IsRequired();

            builder.Property(c => c.EstadoCivil)
                .IsRequired();

            builder.Property(c => c.DataNascimento)
                .IsRequired()
                .HasColumnType("date");

            builder.Property(c => c.RacaCor)
                .IsRequired();

            builder.Property(c => c.NecessidadeEspecial)
                .IsRequired();

            builder.Property(c => c.Cpf)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.Property(c => c.Rg)
                .HasColumnType("varchar(20)");

            builder.Property(c => c.OrgaoExpedidorRg)
                .HasColumnType("varchar(20)");

            builder.Property(c => c.DataExpedicaoRg)
                .HasColumnType("date");

            builder.Property(c => c.Naturalidade)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(c => c.Nacionalidade)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(c => c.NomePai)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(c => c.NomeMae)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(c => c.RendaFamiliar)
                .HasColumnType("varchar(20)");

            builder.Property(c => c.Matricula)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.Property(c => c.Turma)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.Property(c => c.Escolaridade)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(c => c.Logradouro)
                .IsRequired()
                .HasColumnType("varchar(150)");

            builder.Property(m => m.Bairro)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(m => m.Cidade)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(c => c.Cep)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.Property(m => m.Estado)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(m => m.TelefoneResidencial)
                .HasColumnType("varchar(20)");

            builder.Property(m => m.TelefoneCelular)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.Property(m => m.Email)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(m => m.DataMatricula)
                .IsRequired()
                .HasColumnType("date");

            builder.Property(m => m.DataDesligamento)
                .HasColumnType("date");

            builder.Property(m => m.CotaParte)
                .HasColumnType("decimal(18,2)");

            // 1 : 1 => Cooperado : Curso
            builder.HasOne(c => c.Curso)
                .WithMany(c => c.Cooperados)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("Cooperados");
        }
    }
}
