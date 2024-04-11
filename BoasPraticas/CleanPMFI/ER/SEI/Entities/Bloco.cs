using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class Bloco
{
    public int IdBloco { get; set; }

    public int IdUnidade { get; set; }

    public int IdUsuario { get; set; }

    public string? Descricao { get; set; }

    public string StaTipo { get; set; } = null!;

    public string? IdxBloco { get; set; }

    public string StaEstado { get; set; } = null!;

    public virtual Unidade IdUnidadeNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;

    public virtual ICollection<RelBlocoProtocolo> RelBlocoProtocolos { get; set; } = new List<RelBlocoProtocolo>();

    public virtual ICollection<RelBlocoUnidade> RelBlocoUnidades { get; set; } = new List<RelBlocoUnidade>();
}
