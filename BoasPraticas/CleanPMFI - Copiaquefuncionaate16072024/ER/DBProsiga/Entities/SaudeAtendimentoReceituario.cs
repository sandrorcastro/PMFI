using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class SaudeAtendimentoReceituario
{
    public long ReceitId { get; set; }

    public long AtendId { get; set; }

    public int CdMedicamento { get; set; }

    public string? ReceitQuantidade { get; set; }

    public string? ReceitDuracao { get; set; }

    public string? ReceitModoUso { get; set; }

    public string? ReceitHora { get; set; }

    public string? UsuarioInclusao { get; set; }

    public DateTime? DataInclusao { get; set; }
}
