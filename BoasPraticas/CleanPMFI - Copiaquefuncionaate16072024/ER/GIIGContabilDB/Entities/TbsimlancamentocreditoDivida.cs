using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbsimlancamentocreditoDivida
{
    public int Idlancamento { get; set; }

    public int Idnaturezacredito { get; set; }

    public int Idtipocredito { get; set; }

    public int Idtipooperacao { get; set; }

    public DateTime Dtlancamento { get; set; }

    public int Nrmescompetencia { get; set; }

    public int Nranocompetencia { get; set; }

    public int Idleiato { get; set; }

    public decimal Vllancamento { get; set; }

    public int? ImoIddivida { get; set; }

    public int? DivEmpId { get; set; }

    public int? ConIddivida { get; set; }

    public int? Idcredito { get; set; }

    public string? Dsorigem { get; set; }

    public int? TapId { get; set; }

    public string? TipoDivida { get; set; }

    public int? Tipotribid { get; set; }

    public DateTime? DataInscricaoDa { get; set; }

    public int? Nranodivida { get; set; }

    public int? Tipobxid { get; set; }
}
