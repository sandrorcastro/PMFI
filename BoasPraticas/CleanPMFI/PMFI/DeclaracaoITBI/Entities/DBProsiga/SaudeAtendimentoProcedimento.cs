using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class SaudeAtendimentoProcedimento
{
    public long ProcedId { get; set; }

    public long AtendId { get; set; }

    public int CdProcedimento { get; set; }

    public string? ProcedQuantidade { get; set; }

    public int? CdMedicamento { get; set; }

    public string? ProcedModoProceder { get; set; }

    public string? ProcedHora { get; set; }

    public string? UsuarioInclusao { get; set; }

    public DateTime? DataInclusao { get; set; }
}
