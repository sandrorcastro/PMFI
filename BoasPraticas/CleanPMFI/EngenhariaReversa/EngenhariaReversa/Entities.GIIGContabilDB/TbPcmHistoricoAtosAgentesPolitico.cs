using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPcmHistoricoAtosAgentesPolitico
    {
        public int IdAto { get; set; }
        public string CdCargo { get; set; } = null!;
        public int? TpEspecieAto { get; set; }
        public short? NrMes { get; set; }
        public decimal? VlPercReajuste { get; set; }
        public decimal? VlAto { get; set; }

        public virtual TbPcmAtosAgentesPolitico IdAtoNavigation { get; set; } = null!;
    }
}
