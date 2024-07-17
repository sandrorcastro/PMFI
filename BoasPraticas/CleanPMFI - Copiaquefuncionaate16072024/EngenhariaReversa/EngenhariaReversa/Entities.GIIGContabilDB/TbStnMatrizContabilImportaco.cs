using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbStnMatrizContabilImportaco
    {
        public int IdLancamento { get; set; }
        public short? NrMes { get; set; }
        public short? NrAno { get; set; }
        public string? CdContaContabil { get; set; }
        public string? DsIc1 { get; set; }
        public string? DsTipoIc1 { get; set; }
        public string? DsIc2 { get; set; }
        public string? DsTipoIc2 { get; set; }
        public string? DsIc3 { get; set; }
        public string? DsTipoIc3 { get; set; }
        public string? DsIc4 { get; set; }
        public string? DsTipoIc4 { get; set; }
        public string? DsIc5 { get; set; }
        public string? DsTipoIc5 { get; set; }
        public string? DsIc6 { get; set; }
        public string? DsTipoIc6 { get; set; }
        public string? DsIc7 { get; set; }
        public string? DsTipoIc7 { get; set; }
        public decimal? VlLancamento { get; set; }
        public string? DsTipoValor { get; set; }
        public string? TpNaturezaValor { get; set; }
    }
}
