using Microsoft.EntityFrameworkCore;
using TheTourMinsaitVersaoFinal.Data;
using TheTourMinsaitVersaoFinal.Models;
using TheTourMinsaitVersaoFinal.Repositorios.Interfaces;

namespace TheTourMinsaitVersaoFinal.Repositorios
{
    public class PontoTuristicoRepositorio : IPontoTuristicoRepositorio
    {


        private readonly Contexto _dbContext;


        public PontoTuristicoRepositorio(Contexto contexto)
        {
            _dbContext = contexto;
        }


        public async Task<PontoTuristico> BuscarPorId(Guid pontoTuristicoId)
        {
            return await _dbContext.PontosTuristicos.FirstOrDefaultAsync(x => x.PontoTuristicoId == pontoTuristicoId);
        }


        public async Task<List<PontoTuristico>> BuscarTodosPontosTuristicos()
        {
            return await _dbContext.PontosTuristicos.ToListAsync();
        }


        public async Task<PontoTuristico> Adicionar(PontoTuristico pontoTuristico)
        {
            await _dbContext.PontosTuristicos.AddAsync(pontoTuristico);
            await _dbContext.SaveChangesAsync();
            return pontoTuristico;
        }


        public async Task<PontoTuristico> Atualizar(PontoTuristico pontoTuristico, Guid pontoTuristicoid)
        {
            PontoTuristico pontoTuristicoPorId = await BuscarPorId(pontoTuristicoid);
            if (pontoTuristicoPorId == null)
            {
                throw new Exception($"Ponto turistico para o Id:{pontoTuristicoid} não foi encontrado.");
            }

            pontoTuristicoPorId.PontoTuristicoNome = pontoTuristico.PontoTuristicoNome;
            pontoTuristicoPorId.PontoTuristicoHorarioDeFuncionamento = pontoTuristico.PontoTuristicoHorarioDeFuncionamento;
            pontoTuristicoPorId.PontoTuristicoObservacoes = pontoTuristico.PontoTuristicoObservacoes;
            pontoTuristicoPorId.CobrancaDeEntrada = pontoTuristico.CobrancaDeEntrada;
            pontoTuristicoPorId.PontoTuristicoLocalidade = pontoTuristico.PontoTuristicoLocalidade;
      

            _dbContext.PontosTuristicos.Update(pontoTuristicoPorId);
            await _dbContext.SaveChangesAsync();
            return pontoTuristicoPorId;
        }


        public async Task<bool> Apagar(Guid pontoTuristicoid)
        {
            PontoTuristico pontoTuristicoPorId = await BuscarPorId(pontoTuristicoid);
            if (pontoTuristicoPorId == null)
            {
                throw new Exception($"Ponto turistico para o Id:{pontoTuristicoid} não foi encontrado.");
            }
            _dbContext.PontosTuristicos.Remove(pontoTuristicoPorId);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
