using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribOrgaosClasse
{
    public long IdorgaoClasse { get; set; }

    public string? NomeOrgaoClasse { get; set; }

    public string? SiglaOrgao { get; set; }

    public virtual ICollection<TribCategProfissional> TribCategProfissionals { get; set; } = new List<TribCategProfissional>();
}
