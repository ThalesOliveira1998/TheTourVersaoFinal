using System.ComponentModel.DataAnnotations;

namespace TheTourMinsaitVersaoFinal.Models
{
    public class Praia
    {
        [Key]
        public Guid PraiaId { get; set; }
        public string PraiaNome { get; set; }
        public string PraiaLocalidade { get; set; }
        public string PraiaObservacoes { get; set; }
    }
}
