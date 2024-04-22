using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class GccMovtoQuest
{
    public string MovQstCnpjmembro { get; set; } = null!;

    public long MovQstCriId { get; set; }

    public int MovQstId { get; set; }

    public int MovQstPergId { get; set; }

    public int MovQstRespId { get; set; }

    public DateTime? MovQstData { get; set; }

    public virtual GccCrianca GccCrianca { get; set; } = null!;

    public virtual GccResposta GccResposta { get; set; } = null!;
}
