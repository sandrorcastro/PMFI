using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class VwRelSaldosContaContabilFonteDisponivelFinanceiro
{
    public short? NrMes { get; set; }

    public int? IdEmpresa { get; set; }

    public short? NrAno { get; set; }

    public string? CdContaContabil { get; set; }

    public string? CdFonte { get; set; }

    public string? CdOrigem { get; set; }

    public string? CdAplicacaoFonte { get; set; }

    public string? CdDesdobramentoFonte { get; set; }

    public string? CdDetalhamento { get; set; }

    public decimal? VlSaldoInicial { get; set; }

    public decimal? VlCredito { get; set; }

    public decimal? VlCreditoSemEstorno { get; set; }

    public decimal? VlDebito { get; set; }

    public decimal? VlDebitoSemEstorno { get; set; }

    public decimal? VlSaldoProximo { get; set; }

    public decimal? VlDebitoCredito { get; set; }

    public decimal? VlCreditoDebito { get; set; }

    public decimal? DisponivelFinaceiro { get; set; }
}
