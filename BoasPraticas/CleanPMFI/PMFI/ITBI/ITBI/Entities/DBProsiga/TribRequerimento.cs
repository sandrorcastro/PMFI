using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribRequerimento
{
    public long RequerId { get; set; }

    public int? RequerProtocAno { get; set; }

    public int? RequerProtocNum { get; set; }

    public string? RequerNome { get; set; }

    public DateTime? RequerDataInc { get; set; }

    public virtual ICollection<TribRequerimentoDivOrigem> TribRequerimentoDivOrigems { get; set; } = new List<TribRequerimentoDivOrigem>();
}
