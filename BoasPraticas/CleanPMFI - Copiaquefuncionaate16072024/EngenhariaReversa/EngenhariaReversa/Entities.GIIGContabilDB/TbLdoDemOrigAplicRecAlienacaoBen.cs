using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbLdoDemOrigAplicRecAlienacaoBen
    {
        public int IdAplicacao { get; set; }
        public int? IdEmpresa { get; set; }
        public short? NrAnoLdo { get; set; }
        public short? NrAnoReferencia { get; set; }
        public decimal? VlRecAlienBensMoveis { get; set; }
        public decimal? VlRecAlienBensImoveis { get; set; }
        public decimal? VlDespInvestimetos { get; set; }
        public decimal? VlDespInversoesFinanceiras { get; set; }
        public decimal? VlDespAmortizacaoDivida { get; set; }
        public decimal? VlDespRegProprioPrev { get; set; }
    }
}
