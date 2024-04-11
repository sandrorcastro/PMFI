using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class VwCotacaoItensVencedore
{
    public int IdLicitacao { get; set; }

    public string? Cnpjempresa { get; set; }

    public short? IdModalidade { get; set; }

    public string? NumLicitacao { get; set; }

    public string? NrCnpjcpf { get; set; }

    public int? NrLote { get; set; }

    public int? IdItem { get; set; }

    public string? FlCotacao { get; set; }

    public decimal? NrQuantidade { get; set; }

    public decimal? VlUnitario { get; set; }

    public decimal? VlTotal { get; set; }

    public string? DsDetalhamento { get; set; }

    public DateTime? DtCotacao { get; set; }

    public DateTime? DtPrazoEntrega { get; set; }

    public DateTime? DtVencimentoProposta { get; set; }

    public string? FlVencedor { get; set; }

    public short? NrClassificacao { get; set; }

    public decimal? VlTotalNegociado { get; set; }

    public string? DsMarca { get; set; }

    public string? DsPrazoEntrega { get; set; }

    public string? DsCondicaoPgto { get; set; }
}
