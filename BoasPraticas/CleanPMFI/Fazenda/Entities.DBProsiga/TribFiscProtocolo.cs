using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribFiscProtocolo
{
    public int ProtId { get; set; }

    public DateTime? Data { get; set; }

    public string? Operacao { get; set; }

    public virtual ICollection<TribFiscReceitum> Recs { get; set; } = new List<TribFiscReceitum>();
}
