using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class Orgao
{
    public int OrgId { get; set; }

    public string? OrgNome { get; set; }

    public string? OrgCnpjfilial { get; set; }

    public string? OrgExtincao { get; set; }

    public DateTime? OrgDtExtincao { get; set; }

    public virtual Membro? OrgCnpjfilialNavigation { get; set; }

    public virtual ICollection<Unidade> Unidades { get; set; } = new List<Unidade>();
}
