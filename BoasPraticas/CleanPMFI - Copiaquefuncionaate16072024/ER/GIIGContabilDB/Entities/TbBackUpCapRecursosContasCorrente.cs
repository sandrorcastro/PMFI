using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbBackUpCapRecursosContasCorrente
{
    public int IdRecurso { get; set; }

    public int IdCc { get; set; }

    public short IdTipoInvestimento { get; set; }

    public string? CdContaContabil { get; set; }

    public string? FlPadraoPagamento { get; set; }

    public string? FlDesdobraReceita { get; set; }
}
