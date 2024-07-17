using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGTcePRDB
{
    public partial class TbGerTipoDeducaoCredito
    {
        public TbGerTipoDeducaoCredito()
        {
            TbDivLancamentoDeducaoCreditos = new HashSet<TbDivLancamentoDeducaoCredito>();
        }

        public short IdTpDeducaoCredito { get; set; }
        public string? DsTpDeducaoCredito { get; set; }

        public virtual ICollection<TbDivLancamentoDeducaoCredito> TbDivLancamentoDeducaoCreditos { get; set; }
    }
}
