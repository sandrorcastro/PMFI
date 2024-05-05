using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TmpCragiig
{
    public string? Devedor { get; set; }

    public string? Documento { get; set; }

    public double? Valor { get; set; }

    public string? Cda { get; set; }

    public string? Ocorrência { get; set; }

    public string? DataCancelamento { get; set; }

    public string? DataDesistência { get; set; }

    public string? DataAutorizacao { get; set; }

    public int? Ordem { get; set; }
}
