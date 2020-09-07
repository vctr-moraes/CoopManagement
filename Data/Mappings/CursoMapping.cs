using CoopManagement.Models.Cursos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoopManagement.Data.Mappings
{
    public class CursoMapping : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(c => c.Grau)
                .IsRequired()
                .HasColumnType("varchar(100)");

            // 1 : N => Curso : Cooperado
            builder.HasMany(c => c.Cooperados)
                .WithOne(c => c.Curso)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("Cursos");
        }
    }
}
