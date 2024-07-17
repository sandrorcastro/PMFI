using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbAmmLeisOrcamentariasIndireta
    {
        public int IdAto { get; set; }
        public short? IdEmpresa { get; set; }
        public string? TpAto { get; set; }
        public int? NrAto { get; set; }
        public short? NrAnoAto { get; set; }
        public DateTime? DtAto { get; set; }
        public DateTime? DtPublicacao { get; set; }
        public int? NrLei { get; set; }
        public short? NrAnoLei { get; set; }
        public DateTime? DtLei { get; set; }
        public decimal? VlReceitas { get; set; }
        public decimal? VlDespesas { get; set; }
        public decimal? VlIngressosInterf { get; set; }
        public decimal? VlEgressosInterf { get; set; }
        public decimal? VlLimiteCreditoAdicional { get; set; }
    }
}
