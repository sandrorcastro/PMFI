using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class Tbatendeagendamento
{
    public int Idagendamento { get; set; }

    public int? Idusuario { get; set; }

    public string? Nmsolicitante { get; set; }

    public string? Dstelefone1 { get; set; }

    public string? Dstelefone2 { get; set; }

    public string? Dstelefone3 { get; set; }

    public int? Idservico { get; set; }

    public DateTime? Dtagendamento { get; set; }

    public string? Flstatus { get; set; }

    public string? Dsavaliacao { get; set; }

    public string? Dsobservacao { get; set; }

    public TimeSpan? Horainicial { get; set; }

    public TimeSpan? Horafinal { get; set; }

    /// <summary>
    /// [I]nterno (via sistema) ou [E]xterno (Via Portal)
    /// </summary>
    public string Florigem { get; set; } = null!;

    public DateTime? Dtnascimento { get; set; }

    public string? Dsendereco { get; set; }

    public string? Nrcpf { get; set; }

    public string? Dsdose { get; set; }

    public int? Idusuariofinalizou { get; set; }

    public DateTime? Dtfinalizado { get; set; }

    public int? Idusuarioconfirmou { get; set; }

    public DateTime? Dtconfirmacao { get; set; }

    public int? Idusuariocancelou { get; set; }

    public DateTime? Dtcancelamento { get; set; }

    public int? Idusuarioatendimento { get; set; }

    public DateTime? Dtatendimento { get; set; }

    public int? Idusuarioausente { get; set; }

    public DateTime? Dtausente { get; set; }
}
