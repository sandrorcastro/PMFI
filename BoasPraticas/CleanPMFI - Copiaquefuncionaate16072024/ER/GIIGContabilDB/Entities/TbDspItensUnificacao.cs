using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspItensUnificacao
{
    public int IdItemUnificacao { get; set; }

    public int? IdItem { get; set; }

    public int? IdItemAnterior { get; set; }

    public DateTime? DtUnificacao { get; set; }

    public string? DsObjeto { get; set; }

    public int? DsNumObjeto { get; set; }

    public string? DsLogin { get; set; }
}
