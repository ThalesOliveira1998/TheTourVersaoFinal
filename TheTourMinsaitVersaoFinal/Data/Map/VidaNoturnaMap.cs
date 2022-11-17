using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheTourMinsaitVersaoFinal.Models;

namespace TheTourMinsaitVersaoFinal.Data.Map
{
    public class VidaNoturnaMap : IEntityTypeConfiguration<VidaNoturna>
    {
        public void Configure(EntityTypeBuilder<VidaNoturna> builder)
        {
            builder.HasKey(x => x.VidaNoturnaId);
            builder.HasKey(x => x.VidaNoturnaNome);
            builder.HasKey(x => x.VidaNoturnaId);
            builder.HasKey(x => x.VidaNoturnaTipoLocal);
            builder.HasKey(x => x.VidaNoturnaId);
            builder.HasKey(x => x.VidaNoturnaHorarioFuncionamento);
            builder.HasKey(x => x.VidaNoturnaValorDaEntrada);
        }
    }
}
