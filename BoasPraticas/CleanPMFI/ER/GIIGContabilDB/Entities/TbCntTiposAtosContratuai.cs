using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbCntTiposAtosContratuai
{
    public short IdTipoAtoContratual { get; set; }

    public string? NmTipoAtoContratual { get; set; }

    public string? DsSigla { get; set; }

    public short? CdTc { get; set; }

    public bool? FlAtivo { get; set; }

    public bool? FlAtivoApostilamento { get; set; }

    public virtual ICollection<TbCntAtosContratuai> TbCntAtosContratuais { get; set; } = new List<TbCntAtosContratuai>();

    public virtual ICollection<TbCntTiposOperacaoAtosContratuai> IdTipoOperacaoAtos { get; set; } = new List<TbCntTiposOperacaoAtosContratuai>();
}
