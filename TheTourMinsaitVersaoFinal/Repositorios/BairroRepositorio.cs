using Microsoft.EntityFrameworkCore;
using TheTourMinsaitVersaoFinal.Data;
using TheTourMinsaitVersaoFinal.Models;
using TheTourMinsaitVersaoFinal.Repositorios.Interfaces;

namespace TheTourMinsaitVersaoFinal.Repositorios
{
    public class BairroRepositorio : IBairroRepositorio
    {


        private readonly Contexto _dbContext;


        public BairroRepositorio(Contexto contexto)
        {
            _dbContext = contexto;
        }


        public async Task<Bairro> BuscarPorId(Guid bairroId)
        {
            return await _dbContext.Bairros.FirstOrDefaultAsync(x => x.BairroId == bairroId);
        }


        public async Task<List<Bairro>> BuscarTodosBairros()
        {
            return await _dbContext.Bairros.ToListAsync();
        }


        public async Task<Bairro> Adicionar(Bairro bairro)
        {
         await   _dbContext.Bairros.AddAsync(bairro);
         await  _dbContext.SaveChangesAsync();
            return bairro;
        }


        public async Task<Bairro> Atualizar(Bairro bairro, Guid bairroid)
        {
            Bairro bairroPorId = await BuscarPorId(bairroid);
            if (bairroPorId == null)
            {
                throw new Exception($"Bairro para o Id:{bairroid} não foi encontrado.");
            }
            bairroPorId.BairroNome = bairro.BairroNome;
            bairroPorId.Cidade = bairro.Cidade;

            _dbContext.Bairros.Update(bairroPorId);
           await _dbContext.SaveChangesAsync();
            return bairroPorId;
        }


        public async Task<bool> Apagar(Guid bairroid)
        {
            Bairro bairroPorId = await BuscarPorId(bairroid);
            if (bairroPorId == null)
            {
                throw new Exception($"Bairro para o Id:{bairroid} não foi encontrado.");
            }
            _dbContext.Bairros.Remove(bairroPorId);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
