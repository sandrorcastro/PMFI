using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribSituacaoEdificacao
    {
        public TribSituacaoEdificacao()
        {
            TribEdificacos = new HashSet<TribEdificaco>();
        }

        public int SituacaoId { get; set; }
        public string? SituacaoNome { get; set; }
        public decimal? SituacaoFator { get; set; }
        public int? SituacaoPontos { get; set; }

        public virtual ICollection<TribEdificaco> TribEdificacos { get; set; }
    }
}
