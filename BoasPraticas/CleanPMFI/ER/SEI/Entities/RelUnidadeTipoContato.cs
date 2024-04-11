using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class RelUnidadeTipoContato
{
    public int IdRelUnidadeTipoContato { get; set; }

    public int IdUnidade { get; set; }

    public int IdTipoContato { get; set; }

    public string StaAcesso { get; set; } = null!;

    public virtual TipoContato IdTipoContatoNavigation { get; set; } = null!;

    public virtual Unidade IdUnidadeNavigation { get; set; } = null!;
}
