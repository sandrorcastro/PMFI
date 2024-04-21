using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribContribCategProf
    {
        public TribContribCategProf()
        {
            TribAlvaraConstrucaoProfissionals = new HashSet<TribAlvaraConstrucaoProfissional>();
            TribProcAdvExecutados = new HashSet<TribProcAdvExecutado>();
        }

        public long IdcontribCategProf { get; set; }
        public long ConId { get; set; }
        public long IdcategProf { get; set; }
        public string? Uf { get; set; }
        public string? NumRegistroCateg { get; set; }

        public virtual Contribuinte Con { get; set; } = null!;
        public virtual TribCategProfissional IdcategProfNavigation { get; set; } = null!;
        public virtual ICollection<TribAlvaraConstrucaoProfissional> TribAlvaraConstrucaoProfissionals { get; set; }
        public virtual ICollection<TribProcAdvExecutado> TribProcAdvExecutados { get; set; }
    }
}
