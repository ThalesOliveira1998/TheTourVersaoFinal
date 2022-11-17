using TheTourMinsaitVersaoFinal.Models;

namespace TheTourMinsaitVersaoFinal.Repositorios.Interfaces
{
    public interface IRestauranteRepositorio
    {
        Task<List<Restaurante>> BuscarTodosRestaurantes();
        Task<Restaurante> BuscarPorId(Guid restauranteId);
        Task<Restaurante> Adicionar(Restaurante restaurante);
        Task<Restaurante> Atualizar(Restaurante restaurante, Guid restauranteid);
        Task<bool> Apagar(Guid id);
    }
}
