using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGTcePRDB
{
    public partial class TbOrcAplicacaoRecurso
    {
        public TbOrcAplicacaoRecurso()
        {
            TbOrcFontesCorrelacaoOrigens = new HashSet<TbOrcFontesCorrelacaoOrigen>();
        }

        public string CdAplicacao { get; set; } = null!;
        public string? DsAplicacao { get; set; }

        public virtual ICollection<TbOrcFontesCorrelacaoOrigen> TbOrcFontesCorrelacaoOrigens { get; set; }
    }
}
