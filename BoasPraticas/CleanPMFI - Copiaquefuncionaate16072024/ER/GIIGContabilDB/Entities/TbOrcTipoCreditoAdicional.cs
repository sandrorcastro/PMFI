using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbOrcTipoCreditoAdicional
{
    public short IdTipoCreditoAdicional { get; set; }

    public string? DsTipoCreditoAdicional { get; set; }

    public virtual ICollection<TbOrcAlteracoesOrcamentaria> TbOrcAlteracoesOrcamentaria { get; set; } = new List<TbOrcAlteracoesOrcamentaria>();

    public virtual ICollection<TbOrcAutorizacaoCreditoAdicional> TbOrcAutorizacaoCreditoAdicionals { get; set; } = new List<TbOrcAutorizacaoCreditoAdicional>();

    public virtual ICollection<TbOrcLimitesCreditoAdicional> TbOrcLimitesCreditoAdicionals { get; set; } = new List<TbOrcLimitesCreditoAdicional>();
}
