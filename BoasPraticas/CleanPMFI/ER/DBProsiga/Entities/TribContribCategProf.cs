using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribContribCategProf
{
    public long IdcontribCategProf { get; set; }

    public long ConId { get; set; }

    public long IdcategProf { get; set; }

    public string? Uf { get; set; }

    public string? NumRegistroCateg { get; set; }

    public virtual Contribuinte Con { get; set; } = null!;

    public virtual TribCategProfissional IdcategProfNavigation { get; set; } = null!;

    public virtual ICollection<TribAlvaraConstrucaoProfissional> TribAlvaraConstrucaoProfissionals { get; set; } = new List<TribAlvaraConstrucaoProfissional>();

    public virtual ICollection<TribProcAdvExecutado> TribProcAdvExecutados { get; set; } = new List<TribProcAdvExecutado>();
}
