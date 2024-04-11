using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class VwRelSaldosContaContabilFonte
{
    public short? NrMes { get; set; }

    public int? IdEmpresa { get; set; }

    public short? NrAno { get; set; }

    public string? CdContaContabil { get; set; }

    public string? CdFonte { get; set; }

    public decimal? VlSaldoInicial { get; set; }

    public decimal? VlCredito { get; set; }

    public decimal? VlCreditoSemEstorno { get; set; }

    public decimal? VlDebito { get; set; }

    public decimal? VlDebitoSemEstorno { get; set; }

    public decimal? VlSaldoProximo { get; set; }

    public decimal? VlDebitoCredito { get; set; }

    public decimal? VlCreditoDebito { get; set; }
}
