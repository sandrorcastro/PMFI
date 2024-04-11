using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbOrcTiposAlteracaoOrcamentarium
{
    public short IdTipoAlteracao { get; set; }

    public string? NmTipoAlteracao { get; set; }

    public string? DsSigla { get; set; }

    public bool? FlAtivo { get; set; }

    public short? CdTc { get; set; }

    public virtual ICollection<TbOrcAlteracoesOrcamentaria> TbOrcAlteracoesOrcamentaria { get; set; } = new List<TbOrcAlteracoesOrcamentaria>();
}
