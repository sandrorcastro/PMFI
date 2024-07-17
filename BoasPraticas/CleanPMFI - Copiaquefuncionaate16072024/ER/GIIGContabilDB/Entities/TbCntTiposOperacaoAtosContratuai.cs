using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbCntTiposOperacaoAtosContratuai
{
    public short IdTipoOperacaoAto { get; set; }

    public string? DsTipoOperacao { get; set; }

    public short? CdTc { get; set; }

    public virtual ICollection<TbCntAtosContratuai> TbCntAtosContratuais { get; set; } = new List<TbCntAtosContratuai>();

    public virtual ICollection<TbCntTiposAtosContratuai> IdTipoAtoContratuals { get; set; } = new List<TbCntTiposAtosContratuai>();
}
