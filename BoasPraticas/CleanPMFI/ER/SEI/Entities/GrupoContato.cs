using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class GrupoContato
{
    public int IdGrupoContato { get; set; }

    public int IdUnidade { get; set; }

    public string Nome { get; set; } = null!;

    public string? Descricao { get; set; }

    public string SinAtivo { get; set; } = null!;

    public string StaTipo { get; set; } = null!;

    public virtual Unidade IdUnidadeNavigation { get; set; } = null!;

    public virtual ICollection<Contato> IdContatos { get; set; } = new List<Contato>();
}
