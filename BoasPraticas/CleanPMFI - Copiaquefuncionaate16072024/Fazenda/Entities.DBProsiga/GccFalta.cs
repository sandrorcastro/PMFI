using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class GccFalta
{
    public string FaltCnpjmembro { get; set; } = null!;

    public int FaltCrecheId { get; set; }

    public long FaltCriId { get; set; }

    public DateTime FaltData { get; set; }

    public string? FaltMotivo { get; set; }

    public virtual GccCriCreche FaltC { get; set; } = null!;
}
