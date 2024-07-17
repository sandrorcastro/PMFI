using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class VwGeomais13Loteamento
{
    public int CdLoteamento { get; set; }

    public string? NmLoteamento { get; set; }

    public int? CdPessoa { get; set; }

    public int? NrAprovacao { get; set; }

    public int? DtAprovacao { get; set; }

    public int? MdArea { get; set; }

    public int? MdAreaComum { get; set; }

    public int? MdAreaVerde { get; set; }
}
