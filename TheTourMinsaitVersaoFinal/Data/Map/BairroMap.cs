using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheTourMinsaitVersaoFinal.Models;

namespace TheTourMinsaitVersaoFinal.Data.Map
{
    public class BairroMap : IEntityTypeConfiguration<Bairro>
    {
        public void Configure(EntityTypeBuilder<Bairro> builder)
        {
            builder.HasKey(x => x.BairroId);
            builder.Property(x => x.BairroNome);
            builder.Property(x => x.Cidade);
        }
    }
}
