using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGTcePRDB
{
    public partial class TbOrcOrigemRecurso
    {
        public TbOrcOrigemRecurso()
        {
            TbOrcFontesCorrelacaoOrigens = new HashSet<TbOrcFontesCorrelacaoOrigen>();
        }

        public string CdOrigem { get; set; } = null!;
        public string? DsOrigem { get; set; }

        public virtual ICollection<TbOrcFontesCorrelacaoOrigen> TbOrcFontesCorrelacaoOrigens { get; set; }
    }
}
