using TheTourMinsaitVersaoFinal.Models;

namespace TheTourMinsaitVersaoFinal.Repositorios.Interfaces
{
    public interface IBairroRepositorio
    {
        Task<List<Bairro>> BuscarTodosBairros();
        Task<Bairro> BuscarPorId(Guid bairroId);
        Task<Bairro> Adicionar(Bairro bairro);
        Task<Bairro> Atualizar(Bairro bairro, Guid bairroid);
        Task<bool> Apagar(Guid id);
    }
}
