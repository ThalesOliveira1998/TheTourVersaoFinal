using System.ComponentModel.DataAnnotations;

namespace TheTourMinsaitVersaoFinal.Models
{
    public class Bairro
    {
        [Key]
        public Guid BairroId { get; set; }
        public string? BairroNome { get; set; } 
        public string? Cidade { get; set; }
    }
}
