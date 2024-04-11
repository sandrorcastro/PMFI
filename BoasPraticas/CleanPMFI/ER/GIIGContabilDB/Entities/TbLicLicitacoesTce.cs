using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicLicitacoesTce
{
    public int IdLicitacao { get; set; }

    public short IdEmpresa { get; set; }

    public short? NrAno { get; set; }

    public short? IdModalidade { get; set; }

    public short? IdNaturezaProcedimento { get; set; }

    public int? NrLicitacao { get; set; }

    public DateTime? DtEdital { get; set; }

    public DateTime? DtPublicacaoDoe { get; set; }

    public DateTime? DtAbertura { get; set; }

    public string? DsHoraAbertura { get; set; }

    public DateTime? DtJulgamento { get; set; }

    public string? DsHoraJulgamento { get; set; }

    public DateTime? DtHomologacao { get; set; }

    public short? IdLocal { get; set; }

    public string DsObjeto { get; set; } = null!;

    public short? IdTipoAvaliacao { get; set; }

    public short? NrPontuacaoMinima { get; set; }

    public short? IdClassificacaoObjeto { get; set; }

    public short? IdRegimeExecucao { get; set; }

    public short? IdEmpresaOrigem { get; set; }

    public decimal? VlMinimo { get; set; }

    public decimal? VlMaximo { get; set; }

    public string? DsClausulaProrrogacao { get; set; }

    public short? IdBemServico { get; set; }

    public string? FlVencedorPorLote { get; set; }

    public string? DsIndiceCorrecao { get; set; }

    public short? IdCondicaoPgto { get; set; }

    public short? IdPrazoEntrega { get; set; }

    public string? FlVencedorPorMaiorDesconto { get; set; }

    public short? NrPesoPreco { get; set; }

    public short? NrPesoTecnica { get; set; }

    public string? DsControleSaldo { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }

    public string? DsOrigemSaldo { get; set; }

    public string? NrEditalOrigem { get; set; }

    public short? IdSetorCompra { get; set; }

    public int? IdLicitacaoOrigem { get; set; }

    public int? IdProcesso { get; set; }

    public short? NrAnoEditalOrigem { get; set; }

    public string? FlProrrogacao { get; set; }
}
