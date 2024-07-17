using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class GccQuestionario
{
    public string QuestCnpjmembro { get; set; } = null!;

    public int QuestId { get; set; }

    public string? QuestDescr { get; set; }

    public virtual ICollection<GccPergunta> GccPergunta { get; set; } = new List<GccPergunta>();
}
