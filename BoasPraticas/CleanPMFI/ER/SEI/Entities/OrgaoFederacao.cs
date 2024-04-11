using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class OrgaoFederacao
{
    public string IdOrgaoFederacao { get; set; } = null!;

    public string IdInstalacaoFederacao { get; set; } = null!;

    public string Sigla { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public virtual ICollection<AcessoFederacao> AcessoFederacaoIdOrgaoFederacaoDestNavigations { get; set; } = new List<AcessoFederacao>();

    public virtual ICollection<AcessoFederacao> AcessoFederacaoIdOrgaoFederacaoRemNavigations { get; set; } = new List<AcessoFederacao>();

    public virtual InstalacaoFederacao IdInstalacaoFederacaoNavigation { get; set; } = null!;

    public virtual ICollection<Orgao> Orgaos { get; set; } = new List<Orgao>();

    public virtual ICollection<GrupoFederacao> IdGrupoFederacaos { get; set; } = new List<GrupoFederacao>();
}
