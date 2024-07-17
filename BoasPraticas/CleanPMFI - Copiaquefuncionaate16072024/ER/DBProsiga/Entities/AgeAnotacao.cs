using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class AgeAnotacao
{
    public long AnotId { get; set; }

    public long? AgendamId { get; set; }

    public DateTime? AnotData { get; set; }

    public string? AnotDescricao { get; set; }

    public virtual AgeAgendamento? Agendam { get; set; }
}
