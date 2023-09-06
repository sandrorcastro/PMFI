using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbDspEstornosDespesaExtraOrcamentarium
    {
        public int IdEstorno { get; set; }
        public int IdDespesa { get; set; }
        public short? IdEmpresa { get; set; }
        public short? NrAno { get; set; }
        public short? NrSequencia { get; set; }
        public short? NrSequenciaAnual { get; set; }
        public DateTime? DtEstorno { get; set; }
        public decimal? VlEstorno { get; set; }
        public string? DsMotivo { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }

        public virtual TbDspDespesaExtraOrcamentarium IdDespesaNavigation { get; set; } = null!;
    }
}
