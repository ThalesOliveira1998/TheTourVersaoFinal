using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TheTourMinsaitVersaoFinal.Models;

namespace TheTourMinsaitVersaoFinal.Data.Map
{
    public class PasseioMap : IEntityTypeConfiguration<Passeio>
    {
        public void Configure(EntityTypeBuilder<Passeio> builder)
        {
            builder.HasKey(x => x.PasseioId);
            builder.Property(x => x.PasseioNome);
            builder.Property(x => x.PasseioGuia);
            builder.Property(x => x.PasseioDescricao);
            builder.Property(x => x.QuantidadeDePessoas);
            builder.Property(x => x.ValorCobradoPasseio);
            builder.Property(x => x.GuiaFalaIngles);
        }
    }
}
