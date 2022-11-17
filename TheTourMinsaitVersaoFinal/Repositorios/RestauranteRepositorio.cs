using Microsoft.EntityFrameworkCore;
using TheTourMinsaitVersaoFinal.Data;
using TheTourMinsaitVersaoFinal.Models;
using TheTourMinsaitVersaoFinal.Repositorios.Interfaces;

namespace TheTourMinsaitVersaoFinal.Repositorios
{
    public class RestauranteRepositorio :IRestauranteRepositorio
    {


        private readonly Contexto _dbContext;


        public RestauranteRepositorio(Contexto contexto)
        {
            _dbContext = contexto;
        }


        public async Task<Restaurante> BuscarPorId(Guid restauranteId)
        {
            return await _dbContext.Restaurantes.FirstOrDefaultAsync(x => x.RestauranteId == restauranteId);
        }


        public async Task<List<Restaurante>> BuscarTodosRestaurantes()
        {
            return await _dbContext.Restaurantes.ToListAsync();
        }


        public async Task<Restaurante> Adicionar(Restaurante restaurante)
        {
            await _dbContext.Restaurantes.AddAsync(restaurante);
            await _dbContext.SaveChangesAsync();
            return restaurante;
        }


        public async Task<Restaurante> Atualizar(Restaurante restaurante, Guid restauranteid)
        {
            Restaurante restaurantePorId = await BuscarPorId(restauranteid);
            if (restaurantePorId == null)
            {
                throw new Exception($"O restaurante para o Id:{restauranteid} não foi encontrado.");
            }

            restaurantePorId.RestauranteNome = restaurante.RestauranteNome;
            restaurantePorId.RestauranteDescricao = restaurante.RestauranteDescricao;
            restaurantePorId.RestauranteHorarioFuncionamento = restaurante.RestauranteDescricao;
            restaurantePorId.RestauranteLocalizacao = restaurante.RestauranteLocalizacao;
            restaurantePorId.RestauranteAvaliacaoMedia = restaurante.RestauranteAvaliacaoMedia;
    
            _dbContext.Restaurantes.Update(restaurantePorId);
            await _dbContext.SaveChangesAsync();
            return restaurantePorId;
        }


        public async Task<bool> Apagar(Guid restauranteid)
        {
            Restaurante restaurantePorId = await BuscarPorId(restauranteid);
            if (restaurantePorId == null)
            {
                throw new Exception($"O restaurante para o Id:{restauranteid} não foi encontrado.");
            }
            _dbContext.Restaurantes.Remove(restaurantePorId);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
