using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribCategProfissional
{
    public long IdcategProf { get; set; }

    public string? NomeCategProf { get; set; }

    public long IdorgaoClasse { get; set; }

    public virtual TribOrgaosClasse IdorgaoClasseNavigation { get; set; } = null!;

    public virtual ICollection<SaudeServidorCategProf> SaudeServidorCategProfs { get; set; } = new List<SaudeServidorCategProf>();

    public virtual ICollection<TribContribCategProf> TribContribCategProfs { get; set; } = new List<TribContribCategProf>();
}
