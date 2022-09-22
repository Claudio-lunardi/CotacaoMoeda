using CotacaoMoeda.Infra.Entity;
using CotacaoMoeda.Modelo;
using Microsoft.EntityFrameworkCore;

namespace CotacaoMoeda.Negocio.CotacaoNegocio
{
    public class CotacaoNegocio : ICotacaoNegocio
    {

        #region Construtores
        private readonly AppDbContext _context;

        public CotacaoNegocio(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        #endregion

        public async Task Incluir(Cotacao cotacao)
        {
            await _context.Cotacao.AddAsync(cotacao);
            await _context.SaveChangesAsync();
        }
        public async Task<List<Cotacao>> ObterLista()
        {
            return await _context.Cotacao.ToListAsync();
        }


    }
}
