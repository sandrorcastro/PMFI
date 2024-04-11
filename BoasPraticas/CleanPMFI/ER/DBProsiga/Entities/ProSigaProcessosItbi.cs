using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class ProSigaProcessosItbi
{
    public long ProcId { get; set; }

    public int? ProcTipoProcId { get; set; }

    public string? TipoProNome { get; set; }

    public long? ProcIdContribuinte { get; set; }

    public string? ConNome { get; set; }

    public string? ConCnpjcpf { get; set; }

    public string? ProcDescricao { get; set; }

    public int? ProcAno { get; set; }

    public long? ProcSeqAnual { get; set; }

    public DateTime? ProcDataEntrada { get; set; }

    public int? ProcDivTramitacao { get; set; }

    public string? DivNome { get; set; }
}
