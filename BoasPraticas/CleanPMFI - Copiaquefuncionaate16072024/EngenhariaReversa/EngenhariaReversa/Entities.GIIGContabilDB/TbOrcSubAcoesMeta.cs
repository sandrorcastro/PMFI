using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbOrcSubAcoesMeta
    {
        public int IdSubAcaoMeta { get; set; }
        public int? IdAcao { get; set; }
        public int? IdSubAcao { get; set; }
        public short? IdUnidadeMedida { get; set; }
        public short? NrAno { get; set; }
        public short? NrPeriodo { get; set; }
        public string? FlPeriodo { get; set; }
        public string? DsTipoMeta { get; set; }
        public decimal? VlOrcado { get; set; }
        public decimal? VlRealizado { get; set; }
        public string? DsJustificativa { get; set; }
        public string? DsLogin { get; set; }
        public DateTime? DtInclusao { get; set; }

        public virtual TbOrcSubAcoesTarefa? IdSubAcaoNavigation { get; set; }
    }
}
