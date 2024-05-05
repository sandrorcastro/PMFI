using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class AlmoxRequisicoesPendente
{
    public long RequisicaoItemId { get; set; }

    public long? RequisicaoId { get; set; }

    public long? AlmoxId { get; set; }

    public long? ItemId { get; set; }

    public decimal? ReqItQtde { get; set; }

    public decimal? ReqItQtdeAtendida { get; set; }

    public string? ReqIsituacao { get; set; }

    public string? ReqIobservacao { get; set; }

    public string? AlmoxNome { get; set; }
}
