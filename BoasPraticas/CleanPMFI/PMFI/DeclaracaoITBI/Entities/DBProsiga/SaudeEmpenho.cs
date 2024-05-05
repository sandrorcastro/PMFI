using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class SaudeEmpenho
{
    public long IdEmpenho { get; set; }

    public string? Cnpjempenho { get; set; }

    public string? TipoDespesa { get; set; }

    public string? AnoEmpenho { get; set; }

    public long? NrEmpenho { get; set; }

    public string? CnpjFornecedor { get; set; }

    public DateTime? DataEmpenho { get; set; }

    public string? Historico { get; set; }

    public string? Prazo { get; set; }

    public decimal? Valor { get; set; }
}
