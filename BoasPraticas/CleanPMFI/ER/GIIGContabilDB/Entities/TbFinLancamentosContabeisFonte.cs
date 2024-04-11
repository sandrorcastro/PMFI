using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbFinLancamentosContabeisFonte
{
    public int IdLancamentoFonte { get; set; }

    public int? IdLancamento { get; set; }

    public int? IdContaContabilDebito { get; set; }

    public int? IdFonteDebito { get; set; }

    public int? IdContaContabilCredito { get; set; }

    public int? IdFonteCredito { get; set; }
}
