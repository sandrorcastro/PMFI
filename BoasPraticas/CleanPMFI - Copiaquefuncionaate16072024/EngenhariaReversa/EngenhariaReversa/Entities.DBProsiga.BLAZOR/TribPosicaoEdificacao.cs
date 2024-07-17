using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribPosicaoEdificacao
    {
        public TribPosicaoEdificacao()
        {
            TribEdificacos = new HashSet<TribEdificaco>();
        }

        public int PosicaoId { get; set; }
        public string? PosicaoNome { get; set; }
        public decimal? PosicaoFator { get; set; }
        public int? PosicaoPontos { get; set; }

        public virtual ICollection<TribEdificaco> TribEdificacos { get; set; }
    }
}
