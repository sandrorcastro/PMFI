using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TbDivTipoDeducaoCredito
    {
        public TbDivTipoDeducaoCredito()
        {
            TbDivLancamentoDeducaoCreditos = new HashSet<TbDivLancamentoDeducaoCredito>();
        }

        public short IdTipoDeducaoCredito { get; set; }
        public string? DsTipoDeducaoCredito { get; set; }
        public int? GrupoId { get; set; }

        public virtual ICollection<TbDivLancamentoDeducaoCredito> TbDivLancamentoDeducaoCreditos { get; set; }
    }
}
