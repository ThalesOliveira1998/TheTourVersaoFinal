using System.ComponentModel.DataAnnotations;

namespace TheTourMinsaitVersaoFinal.Models
{
    public class Restaurante
    {
        [Key]
        public Guid RestauranteId { get; set; }
        public string RestauranteNome { get; set; }
        public string RestauranteDescricao { get; set; }
        public string RestauranteHorarioFuncionamento { get; set; }
        public string RestauranteLocalizacao { get; set; }
        public string RestauranteAvaliacaoMedia { get; set; }
    }
}
