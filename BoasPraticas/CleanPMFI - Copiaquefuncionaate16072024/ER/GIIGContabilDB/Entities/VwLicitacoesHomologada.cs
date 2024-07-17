using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class VwLicitacoesHomologada
{
    public int IdLicitacao { get; set; }

    public string? Cnpjempresa { get; set; }

    public short IdEmpresa { get; set; }

    public short? NrAno { get; set; }

    public short? IdModalidade { get; set; }

    public short? IdNaturezaProcedimento { get; set; }

    public short? NrLicitacao { get; set; }

    public DateTime? DtEdital { get; set; }

    public DateTime? DtPublicacaoDoe { get; set; }

    public DateTime? DtAbertura { get; set; }

    public string? DsHoraAbertura { get; set; }

    public DateTime? DtJulgamento { get; set; }

    public string? DsHoraJulgamento { get; set; }

    public DateTime? DtHomologacao { get; set; }

    public short? IdLocal { get; set; }

    public string? DsObjeto { get; set; }

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

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }
}
