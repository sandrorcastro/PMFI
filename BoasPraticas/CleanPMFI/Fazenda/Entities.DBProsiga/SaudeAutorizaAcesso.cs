using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class SaudeAutorizaAcesso
{
    public int IdLogonAutorizado { get; set; }

    public string? TipoOrgao { get; set; }

    public int? IdLaboratorio { get; set; }

    public int? IdUnidadeSaude { get; set; }

    public virtual UnidadeSaude? IdUnidadeSaudeNavigation { get; set; }

    public virtual ICollection<SaudeUsuariosUnidade> SaudeUsuariosUnidades { get; set; } = new List<SaudeUsuariosUnidade>();
}
