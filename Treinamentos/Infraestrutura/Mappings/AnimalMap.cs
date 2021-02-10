using Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Infraestrutura.Mappings
{
    public class AnimalMap : EntityTypeConfiguration<Animal>
    {

        public AnimalMap()
        {
            ToTable("Animal");

            HasKey(a => a.IdAnimal);
            Property(a => a.Nome).HasMaxLength(100);
            Property(a => a.Raca).HasMaxLength(100);
        }

    }
}
