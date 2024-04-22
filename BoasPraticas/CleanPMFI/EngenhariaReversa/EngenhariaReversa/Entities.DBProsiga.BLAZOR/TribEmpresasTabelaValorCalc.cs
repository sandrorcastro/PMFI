using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribEmpresasTabelaValorCalc
    {
        public long TabelaFaixaId { get; set; }
        public int? TabelaId { get; set; }
        public decimal? TabelaFaixaValorDe { get; set; }
        public decimal? TabelaFaixaValorAte { get; set; }
        public decimal? TabelaFaixaValor { get; set; }

        public virtual TribEmpresasTabela? Tabela { get; set; }
    }
}
