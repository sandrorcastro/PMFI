using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribOrgaosClasse
    {
        public TribOrgaosClasse()
        {
            TribCategProfissionals = new HashSet<TribCategProfissional>();
        }

        public long IdorgaoClasse { get; set; }
        public string? NomeOrgaoClasse { get; set; }
        public string? SiglaOrgao { get; set; }

        public virtual ICollection<TribCategProfissional> TribCategProfissionals { get; set; }
    }
}
