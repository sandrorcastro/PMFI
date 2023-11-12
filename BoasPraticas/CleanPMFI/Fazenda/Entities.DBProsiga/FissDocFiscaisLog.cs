using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class FissDocFiscaisLog
{
    public long Idlog { get; set; }

    public long DocFisId { get; set; }

    public int? SerieId { get; set; }

    public int? ModNotaId { get; set; }

    public DateTime? DocFisDataPgto { get; set; }

    public DateTime? DocFisData { get; set; }

    public long? DocFisNumero { get; set; }

    public int? SitRecId { get; set; }

    public decimal? DocFisValorTotNf { get; set; }

    public decimal? DocFisValorSerNf { get; set; }

    public decimal? DocFisValorImpNf { get; set; }

    public decimal? DocFisAliquotaImpNf { get; set; }

    public long? EmprCmc { get; set; }

    public int? TipoDocId { get; set; }

    public long? MovId { get; set; }

    public long? NatOpId { get; set; }

    public string? DocFisImport { get; set; }

    public DateTime DataInclusao { get; set; }

    public string? UsuarioInclusao { get; set; }

    public long? ConId { get; set; }

    public long? Teste { get; set; }
}
