using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class AgeAssunto
{
    public int AssunId { get; set; }

    public string? AssunDescricao { get; set; }

    public virtual ICollection<AgeAgendamento> AgeAgendamentos { get; set; } = new List<AgeAgendamento>();
}
