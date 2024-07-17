using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class FissDocFiscai
    {
        public FissDocFiscai()
        {
            FissComprovanteItens = new HashSet<FissComprovanteIten>();
            FissDocFiscaisDivida = new HashSet<FissDocFiscaisDividum>();
            FissTomadorPrestadors = new HashSet<FissTomadorPrestador>();
        }

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
        public virtual FissModeloNotum? ModNota { get; set; }
        public virtual FissMovim? Mov { get; set; }
        public virtual FissNaturezaOperacao? NatOp { get; set; }
        public virtual FissSerieNotasFiscai? Serie { get; set; }
        public virtual FissSituacaoRec? SitRec { get; set; }
        public virtual FissTipoDocumento? TipoDoc { get; set; }
        public virtual ICollection<FissComprovanteIten> FissComprovanteItens { get; set; }
        public virtual ICollection<FissDocFiscaisDividum> FissDocFiscaisDivida { get; set; }
        public virtual ICollection<FissTomadorPrestador> FissTomadorPrestadors { get; set; }
    }
}
