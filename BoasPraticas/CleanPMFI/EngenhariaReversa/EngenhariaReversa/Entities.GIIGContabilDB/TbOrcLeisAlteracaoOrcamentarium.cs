using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbOrcLeisAlteracaoOrcamentarium
    {
        public short IdLei { get; set; }
        public short? IdEmpresa { get; set; }
        public int? IdLeiAto { get; set; }
        public short? NrAno { get; set; }
        public int? NrLei { get; set; }
        public DateTime? DtLei { get; set; }
        public DateTime? DtPublicacaoLei { get; set; }
        public short? IdEmpresaExecutor { get; set; }
        public decimal? VlCreditoSuplementar { get; set; }
        public decimal? VlCreditoEspecial { get; set; }
        public decimal? VlCreditoExtraordinario { get; set; }
        public decimal? VlSuperavitFinanceiro { get; set; }
        public decimal? VlSuperavitRecVinculado { get; set; }
        public decimal? VlExcessoArrecadacao { get; set; }
        public decimal? VlExcessoRecVinculado { get; set; }
        public decimal? VlAnulacao { get; set; }
        public decimal? VlOperacoesCredito { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }
        public string? DsMensagem { get; set; }
    }
}
