using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGTcePRDB
{
    public partial class TbGerTipoAtualizacaoCredito
    {
        public TbGerTipoAtualizacaoCredito()
        {
            TbDivLancamentoAtualizacaoMonetariaCreditos = new HashSet<TbDivLancamentoAtualizacaoMonetariaCredito>();
        }

        public short IdTpAtualizacaoCredito { get; set; }
        public string? DsTpAtualizacaoCredito { get; set; }

        public virtual ICollection<TbDivLancamentoAtualizacaoMonetariaCredito> TbDivLancamentoAtualizacaoMonetariaCreditos { get; set; }
    }
}
