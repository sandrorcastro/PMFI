using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TmpdspLiquidacoesDocumentosCmfi
{
    public int? IdLiquidacaoDocto { get; set; }

    public int? IdLiquidacao { get; set; }

    public int? IdEstorno { get; set; }

    public int? IdTipoDoctoFiscal { get; set; }

    public string? NrDocumento { get; set; }

    public DateTime? DtDocumento { get; set; }

    public decimal? VlDocumento { get; set; }

    public string? DsSerie { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }

    public DateTime? DtVencimento { get; set; }

    public int? IdEmpenho { get; set; }

    public int? IdLiquidacaoDoctoOrigem { get; set; }

    public int? CdCfop { get; set; }

    public decimal? VlIcmsdestacado { get; set; }

    public decimal? VlIcmsretido { get; set; }

    public string? NrSeloSefa { get; set; }

    public string? DsSerieSeloSefa { get; set; }

    public short? NrCompMes { get; set; }

    public short? NrCompAno { get; set; }

    public short? IdSerie { get; set; }

    public short? IdTipoSerieDocFiscal { get; set; }

    public DateTime? DtRecebimento { get; set; }

    public string? NrCodigoBarras { get; set; }

    public decimal? VlMoraJuros { get; set; }

    public string? NrAutenticacao { get; set; }

    public string? NrReferencia { get; set; }

    public decimal? VlPrincipalGru { get; set; }

    public decimal? VlDescontoGru { get; set; }

    public string? NrLinhaDigitavel { get; set; }

    public string? DsTipoComunicacao { get; set; }
}
