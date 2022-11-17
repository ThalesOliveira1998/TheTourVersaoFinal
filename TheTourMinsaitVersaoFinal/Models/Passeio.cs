using System.ComponentModel.DataAnnotations;

namespace TheTourMinsaitVersaoFinal.Models
{
    public class Passeio
    {
        [Key]
        public Guid PasseioId { get; set; }
        public string PasseioNome { get; set; }
        public string PasseioGuia { get; set; }
        public string PasseioDescricao { get; set; }
        public int QuantidadeDePessoas { get; set; }
        public double ValorCobradoPasseio { get; set; }
        public bool GuiaFalaIngles { get; set; }
    }
}
