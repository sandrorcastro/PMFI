using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TempTbLicCotacaoIten
{
    public int IdCotacao { get; set; }

    public int IdLicitacao { get; set; }

    public int IdPessoa { get; set; }

    public int? NrLote { get; set; }

    public int? IdItem { get; set; }

    public string? FlCotacao { get; set; }

    public decimal? NrQuantidade { get; set; }

    public decimal? VlUnitario { get; set; }

    public decimal? VlTotal { get; set; }

    public string? DsDetalhamento { get; set; }

    public DateTime? DtCotacao { get; set; }

    public short? IdCondicaoPgto { get; set; }

    public short? IdPrazoEntrega { get; set; }

    public DateTime? DtPrazoEntrega { get; set; }

    public DateTime? DtVencimentoProposta { get; set; }

    public string? FlVencedor { get; set; }

    public short? NrClassificacao { get; set; }

    public decimal? VlTotalNegociado { get; set; }

    public string? DsMarca { get; set; }

    public decimal? VlDesconto { get; set; }

    public DateTime? DtUltAlteracao { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }

    public DateTime? DtHomologacao { get; set; }

    public int IdCotacaoOrigem { get; set; }
}
