using System.ComponentModel.DataAnnotations;

namespace TheTourMinsaitVersaoFinal.Models
{
    public class VidaNoturna
    {
        [Key]
        public Guid VidaNoturnaId { get; set; }
        public string VidaNoturnaNome { get; set; }
        public string VidaNoturnaTipoLocal { get; set; }
        public double VidaNoturnaHorarioFuncionamento { get; set; }
        public double VidaNoturnaValorDaEntrada{ get; set; }
    }
}
