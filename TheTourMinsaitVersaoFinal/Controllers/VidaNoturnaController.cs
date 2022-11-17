using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheTourMinsaitVersaoFinal.Models;
using TheTourMinsaitVersaoFinal.Repositorios;
using TheTourMinsaitVersaoFinal.Repositorios.Interfaces;

namespace TheTourMinsaitVersaoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VidaNoturnaController : ControllerBase
    {


        private readonly IVidaNoturnaRepositorio _vidaNoturnaRepositorio;


        public VidaNoturnaController(IVidaNoturnaRepositorio vidaNoturnaRepositorio)
        {
            _vidaNoturnaRepositorio = vidaNoturnaRepositorio;
        }


        [HttpGet]
        public async Task<ActionResult<List<VidaNoturna>>> BuscarTodaVidaNoturna()
        {
            List<VidaNoturna> vidaNoturnas = await _vidaNoturnaRepositorio.BuscarTodaVidaNoturna();
            return Ok(vidaNoturnas);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<VidaNoturna>> BuscarPorId(Guid vidaNoturnaId)
        {
            VidaNoturna vidaNoturna = await _vidaNoturnaRepositorio.BuscarPorId(vidaNoturnaId);
            return Ok(vidaNoturna);
        }


        [HttpPost]
        public async Task<ActionResult<VidaNoturna>> Cadastrar([FromBody] VidaNoturna vidaNoturna1)
        {
            VidaNoturna vidaNoturna = await _vidaNoturnaRepositorio.Adicionar(vidaNoturna1);

            return Ok(vidaNoturna);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<VidaNoturna>> Atualizar([FromBody] VidaNoturna vidaNoturna1, Guid vidaNoturnaId)
        {
            vidaNoturna1.VidaNoturnaId = vidaNoturnaId;
            VidaNoturna bairro = await _vidaNoturnaRepositorio.Atualizar(vidaNoturna1, vidaNoturnaId);
            return Ok(bairro);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<VidaNoturna>> Apagar(Guid vidaNoturnaId)
        {
            bool apagado = await _vidaNoturnaRepositorio.Apagar(vidaNoturnaId);
            return Ok(apagado);
        }
    }
}
