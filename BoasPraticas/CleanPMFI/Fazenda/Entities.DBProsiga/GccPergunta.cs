using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class GccPergunta
{
    public string PergCnpjmembro { get; set; } = null!;

    public int PergQuestId { get; set; }

    public int PergId { get; set; }

    public string? PergDescricao { get; set; }

    public virtual ICollection<GccResposta> GccResposta { get; set; } = new List<GccResposta>();

    public virtual GccQuestionario Perg { get; set; } = null!;
}
