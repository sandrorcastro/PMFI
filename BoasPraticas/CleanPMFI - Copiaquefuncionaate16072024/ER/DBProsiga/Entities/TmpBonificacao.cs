using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TmpBonificacao
{
    public long EdificacaoId { get; set; }

    public short BonificAno { get; set; }

    public short? BonificAnos { get; set; }

    public short? BonifcAnosConsecutivos { get; set; }

    public string? Usuario { get; set; }

    public string? Host { get; set; }
}
