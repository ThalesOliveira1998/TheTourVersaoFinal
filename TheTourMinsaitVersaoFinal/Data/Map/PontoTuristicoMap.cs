using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheTourMinsaitVersaoFinal.Models;

namespace TheTourMinsaitVersaoFinal.Data.Map
{
    public class PontoTuristicoMap : IEntityTypeConfiguration<PontoTuristico>
    {
        public void Configure(EntityTypeBuilder<PontoTuristico> builder)
        {
            builder.HasKey(x => x.PontoTuristicoId);
            builder.HasKey(x => x.PontoTuristicoNome);
            builder.HasKey(x => x.PontoTuristicoHorarioDeFuncionamento);
            builder.HasKey(x => x.PontoTuristicoObservacoes);
            builder.HasKey(x => x.CobrancaDeEntrada);
            builder.HasKey(x => x.PontoTuristicoLocalidade);
        }
    }
}
