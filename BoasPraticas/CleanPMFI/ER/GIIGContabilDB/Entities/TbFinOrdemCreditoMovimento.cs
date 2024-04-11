using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbFinOrdemCreditoMovimento
{
    public int IdMovimento { get; set; }

    public int? IdOrdemCredito { get; set; }

    public int? IdObjeto { get; set; }

    public string? DsObjeto { get; set; }

    public string? FlSituacao { get; set; }

    public string? DsHistorico { get; set; }

    public DateTime? DtMovimento { get; set; }

    public string? DsLogin { get; set; }

    public DateTime? DtInclusao { get; set; }
}
