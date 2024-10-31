using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribCertidaoDadivida
    {
        public long CertidaoDaidDivida { get; set; }
        public long CertidaoDaid { get; set; }
        /// <summary>
        /// Numero do lançamento da divida em da
        /// </summary>
        public long LivroDaid { get; set; }
        public int? TipoTribId { get; set; }
        public string? TipoTribNome { get; set; }
        public short? NrAno { get; set; }
        public short? NrMes { get; set; }
        public short? NrParcela { get; set; }
        public DateTime? DtVencimento { get; set; }
        public decimal? VlPrincipal { get; set; }
        public decimal? VlCorrecao { get; set; }
        public decimal? VlMulta { get; set; }
        public decimal? VlJuros { get; set; }
        public decimal? VlMda { get; set; }
        public decimal? VlTotal { get; set; }
        public int? TipoBxId { get; set; }
        public string? TipoBxNome { get; set; }
        public long? IdVersao { get; set; }
    }
}
