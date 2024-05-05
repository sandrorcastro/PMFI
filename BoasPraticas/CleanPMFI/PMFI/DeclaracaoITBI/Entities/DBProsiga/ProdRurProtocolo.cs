using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class ProdRurProtocolo
{
    public int Idprotocolo { get; set; }

    public DateTime? Data { get; set; }

    public string? Operacao { get; set; }

    public virtual ICollection<ProdRurNotaFiscal> IdnotaFiscals { get; set; } = new List<ProdRurNotaFiscal>();
}
