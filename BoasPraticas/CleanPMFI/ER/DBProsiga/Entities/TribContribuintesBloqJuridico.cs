using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribContribuintesBloqJuridico
{
    public int BloqId { get; set; }

    public DateTime? BloqData { get; set; }

    public string? BloqCpfcnpj { get; set; }

    public DateTime? BloqDataIni { get; set; }

    public DateTime? BloqDataFim { get; set; }

    public string? Observacoes { get; set; }

    public string? UsuarioInclusao { get; set; }
}
