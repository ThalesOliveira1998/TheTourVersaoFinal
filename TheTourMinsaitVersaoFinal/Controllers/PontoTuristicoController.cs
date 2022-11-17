using Microsoft.AspNetCore.Mvc;
using TheTourMinsaitVersaoFinal.Models;
using TheTourMinsaitVersaoFinal.Repositorios;
using TheTourMinsaitVersaoFinal.Repositorios.Interfaces;

namespace TheTourMinsaitVersaoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PontoTuristicoController : ControllerBase
    {


        private readonly IPontoTuristicoRepositorio _pontoTuristicoRepositorio;


        public PontoTuristicoController(IPontoTuristicoRepositorio pontoTuristicoRepositorio)
        {
            _pontoTuristicoRepositorio = pontoTuristicoRepositorio;
        }


        [HttpGet]
        public async Task<ActionResult<List<PontoTuristico>>> BuscarTodosPontosTuristicos()
        {
            List<PontoTuristico> pontosTuristicos = await _pontoTuristicoRepositorio.BuscarTodosPontosTuristicos();
            return Ok(pontosTuristicos);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<PontoTuristico>> BuscarPorId(Guid pontoTuristicoId)
        {
            PontoTuristico pontoTuristico = await _pontoTuristicoRepositorio.BuscarPorId(pontoTuristicoId);
            return Ok(pontoTuristico);
        }


        [HttpPost]
        public async Task<ActionResult<PontoTuristico>> Cadastrar([FromBody] PontoTuristico pontoTuristico1)
        {
            PontoTuristico pontoTuristico = await _pontoTuristicoRepositorio.Adicionar(pontoTuristico1);
            return Ok(pontoTuristico);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<PontoTuristico>> Atualizar([FromBody] PontoTuristico pontoTuristico1, Guid pontoTuristicoId)
        {
            pontoTuristico1.PontoTuristicoId = pontoTuristicoId;
            PontoTuristico passeio = await _pontoTuristicoRepositorio.Atualizar(pontoTuristico1, pontoTuristicoId);
            return Ok(passeio);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<PontoTuristico>> Apagar(Guid pontoTuristicoId)
        {
            bool apagado = await _pontoTuristicoRepositorio.Apagar(pontoTuristicoId);
            return Ok(apagado);
        }
    }
}
