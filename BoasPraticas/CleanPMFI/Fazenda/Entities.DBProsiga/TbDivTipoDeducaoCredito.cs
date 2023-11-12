using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TbDivTipoDeducaoCredito
{
    public short IdTipoDeducaoCredito { get; set; }

    public string? DsTipoDeducaoCredito { get; set; }

    public int? GrupoId { get; set; }

    public virtual ICollection<TbDivLancamentoDeducaoCredito> TbDivLancamentoDeducaoCreditos { get; set; } = new List<TbDivLancamentoDeducaoCredito>();
}
