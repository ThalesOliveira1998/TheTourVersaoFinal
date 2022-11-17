using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheTourMinsaitVersaoFinal.Models;
using TheTourMinsaitVersaoFinal.Repositorios;
using TheTourMinsaitVersaoFinal.Repositorios.Interfaces;

namespace TheTourMinsaitVersaoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestauranteController : ControllerBase
    {


        private readonly IRestauranteRepositorio _restauranteRepositorio;


        public RestauranteController(IRestauranteRepositorio restauranteRepositorio)
        {
            _restauranteRepositorio = restauranteRepositorio;
        }


        [HttpGet]
        public async Task<ActionResult<List<Restaurante>>> BuscarTodosRestaurantes()
        {
            List<Restaurante> restaurantes = await _restauranteRepositorio.BuscarTodosRestaurantes();
            return Ok(restaurantes);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Restaurante>> BuscarPorId(Guid restauranteId)
        {
            Restaurante restaurante = await _restauranteRepositorio.BuscarPorId(restauranteId);
            return Ok(restaurante);
        }


        [HttpPost]
        public async Task<ActionResult<Restaurante>> Cadastrar([FromBody] Restaurante restaurante1)
        {
            Restaurante restaurante = await _restauranteRepositorio.Adicionar(restaurante1);
            return Ok(restaurante);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<Restaurante>> Atualizar([FromBody] Restaurante restaurante1, Guid restauranteId)
        {
            restaurante1.RestauranteId = restauranteId;
            Restaurante restaurante = await _restauranteRepositorio.Atualizar(restaurante1, restauranteId);
            return Ok(restaurante);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<Restaurante>> Apagar(Guid restauranteId)
        {
            bool apagado = await _restauranteRepositorio.Apagar(restauranteId);
            return Ok(apagado);
        }
    }
}
