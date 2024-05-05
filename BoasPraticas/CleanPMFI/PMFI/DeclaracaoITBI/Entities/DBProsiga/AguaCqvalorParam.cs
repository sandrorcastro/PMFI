using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class AguaCqvalorParam
{
    public int CqvlrId { get; set; }

    public string? CqvlrSede { get; set; }

    public int? CqparamId { get; set; }

    public int? CqvlrMes { get; set; }

    public int? CqvlrAno { get; set; }

    public string? CqvlrValor { get; set; }
}
