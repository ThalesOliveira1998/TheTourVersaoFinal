using Microsoft.EntityFrameworkCore;
using TheTourMinsaitVersaoFinal.Data;
using TheTourMinsaitVersaoFinal.Models;
using TheTourMinsaitVersaoFinal.Repositorios.Interfaces;

namespace TheTourMinsaitVersaoFinal.Repositorios
{
    public class VidaNoturnaRepositorio : IVidaNoturnaRepositorio
    {


        private readonly Contexto _dbContext;


        public VidaNoturnaRepositorio(Contexto contexto)
        {
            _dbContext = contexto;
        }


        public async Task<VidaNoturna> BuscarPorId(Guid vidanoturnaId)
        {
            return await _dbContext.VidaNoturnas.FirstOrDefaultAsync(x => x.VidaNoturnaId == vidanoturnaId);
        }


        public async Task<List<VidaNoturna>> BuscarTodaVidaNoturna()
        {
            return await _dbContext.VidaNoturnas.ToListAsync();
        }


        public async Task<VidaNoturna> Adicionar(VidaNoturna vidaNoturna)
        {
            await _dbContext.VidaNoturnas.AddAsync(vidaNoturna);
            await _dbContext.SaveChangesAsync();

            return vidaNoturna;
        }


        public async Task<VidaNoturna> Atualizar(VidaNoturna vidaNoturna, Guid vidanoturnaid)
        {
            VidaNoturna vidaNoturnaPorId = await BuscarPorId(vidanoturnaid);
            if (vidaNoturnaPorId == null)
            {
                throw new Exception($"O estabelecimento para o Id:{vidanoturnaid} não foi encontrado.");
            }

            vidaNoturnaPorId.VidaNoturnaNome = vidaNoturna.VidaNoturnaNome;
            vidaNoturnaPorId.VidaNoturnaTipoLocal = vidaNoturna.VidaNoturnaTipoLocal;
            vidaNoturnaPorId.VidaNoturnaHorarioFuncionamento = vidaNoturna.VidaNoturnaHorarioFuncionamento;
            vidaNoturnaPorId.VidaNoturnaValorDaEntrada = vidaNoturna.VidaNoturnaValorDaEntrada;
  
            _dbContext.VidaNoturnas.Update(vidaNoturnaPorId);
            await _dbContext.SaveChangesAsync();
            return vidaNoturnaPorId;
        }


        public async Task<bool> Apagar(Guid vidanoturnaid)
        {
            VidaNoturna vidaNoturnaPorId = await BuscarPorId(vidanoturnaid);
            if (vidaNoturnaPorId == null)
            {
                throw new Exception($"O estabelecimento para o Id:{vidanoturnaid} não foi encontrado.");
            }
            _dbContext.VidaNoturnas.Remove(vidaNoturnaPorId);
            await _dbContext.SaveChangesAsync();

            return true;
        }

    }
}
