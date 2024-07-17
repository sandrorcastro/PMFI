using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbOrcDotacoesBloqueiosManual
    {
        public int IdBloqueio { get; set; }
        public short? IdEmpresa { get; set; }
        public short? NrAno { get; set; }
        public DateTime? DtBloqueio { get; set; }
        public decimal? VlPercentual { get; set; }
        public string? DsHistorico { get; set; }
        public string? DsOperacao { get; set; }
        public string? DsTipo { get; set; }
        public int? IdDotacao { get; set; }
        public decimal? VlBloqueio { get; set; }
        public string? DsLogin { get; set; }
        public DateTime? DtInclusao { get; set; }
        public int? IdNatDespesa { get; set; }
        public int? IdFonte { get; set; }
        public int? IdAcao { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public string? FlBloqueiaSca { get; set; }
        public int? IdSubAcaoTarefa { get; set; }

        public virtual TbOrcDotaco? IdDotacaoNavigation { get; set; }
    }
}
