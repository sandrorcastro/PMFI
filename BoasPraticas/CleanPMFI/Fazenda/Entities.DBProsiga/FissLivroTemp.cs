using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class FissLivroTemp
{
    public string? SessionId { get; set; }

    public long? EmprCmc { get; set; }

    public long? DocFisId { get; set; }

    public long? DocFisNumero { get; set; }

    public DateTime? DocFisData { get; set; }

    public string? TipoOpEr { get; set; }

    public string? TipoOpCe { get; set; }

    public string? SerieNome { get; set; }

    public string? ModNota { get; set; }

    public string? SitRecNome { get; set; }

    public string? NatOpDescricao { get; set; }

    public long? CompId { get; set; }

    public decimal? DocFisValorTotNf { get; set; }

    public decimal? DocFisValorSerNf { get; set; }

    public decimal? DocFisValorImpNf { get; set; }

    public decimal? DocFisAliquotaImpNf { get; set; }

    public string? TomadorPrestador { get; set; }

    public short? Mes { get; set; }

    public string? CompSituacao { get; set; }

    public int? TipoOpId { get; set; }

    public long? SemMovId { get; set; }

    public int? SemMovAnoComp { get; set; }

    public int? SemMovMesComp { get; set; }

    public string? SemMovSituacao { get; set; }

    public long? NatOpId { get; set; }

    public int? SitRecId { get; set; }
}
