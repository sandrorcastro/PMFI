using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbRelSaldosMensaisNatDespesa
{
    public int IdSaldo { get; set; }

    public short? NrMes { get; set; }

    public short? IdEmpresa { get; set; }

    public short? NrAno { get; set; }

    public short? NrExercicio { get; set; }

    public string? CdOrgao { get; set; }

    public string? CdUnidade { get; set; }

    public string? CdFuncao { get; set; }

    public string? CdSubFuncao { get; set; }

    public string? CdPrograma { get; set; }

    public string? CdAcao { get; set; }

    public string? CdNatDespesa { get; set; }

    public string? CdFonte { get; set; }

    public string? CdFonteNormal { get; set; }

    public decimal? VlOrcado { get; set; }

    public decimal? VlAlteracao { get; set; }

    public decimal? VlAtualizado { get; set; }

    public decimal? VlEmpenho { get; set; }

    public decimal? VlEstornoEmpenho { get; set; }

    public decimal? VlLiquidacao { get; set; }

    public decimal? VlEstornoLiquidacao { get; set; }

    public decimal? VlConsignacao { get; set; }

    public decimal? VlPagamento { get; set; }

    public decimal? VlEstornoPagamento { get; set; }

    public decimal? VlRetencaoPaga { get; set; }

    public decimal? VlEstornoRetencaoPaga { get; set; }

    public string? CdCatDespesa { get; set; }

    public string? CdGrupoDespesa { get; set; }

    public string? CdModalidade { get; set; }

    public string? CdElemento { get; set; }

    public string? CdDesdobramento { get; set; }

    public string? CdDetalhamento { get; set; }

    public decimal? VlSaldoNaoProcessado { get; set; }

    public decimal? VlReversaoEstorno { get; set; }

    public string? CdOrigem { get; set; }

    public string? CdAplicacaoFonte { get; set; }

    public string? CdDesdobramentoFonte { get; set; }

    public string? CdDetalhamentoFonte { get; set; }
}
