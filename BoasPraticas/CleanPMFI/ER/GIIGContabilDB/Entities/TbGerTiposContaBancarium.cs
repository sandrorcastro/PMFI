using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbGerTiposContaBancarium
{
    public short IdTipoContaBancaria { get; set; }

    public string? DsTipoContaBancaria { get; set; }

    public virtual ICollection<TbGerContasCorrente> TbGerContasCorrentes { get; set; } = new List<TbGerContasCorrente>();
}
