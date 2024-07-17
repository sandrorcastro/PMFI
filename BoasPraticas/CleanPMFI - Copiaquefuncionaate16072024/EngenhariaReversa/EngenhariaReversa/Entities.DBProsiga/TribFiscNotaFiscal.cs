using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribFiscNotaFiscal
    {
        public long Nfid { get; set; }
        public long? Nfnumero { get; set; }
        public DateTime? Nfdata { get; set; }
        public DateTime? NfdataPgto { get; set; }
        public int? SerieId { get; set; }
        public int? ModNotaId { get; set; }
        public int? SitRecId { get; set; }
        public int? TipoDocId { get; set; }
        public long? NatOpId { get; set; }
        public int? TipoOpId { get; set; }
        public short? TipoNfid { get; set; }
        public decimal? NfvalorTotNf { get; set; }
        public decimal? NfvalorSerNf { get; set; }
        public decimal? NfvalorImpNf { get; set; }
        public decimal? NfaliquotaImpNf { get; set; }
        public long? ConId { get; set; }
        public long? Nfidorigem { get; set; }
        public string? Nfsistema { get; set; }
        public decimal? NfaliquotaConfer { get; set; }
        public decimal? NfvalorImpConfer { get; set; }
        public string? Nfobs { get; set; }
        public string? ServId { get; set; }
        public decimal? NfvalorDevido { get; set; }
        public decimal? NfaliquotaDevida { get; set; }
        public short? TipoLancId { get; set; }
        public decimal? NfvalorTotNfdevido { get; set; }
    }
}
