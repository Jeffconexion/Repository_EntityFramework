using Dominio.Entidades;
using Infraestrutura.Mappings;
using System.Data.Entity;

namespace Infraestrutura.Contextos
{
    public class AppDataContext : DbContext
    {
        public AppDataContext() : base("appAnimal")
        {

        }

        public DbSet<Animal> Animais { set; get; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AnimalMap());
        }
    }


}
