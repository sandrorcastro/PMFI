using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribExtratoUnificadoTap
{
    public string Sessao { get; set; } = null!;

    public string? TipoCadastro { get; set; }

    public int Idinscricao { get; set; }

    public string? Inscricao { get; set; }

    public int? Idtap { get; set; }

    public int? NumeroTap { get; set; }

    public string? Situacao { get; set; }

    public string? Requerente { get; set; }

    public DateTime? DataTap { get; set; }

    public string? LeiTap { get; set; }

    public string? InscrOrigem { get; set; }

    public string? InscrDestino { get; set; }
}
