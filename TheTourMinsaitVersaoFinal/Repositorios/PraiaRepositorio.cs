using Microsoft.EntityFrameworkCore;
using TheTourMinsaitVersaoFinal.Data;
using TheTourMinsaitVersaoFinal.Models;
using TheTourMinsaitVersaoFinal.Repositorios.Interfaces;

namespace TheTourMinsaitVersaoFinal.Repositorios
{
    public class PraiaRepositorio : IPraiaRepositorio
    {


        private readonly Contexto _dbContext;


        public PraiaRepositorio(Contexto contexto)
        {
            _dbContext = contexto;
        }


        public async Task<Praia> BuscarPorId(Guid praiaId)
        {
            return await _dbContext.Praias.FirstOrDefaultAsync(x => x.PraiaId == praiaId);
        }


        public async Task<List<Praia>> BuscarTodasPraias()
        {
            return await _dbContext.Praias.ToListAsync();
        }


        public async Task<Praia> Adicionar(Praia praia)
        {
            await _dbContext.Praias.AddAsync(praia);
            await _dbContext.SaveChangesAsync();
            return praia;
        }


        public async Task<Praia> Atualizar(Praia praia, Guid praiaid)
        {
            Praia praiaPorId = await BuscarPorId(praiaid);
            if (praiaPorId == null)
            {
                throw new Exception($"A praia para o Id:{praiaid} não foi encontrado.");
            }

            praiaPorId.PraiaNome = praia.PraiaNome;
            praiaPorId.PraiaLocalidade = praia.PraiaLocalidade;
            praiaPorId.PraiaObservacoes = praia.PraiaObservacoes;

            _dbContext.Praias.Update(praiaPorId);
            await _dbContext.SaveChangesAsync();
            return praiaPorId;
        }


        public async Task<bool> Apagar(Guid praiaid)
        {
            Praia praiaPorId = await BuscarPorId(praiaid);
            if (praiaPorId == null)
            {
                throw new Exception($"A praia para o Id:{praiaid} não foi encontrado.");
            }
            _dbContext.Praias.Remove(praiaPorId);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
