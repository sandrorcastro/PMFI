using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class VisaoBoleto
    {
        public long LcId { get; set; }
        public int? ContrId { get; set; }
        public string? NmContr { get; set; }
        public int? TaxaId { get; set; }
        public string? TaxNm { get; set; }
        public int SubLocId { get; set; }
        public DateTime? DtIni { get; set; }
        public DateTime? DtFim { get; set; }
        public string? HorIni { get; set; }
        public string? HorFim { get; set; }
        public decimal? VlrLoc { get; set; }
        public string? Categ { get; set; }
        public int? TpPagto { get; set; }
        public string? Situacao { get; set; }
        public string NossoNum { get; set; } = null!;
        public decimal? BolVlrDiv { get; set; }
        public string? ConRespRg { get; set; }
        public string? ConRespNome { get; set; }
        public DateTime? ConDtNasc { get; set; }
        public int TipoSubLocId { get; set; }
        public string? TsnmTipo { get; set; }
    }
}
