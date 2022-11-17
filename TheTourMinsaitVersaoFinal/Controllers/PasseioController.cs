using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheTourMinsaitVersaoFinal.Models;
using TheTourMinsaitVersaoFinal.Repositorios;
using TheTourMinsaitVersaoFinal.Repositorios.Interfaces;

namespace TheTourMinsaitVersaoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PasseioController : ControllerBase
    {


        private readonly IPasseioRepositorio _passeioRepositorio;


        public PasseioController(IPasseioRepositorio passeioRepositorio)
        {
            _passeioRepositorio = passeioRepositorio;
        }


        [HttpGet]
        public async Task<ActionResult<List<Passeio>>> BuscarTodosPasseios()
        {
            List<Passeio> passeios = await _passeioRepositorio.BuscarTodosPasseios();
            return Ok(passeios);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Passeio>> BuscarPorId(Guid passeioId)
        {
            Passeio passeio = await _passeioRepositorio.BuscarPorId(passeioId);
            return Ok(passeio);
        }


        [HttpPost]
        public async Task<ActionResult<Passeio>> Cadastrar([FromBody] Passeio passeio1)
        {
            Passeio passeio = await _passeioRepositorio.Adicionar(passeio1);
            return Ok(passeio);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<Passeio>> Atualizar([FromBody] Passeio passeio1, Guid passeioId)
        {
            passeio1.PasseioId = passeioId;
            Passeio passeio = await _passeioRepositorio.Atualizar(passeio1, passeioId);
            return Ok(passeio);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<Passeio>> Apagar(Guid passeioId)
        {
            bool apagado = await _passeioRepositorio.Apagar(passeioId);
            return Ok(apagado);
        }
    }
}
