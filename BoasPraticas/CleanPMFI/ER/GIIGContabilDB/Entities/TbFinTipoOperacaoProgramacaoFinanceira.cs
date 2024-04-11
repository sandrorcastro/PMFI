using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbFinTipoOperacaoProgramacaoFinanceira
{
    public short IdTipoOperacao { get; set; }

    public string? DsTipoOperacao { get; set; }

    public virtual ICollection<TbFinCronogramaDesembolso> TbFinCronogramaDesembolsos { get; set; } = new List<TbFinCronogramaDesembolso>();
}
