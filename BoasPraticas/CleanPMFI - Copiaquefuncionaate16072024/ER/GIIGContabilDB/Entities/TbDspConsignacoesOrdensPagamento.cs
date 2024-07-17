using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspConsignacoesOrdensPagamento
{
    public int IdConsignacao { get; set; }

    public int IdOrdemPagamento { get; set; }

    public int IdAutorizacao { get; set; }
}
