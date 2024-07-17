using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGTcePRDB
{
    public partial class TbOrcDetalhamentoFonte
    {
        public TbOrcDetalhamentoFonte()
        {
            TbOrcFontesCorrelacaoOrigens = new HashSet<TbOrcFontesCorrelacaoOrigen>();
        }

        public string CdDetalhamento { get; set; } = null!;
        public string? DsDetalhamento { get; set; }

        public virtual ICollection<TbOrcFontesCorrelacaoOrigen> TbOrcFontesCorrelacaoOrigens { get; set; }
    }
}
