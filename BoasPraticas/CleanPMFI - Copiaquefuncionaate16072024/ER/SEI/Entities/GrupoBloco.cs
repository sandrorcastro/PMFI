using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class GrupoBloco
{
    public int IdGrupoBloco { get; set; }

    public int IdUnidade { get; set; }

    public string Nome { get; set; } = null!;

    public string SinAtivo { get; set; } = null!;

    public virtual Unidade IdUnidadeNavigation { get; set; } = null!;

    public virtual ICollection<RelBlocoUnidade> RelBlocoUnidades { get; set; } = new List<RelBlocoUnidade>();

    public virtual ICollection<Usuario> IdUsuarios { get; set; } = new List<Usuario>();
}
