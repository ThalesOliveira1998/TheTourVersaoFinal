using Microsoft.EntityFrameworkCore;
using TheTourMinsaitVersaoFinal.Data.Map;
using TheTourMinsaitVersaoFinal.Models;

namespace TheTourMinsaitVersaoFinal.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        { }

        public DbSet<Bairro> Bairros { get; set; }
        public DbSet<Passeio> Passeios { get; set; }
        public DbSet<Praia> Praias { get; set; }
        public DbSet<PontoTuristico> PontosTuristicos { get; set; }
        public DbSet<Restaurante> Restaurantes { get; set; }
        public DbSet<VidaNoturna> VidaNoturnas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BairroMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
