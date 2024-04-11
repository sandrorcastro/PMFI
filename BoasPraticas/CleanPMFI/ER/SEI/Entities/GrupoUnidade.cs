using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class GrupoUnidade
{
    public int IdGrupoUnidade { get; set; }

    public string Nome { get; set; } = null!;

    public string? Descricao { get; set; }

    public string StaTipo { get; set; } = null!;

    public string SinAtivo { get; set; } = null!;

    public int IdUnidade { get; set; }

    public virtual Unidade IdUnidadeNavigation { get; set; } = null!;

    public virtual ICollection<Unidade> IdUnidades { get; set; } = new List<Unidade>();
}
