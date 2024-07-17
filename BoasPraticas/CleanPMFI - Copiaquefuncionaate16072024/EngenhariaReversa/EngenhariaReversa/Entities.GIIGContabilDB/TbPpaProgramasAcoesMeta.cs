using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPpaProgramasAcoesMeta
    {
        public int IdAcao { get; set; }
        public short NrAno { get; set; }
        public decimal? NrMetaFisica { get; set; }
        public decimal? VlEstimadoOrdinario { get; set; }
        public decimal? VlEstimadoVinculado { get; set; }
        public string? DsJustificativa { get; set; }

        public virtual TbPpaProgramasAco IdAcaoNavigation { get; set; } = null!;
    }
}
