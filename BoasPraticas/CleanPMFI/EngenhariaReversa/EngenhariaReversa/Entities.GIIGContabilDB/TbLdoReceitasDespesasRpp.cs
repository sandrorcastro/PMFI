using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbLdoReceitasDespesasRpp
    {
        public int IdRecDspPrevidenciaria { get; set; }
        public int? IdEmpresa { get; set; }
        public short? NrAnoLdo { get; set; }
        public short? NrAno { get; set; }
        public decimal? VlRecSegCivil { get; set; }
        public decimal? VlRecSegMilitar { get; set; }
        public decimal? VlRecSegOutrasContrib { get; set; }
        public decimal? VlRecPatrimonial { get; set; }
        public decimal? VlRecServicos { get; set; }
        public decimal? VlRecCompPrevid { get; set; }
        public decimal? VlDemaisRecCorrentes { get; set; }
        public decimal? VlAlienacao { get; set; }
        public decimal? VlAmortizacao { get; set; }
        public decimal? VlOutrasRecCapital { get; set; }
        public decimal? VlDeducoesReceita { get; set; }
        public decimal? VlRecPatrCivil { get; set; }
        public decimal? VlRecPatrMilitar { get; set; }
        public decimal? VlRecDeficit { get; set; }
        public decimal? VlRecParc { get; set; }
        public decimal? VlRecPatrimonialIntra { get; set; }
        public decimal? VlRecServicosIntra { get; set; }
        public decimal? VlOutrasRecCorrentes { get; set; }
        public decimal? VlRecCapital { get; set; }
        public decimal? VlDeducaoReceita { get; set; }
        public decimal? VlDespCorrente { get; set; }
        public decimal? VlDespCapital { get; set; }
        public decimal? VlDespPessoalCivil { get; set; }
        public decimal? VlDespPessoalMilitar { get; set; }
        public decimal? VlDespSegCompPrevid { get; set; }
        public decimal? VlDemaisDespPrevid { get; set; }
        public decimal? VlDespCorrentes { get; set; }
        public decimal? VlDemaisDespPrevidIntra { get; set; }
        public decimal? VlAporteCobInsufic { get; set; }
        public decimal? VlAporteReserva { get; set; }
        public decimal? VlOutrosAportes { get; set; }
        public decimal? VlAporteDeficit { get; set; }
        public decimal? VlAporteDeficAtuarial { get; set; }
        public decimal? VlOutrosAportesFinanc { get; set; }
        public decimal? VlReservaRpps { get; set; }
        public decimal? VlBensDireitos { get; set; }
    }
}
