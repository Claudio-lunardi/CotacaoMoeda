using CotacaoMoeda.Modelo;
using CotacaoMoeda.Negocio.CotacaoNegocio;
using Microsoft.AspNetCore.Mvc;

namespace CotacaoMoeda.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CotacaoController : ControllerBase
    {

        #region Construtores
        private readonly ICotacaoNegocio _CotacaoNegocio;

        public CotacaoController(ICotacaoNegocio context)
        {
            _CotacaoNegocio = context;
        }
        #endregion

        [HttpPost]
        public async Task Incluir([FromBody] Cotacao cotacao)
        {
            cotacao.DataHoraCotacao = DateTime.Now;

            if (ModelState.IsValid)
            {
                await _CotacaoNegocio.Incluir(cotacao);
            }
        }

        //[HttpGet]
        //public async Task<List<Cotacao>> Get()
        //{
        //    return await _CotacaoNegocio.ObterLista();
        //}

        [HttpGet]
        public async Task<List<Cotacao>> Get() => await _CotacaoNegocio.ObterLista();


    }
}