using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbOrcTiposOperacaoCreditoAdicional
{
    public short IdTipoOperacaoCreditoAdicional { get; set; }

    public string? DsTipoOperacaoCreditoAdicional { get; set; }

    public virtual ICollection<TbOrcAlteracoesOrcamentaria> TbOrcAlteracoesOrcamentaria { get; set; } = new List<TbOrcAlteracoesOrcamentaria>();
}
