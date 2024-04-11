using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class GrupoFederacao
{
    public int IdGrupoFederacao { get; set; }

    public int IdUnidade { get; set; }

    public string Nome { get; set; } = null!;

    public string? Descricao { get; set; }

    public string StaTipo { get; set; } = null!;

    public string SinAtivo { get; set; } = null!;

    public virtual Unidade IdUnidadeNavigation { get; set; } = null!;

    public virtual ICollection<OrgaoFederacao> IdOrgaoFederacaos { get; set; } = new List<OrgaoFederacao>();
}
