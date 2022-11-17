using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheTourMinsaitVersaoFinal.Models;
using TheTourMinsaitVersaoFinal.Repositorios.Interfaces;

namespace TheTourMinsaitVersaoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BairroController : ControllerBase
    {


        private readonly IBairroRepositorio _bairroRepositorio;


        public BairroController(IBairroRepositorio bairroRepositorio)
        {
            _bairroRepositorio = bairroRepositorio;
        }


        [HttpGet]
        public async Task<ActionResult<List<Bairro>>> BuscarTodosBairros()
        {
            List<Bairro> bairros = await _bairroRepositorio.BuscarTodosBairros();
            return Ok(bairros);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Bairro>> BuscarPorId(Guid bairroId)
        {
            Bairro bairro = await _bairroRepositorio.BuscarPorId(bairroId);
            return Ok(bairro);
        }


        [HttpPost]
        public async Task<ActionResult<Bairro>> Cadastrar([FromBody] Bairro bairro1)
        {
            Bairro bairro = await _bairroRepositorio.Adicionar(bairro1);

            return Ok(bairro);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<Bairro>> Atualizar([FromBody] Bairro bairro1, Guid bairroId)
        {
            bairro1.BairroId = bairroId;
            Bairro bairro = await _bairroRepositorio.Atualizar(bairro1, bairroId);
            return Ok(bairro);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<Bairro>> Apagar(Guid bairroId)
        {
           bool apagado = await _bairroRepositorio.Apagar(bairroId);
            return Ok(apagado);
        }
    }
}
