using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class HabProgrAtendimento
{
    public int ProgrAtendimentoId { get; set; }

    public DateTime? HoraInicial { get; set; }

    public DateTime? HoraFinal { get; set; }

    public int? Atendentes { get; set; }

    public int? TempoAtendimento { get; set; }

    public int? AtendimentosPeriodo { get; set; }
}
