using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class HabProblema
{
    public int ProblemaId { get; set; }

    public string? ProbDescricao { get; set; }

    public string? ProbObservacao { get; set; }

    public virtual ICollection<HabProblemasAtendimento> HabProblemasAtendimentos { get; set; } = new List<HabProblemasAtendimento>();
}
