using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribBaixaDevolucaoDividasComp
    {
        public long DeDiId { get; set; }
        public int TipoTribId { get; set; }
        public decimal? DeCoValor { get; set; }
        public decimal? DeCoValorAcrescimo { get; set; }
        public string? CdReceita { get; set; }
        public decimal? DeCoValorCompensado { get; set; }
        public short? IdTipoOperacaoReceita { get; set; }

        public virtual TribBaixaDevolucaoDivida DeDi { get; set; } = null!;
        public virtual TribTipoTributo TipoTrib { get; set; } = null!;
    }
}
