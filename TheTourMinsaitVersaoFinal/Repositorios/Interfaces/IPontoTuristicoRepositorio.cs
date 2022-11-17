using TheTourMinsaitVersaoFinal.Models;

namespace TheTourMinsaitVersaoFinal.Repositorios.Interfaces
{
    public interface IPontoTuristicoRepositorio
    {
        Task<List<PontoTuristico>> BuscarTodosPontosTuristicos();
        Task<PontoTuristico> BuscarPorId(Guid pontoTuristicoId);
        Task<PontoTuristico> Adicionar(PontoTuristico pontoTuristico);
        Task<PontoTuristico> Atualizar(PontoTuristico pontoTuristico, Guid pontoturisticoid);
        Task<bool> Apagar(Guid id);
    }
}
