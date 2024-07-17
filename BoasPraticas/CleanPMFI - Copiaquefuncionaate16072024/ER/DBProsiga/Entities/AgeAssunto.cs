using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class AgeAssunto
{
    public int AssunId { get; set; }

    public string? AssunDescricao { get; set; }

    public virtual ICollection<AgeAgendamento> AgeAgendamentos { get; set; } = new List<AgeAgendamento>();
}
