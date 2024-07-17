using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbDspDiaria
    {
        public int IdDiaria { get; set; }
        public int? IdEmpenho { get; set; }
        public int? IdLiquidacao { get; set; }
        public int? IdLeiAtoAutorizacao { get; set; }
        public int? NrLei { get; set; }
        public short? NrAnoLei { get; set; }
        public DateTime? DtPublicacaoLei { get; set; }
        public int? IdLeiAtoConcessao { get; set; }
        public string? NrAto { get; set; }
        public short? NrAnoAto { get; set; }
        public DateTime? DtInicio { get; set; }
        public DateTime? DtFim { get; set; }
        public decimal? NrDiarias { get; set; }
        public decimal? VlUnitario { get; set; }
        public decimal? VlTotal { get; set; }
        public string? DsDestino { get; set; }
        public int? IdcidadeDestino { get; set; }
        public short? IdTipoObjetivoDiaria { get; set; }
        public string? DsObjetivo { get; set; }
        public string? DsTipoLocomocao { get; set; }
        public string? DsCargoBeneficiario { get; set; }
        public decimal? NrPassagem { get; set; }
        public decimal? VlUnitarioPassagem { get; set; }
        public decimal? VlTotalPassagem { get; set; }
        public decimal? NrHospedagem { get; set; }
        public decimal? VlUnitarioHospedagem { get; set; }
        public decimal? VlTotalHospedagem { get; set; }
        public decimal? VlInscricaoEvento { get; set; }

        public virtual TbDspEmpenho? IdEmpenhoNavigation { get; set; }
        public virtual TbDspTiposObjetivoDiarium? IdTipoObjetivoDiariaNavigation { get; set; }
        public virtual TbGerCidade? IdcidadeDestinoNavigation { get; set; }
    }
}
