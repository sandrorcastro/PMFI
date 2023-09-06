using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGTcePRDB
{
    public partial class TbGerTipoNaturezaCredito
    {
        public TbGerTipoNaturezaCredito()
        {
            TbDivLancamentoCreditos = new HashSet<TbDivLancamentoCredito>();
        }

        public short IdTpNatCredito { get; set; }
        public string? DsTpNatCredito { get; set; }

        public virtual ICollection<TbDivLancamentoCredito> TbDivLancamentoCreditos { get; set; }
    }
}
