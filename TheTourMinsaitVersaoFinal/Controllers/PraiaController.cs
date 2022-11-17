using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheTourMinsaitVersaoFinal.Models;
using TheTourMinsaitVersaoFinal.Repositorios;
using TheTourMinsaitVersaoFinal.Repositorios.Interfaces;

namespace TheTourMinsaitVersaoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PraiaController : ControllerBase
    {


        private readonly IPraiaRepositorio _praiaRepositorio;


        public PraiaController(IPraiaRepositorio praiaRepositorio)
        {
            _praiaRepositorio = praiaRepositorio;
        }


        [HttpGet]
        public async Task<ActionResult<List<Praia>>> BuscarTodasPraias()
        {
            List<Praia> praias = await _praiaRepositorio.BuscarTodasPraias();
            return Ok(praias);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Praia>> BuscarPorId(Guid praiaId)
        {
            Praia praia = await _praiaRepositorio.BuscarPorId(praiaId);
            return Ok(praia);
        }


        [HttpPost]
        public async Task<ActionResult<Praia>> Cadastrar([FromBody] Praia praia1)
        {
            Praia praia = await _praiaRepositorio.Adicionar(praia1);
            return Ok(praia);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<Praia>> Atualizar([FromBody] Praia praia1, Guid praiaId)
        {
            praia1.PraiaId = praiaId;
            Praia praia = await _praiaRepositorio.Atualizar(praia1, praiaId);
            return Ok(praia);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<Praia>> Apagar(Guid praiaId)
        {
            bool apagado = await _praiaRepositorio.Apagar(praiaId);
            return Ok(apagado);
        }
    }
}
