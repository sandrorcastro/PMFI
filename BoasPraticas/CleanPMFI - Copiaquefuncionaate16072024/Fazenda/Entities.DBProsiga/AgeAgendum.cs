using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class AgeAgendum
{
    public long AgendaId { get; set; }

    public long? ServId { get; set; }

    public string? AgendaSituacao { get; set; }

    public DateTime? AgendaDataCad { get; set; }

    public string? AgendaMensagem { get; set; }

    public virtual ICollection<AgeAgendaIntervalo> AgeAgendaIntervalos { get; set; } = new List<AgeAgendaIntervalo>();

    public virtual ICollection<AgeAgendaTipoAgendamento> AgeAgendaTipoAgendamentos { get; set; } = new List<AgeAgendaTipoAgendamento>();

    public virtual ICollection<AgeAgendamento> AgeAgendamentos { get; set; } = new List<AgeAgendamento>();

    public virtual ICollection<AgePermissao> AgePermissaos { get; set; } = new List<AgePermissao>();

    public virtual Servidore? Serv { get; set; }
}
