using TheTourMinsaitVersaoFinal.Models;

namespace TheTourMinsaitVersaoFinal.Repositorios.Interfaces
{
    public interface IVidaNoturnaRepositorio
    {
        Task<List<VidaNoturna>> BuscarTodaVidaNoturna();
        Task<VidaNoturna> BuscarPorId(Guid vidaNoturnaId);
        Task<VidaNoturna> Adicionar(VidaNoturna vidaNoturna);
        Task<VidaNoturna> Atualizar(VidaNoturna vidaNoturna, Guid vidanoturnaid);
        Task<bool> Apagar(Guid id);
    }
}
