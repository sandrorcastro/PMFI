using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbStnMatrizContabilLancamento
{
    public int IdLancamentoMatriz { get; set; }

    public int? IdLancamento { get; set; }

    public short? IdEmpresa { get; set; }

    public byte? NrMes { get; set; }

    public short? NrAno { get; set; }

    public string? CdContaContabil { get; set; }

    public decimal? VlLancamento { get; set; }

    public DateTime? DtLancamento { get; set; }

    public string? DsObjeto { get; set; }

    public string? DsNumObjeto { get; set; }

    public string? CdInformacaoComplementar { get; set; }

    public string? TpNaturezaValor { get; set; }

    public string? DsTipoIc1 { get; set; }

    public string? DsIc1 { get; set; }

    public string? DsTipoValor { get; set; }

    public string? CdOrgao { get; set; }

    public string? CdUnidade { get; set; }

    public byte? NrOrdemExibicao { get; set; }

    public string? CdFonte { get; set; }

    public string? CdFonteStn { get; set; }

    public string? TpFp { get; set; }

    public string? CdNatDespesa { get; set; }

    public string? CdReceita { get; set; }

    public string? CdFuncaoSubFuncao { get; set; }

    public string? CdDivida { get; set; }

    public short? NrAnoRap { get; set; }

    public string? CdEs { get; set; }

    public string? CdComplementoFonte { get; set; }
}
