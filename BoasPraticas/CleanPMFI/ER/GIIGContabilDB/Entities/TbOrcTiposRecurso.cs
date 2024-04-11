using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbOrcTiposRecurso
{
    public short IdTipoRecurso { get; set; }

    public string? NmTipoRecurso { get; set; }

    public string? DsSigla { get; set; }

    public bool? FlAtivo { get; set; }

    public short? CdTc { get; set; }

    public virtual ICollection<TbOrcAlteracoesOrcamentaria> TbOrcAlteracoesOrcamentaria { get; set; } = new List<TbOrcAlteracoesOrcamentaria>();
}
