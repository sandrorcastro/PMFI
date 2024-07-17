using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGTcePRDB
{
    public partial class TbOrcDesdobramentoFonte
    {
        public TbOrcDesdobramentoFonte()
        {
            TbOrcFontesCorrelacaoOrigens = new HashSet<TbOrcFontesCorrelacaoOrigen>();
        }

        public string CdDesdobramento { get; set; } = null!;
        public string? DsDesdobramento { get; set; }

        public virtual ICollection<TbOrcFontesCorrelacaoOrigen> TbOrcFontesCorrelacaoOrigens { get; set; }
    }
}
