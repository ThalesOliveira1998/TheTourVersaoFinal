using System.ComponentModel.DataAnnotations;

namespace TheTourMinsaitVersaoFinal.Models
{
    public class PontoTuristico
    {
        [Key]
        public Guid PontoTuristicoId { get; set; }
        public string PontoTuristicoNome { get; set; }
        public string PontoTuristicoHorarioDeFuncionamento { get; set; }
        public string PontoTuristicoObservacoes { get; set; }
        public bool CobrancaDeEntrada { get; set; }
        public string PontoTuristicoLocalidade { get; set; }
    }
}
