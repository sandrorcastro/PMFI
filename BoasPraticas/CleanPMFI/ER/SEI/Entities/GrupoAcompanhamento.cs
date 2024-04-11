using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class GrupoAcompanhamento
{
    public int IdGrupoAcompanhamento { get; set; }

    public string Nome { get; set; } = null!;

    public int IdUnidade { get; set; }

    public virtual ICollection<Acompanhamento> Acompanhamentos { get; set; } = new List<Acompanhamento>();

    public virtual Unidade IdUnidadeNavigation { get; set; } = null!;

    public virtual ICollection<Usuario> IdUsuarios { get; set; } = new List<Usuario>();
}
