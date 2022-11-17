using Microsoft.EntityFrameworkCore;
using TheTourMinsaitVersaoFinal.Data;
using TheTourMinsaitVersaoFinal.Models;
using TheTourMinsaitVersaoFinal.Repositorios.Interfaces;

namespace TheTourMinsaitVersaoFinal.Repositorios
{
    public class PasseioRepositorio : IPasseioRepositorio
    {


        private readonly Contexto _dbContext;


        public PasseioRepositorio(Contexto contexto)
        {
            _dbContext = contexto;
        }


        public async Task<Passeio> BuscarPorId(Guid passeioid)
        {
            return await _dbContext.Passeios.FirstOrDefaultAsync(x => x.PasseioId == passeioid);
        }


        public async Task<List<Passeio>> BuscarTodosPasseios()
        {
            return await _dbContext.Passeios.ToListAsync();
        }


        public async Task<Passeio> Adicionar(Passeio passeio)
        {
            await _dbContext.Passeios.AddAsync(passeio);
            await _dbContext.SaveChangesAsync();
            return passeio;
        }


        public async Task<Passeio> Atualizar(Passeio passeio, Guid passeioid)
        {
            Passeio passeioPorId = await BuscarPorId(passeioid);
            if (passeioPorId == null)
            {
                throw new Exception($"Passeio para o Id:{passeioid} não foi encontrado.");
            }
            passeioPorId.PasseioNome = passeio.PasseioNome;
            passeioPorId.PasseioGuia = passeio.PasseioGuia;
            passeioPorId.PasseioDescricao = passeio.PasseioDescricao;
            passeioPorId.QuantidadeDePessoas = passeio.QuantidadeDePessoas;
            passeioPorId.ValorCobradoPasseio = passeio.ValorCobradoPasseio;
            passeioPorId.GuiaFalaIngles = passeio.GuiaFalaIngles;

            _dbContext.Passeios.Update(passeioPorId);
            await _dbContext.SaveChangesAsync();
            return passeioPorId;
        }


        public async Task<bool> Apagar(Guid passeioid)
        {
            Passeio passeioPorId = await BuscarPorId(passeioid);
            if (passeioPorId == null)
            {
                throw new Exception($"Passeio para o Id:{passeioid} não foi encontrado.");
            }
            _dbContext.Passeios.Remove(passeioPorId);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
