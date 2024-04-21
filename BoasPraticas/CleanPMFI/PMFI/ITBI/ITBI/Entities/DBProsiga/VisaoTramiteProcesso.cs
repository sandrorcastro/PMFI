using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class VisaoTramiteProcesso
{
    public long NoCarga { get; set; }

    public DateTime? DataCarga { get; set; }

    public long? NoProcesso { get; set; }

    public string? Descritivo { get; set; }

    public int? Iddiv { get; set; }

    public string? NomeDivisão { get; set; }

    public string? LocalizadoEm { get; set; }

    public DateTime? ProcDataPrevResp { get; set; }

    public string? ProcSituacao { get; set; }
}
