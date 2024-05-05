using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class GccResposta
{
    public string RespCnpjmembro { get; set; } = null!;

    public int RespQuestId { get; set; }

    public int RespPergId { get; set; }

    public int RespId { get; set; }

    public string? RespDescrResp { get; set; }

    public virtual ICollection<GccMovtoQuest> GccMovtoQuests { get; set; } = new List<GccMovtoQuest>();

    public virtual GccPergunta GccPergunta { get; set; } = null!;
}
