using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class FissDocFiscai
{
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

    public virtual TribEmpresa? EmprCmcNavigation { get; set; }

    public virtual ICollection<FissComprovanteIten> FissComprovanteItens { get; set; } = new List<FissComprovanteIten>();

    public virtual ICollection<FissDocFiscaisDividum> FissDocFiscaisDivida { get; set; } = new List<FissDocFiscaisDividum>();

    public virtual ICollection<FissTomadorPrestador> FissTomadorPrestadors { get; set; } = new List<FissTomadorPrestador>();

    public virtual FissModeloNotum? ModNota { get; set; }

    public virtual FissMovim? Mov { get; set; }

    public virtual FissNaturezaOperacao? NatOp { get; set; }

    public virtual FissSerieNotasFiscai? Serie { get; set; }

    public virtual FissSituacaoRec? SitRec { get; set; }

    public virtual FissTipoDocumento? TipoDoc { get; set; }
}
