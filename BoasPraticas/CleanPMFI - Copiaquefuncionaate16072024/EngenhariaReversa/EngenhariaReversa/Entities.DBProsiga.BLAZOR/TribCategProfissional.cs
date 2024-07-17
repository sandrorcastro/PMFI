using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribCategProfissional
    {
        public TribCategProfissional()
        {
            SaudeServidorCategProfs = new HashSet<SaudeServidorCategProf>();
            TribContribCategProfs = new HashSet<TribContribCategProf>();
        }

        public long IdcategProf { get; set; }
        public string? NomeCategProf { get; set; }
        public long IdorgaoClasse { get; set; }

        public virtual TribOrgaosClasse IdorgaoClasseNavigation { get; set; } = null!;
        public virtual ICollection<SaudeServidorCategProf> SaudeServidorCategProfs { get; set; }
        public virtual ICollection<TribContribCategProf> TribContribCategProfs { get; set; }
    }
}
