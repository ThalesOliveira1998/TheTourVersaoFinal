using TheTourMinsaitVersaoFinal.Models;

namespace TheTourMinsaitVersaoFinal.Repositorios.Interfaces
{
    public interface IPraiaRepositorio
    {
        Task<List<Praia>> BuscarTodasPraias();
        Task<Praia> BuscarPorId(Guid praiaId);
        Task<Praia> Adicionar(Praia praia);
        Task<Praia> Atualizar(Praia praia, Guid praiaid);
        Task<bool> Apagar(Guid id);
    }
}
