using CotacaoMoeda.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotacaoMoeda.Negocio.CotacaoNegocio
{
    public interface ICotacaoNegocio
    {
        Task Incluir(Cotacao cotacao);
        Task<List<Cotacao>> ObterLista();

    }
}
