using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheTourMinsaitVersaoFinal.Models;

namespace TheTourMinsaitVersaoFinal.Data.Map
{
    public class RestauranteMap : IEntityTypeConfiguration<Restaurante>
    {
        public void Configure(EntityTypeBuilder<Restaurante> builder)
        {
            builder.HasKey(x => x.RestauranteId);
            builder.Property(x => x.RestauranteNome);
            builder.Property(x => x.RestauranteDescricao);
            builder.Property(x => x.RestauranteHorarioFuncionamento);
            builder.Property(x => x.RestauranteLocalizacao);
            builder.Property(x => x.RestauranteAvaliacaoMedia);
        }
    }
}

