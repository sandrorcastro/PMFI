using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGTcePRDB
{
    public partial class TbGerTipoOperacaoCredito
    {
        public TbGerTipoOperacaoCredito()
        {
            TbDivLancamentoCreditos = new HashSet<TbDivLancamentoCredito>();
        }

        public short IdTpOpCredito { get; set; }
        public string? DsTpOpCredito { get; set; }

        public virtual ICollection<TbDivLancamentoCredito> TbDivLancamentoCreditos { get; set; }
    }
}
