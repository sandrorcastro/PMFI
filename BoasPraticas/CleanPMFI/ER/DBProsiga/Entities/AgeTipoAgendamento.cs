using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class AgeTipoAgendamento
{
    public long TipoAgeId { get; set; }

    public string? TipoAgeNome { get; set; }

    public virtual ICollection<AgeAgendaTipoAgendamento> AgeAgendaTipoAgendamentos { get; set; } = new List<AgeAgendaTipoAgendamento>();

    public virtual ICollection<AgeAgendamento> AgeAgendamentos { get; set; } = new List<AgeAgendamento>();
}
