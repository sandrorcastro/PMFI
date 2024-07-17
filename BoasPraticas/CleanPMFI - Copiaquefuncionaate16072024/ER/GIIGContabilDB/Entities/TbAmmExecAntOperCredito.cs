using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbAmmExecAntOperCredito
{
    public int IdExecAntecipada { get; set; }

    public short? IdEmpresa { get; set; }

    public string? FlOperacao { get; set; }

    public int? IdDivida { get; set; }

    public short? NrAnoEmpenho { get; set; }

    public int? NrEmpenho { get; set; }

    public short? NrAnoLiquidacao { get; set; }

    public int? NrLiquidacao { get; set; }

    public int? NrPagamentoBaixa { get; set; }

    public decimal? VlAntecipado { get; set; }

    public string? CdFonte { get; set; }

    public short? NrAnoPagamento { get; set; }
}
