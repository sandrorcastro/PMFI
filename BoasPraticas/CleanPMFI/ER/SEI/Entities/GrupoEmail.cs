using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class GrupoEmail
{
    public int IdGrupoEmail { get; set; }

    public string Nome { get; set; } = null!;

    public string? Descricao { get; set; }

    public int IdUnidade { get; set; }

    public string StaTipo { get; set; } = null!;

    public string SinAtivo { get; set; } = null!;

    public virtual ICollection<EmailGrupoEmail> EmailGrupoEmails { get; set; } = new List<EmailGrupoEmail>();

    public virtual Unidade IdUnidadeNavigation { get; set; } = null!;
}
