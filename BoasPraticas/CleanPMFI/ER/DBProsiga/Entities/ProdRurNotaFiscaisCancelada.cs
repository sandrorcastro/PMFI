using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class ProdRurNotaFiscaisCancelada
{
    public int IdcancNf { get; set; }

    public DateTime? Data { get; set; }

    public int IdnotaFiscal { get; set; }

    public string? Historico { get; set; }

    public virtual ProdRurNotaFiscal IdnotaFiscalNavigation { get; set; } = null!;
}
