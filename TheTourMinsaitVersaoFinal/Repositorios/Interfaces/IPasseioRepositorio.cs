using TheTourMinsaitVersaoFinal.Models;

namespace TheTourMinsaitVersaoFinal.Repositorios.Interfaces
{
    public interface IPasseioRepositorio
    {
        Task<List<Passeio>> BuscarTodosPasseios();
        Task<Passeio> BuscarPorId(Guid passeioid);
        Task<Passeio> Adicionar(Passeio passeio);
        Task<Passeio> Atualizar(Passeio passeio, Guid passeioid);
        Task<bool> Apagar(Guid id);
    }
}
