using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class VwAgendamento
{
    public int Idagendamento { get; set; }

    public DateOnly? Dtagendamento { get; set; }

    public TimeOnly? Horainicial { get; set; }

    public TimeOnly? Horafinal { get; set; }

    public string? Flstatus { get; set; }

    public string Nmservico { get; set; } = null!;

    public string? Nmlocal { get; set; }

    public DateTime? Dtnascimento { get; set; }
}
