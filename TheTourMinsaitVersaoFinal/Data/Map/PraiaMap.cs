using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TheTourMinsaitVersaoFinal.Models;

namespace TheTourMinsaitVersaoFinal.Data.Map
{
    public class PraiaMap : IEntityTypeConfiguration<Praia>
    {
        public void Configure(EntityTypeBuilder<Praia> builder)
        {
            builder.HasKey(x => x.PraiaId);
            builder.Property(x => x.PraiaNome);
            builder.Property(x => x.PraiaLocalidade);
            builder.Property(x => x.PraiaLocalidade);
            builder.Property(x => x.PraiaObservacoes);
        }
    }

}
