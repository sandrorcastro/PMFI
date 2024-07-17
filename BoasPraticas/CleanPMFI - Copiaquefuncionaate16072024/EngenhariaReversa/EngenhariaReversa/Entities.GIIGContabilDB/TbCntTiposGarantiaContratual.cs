using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbCntTiposGarantiaContratual
    {
        public TbCntTiposGarantiaContratual()
        {
            TbCntContratos = new HashSet<TbCntContrato>();
        }

        public short IdTipoGarantia { get; set; }
        public string? NmTipoGarantia { get; set; }
        public string? DsSigla { get; set; }
        public short? CdTc { get; set; }
        public bool? FlAtivo { get; set; }
        public bool? FlUsaDetalhes { get; set; }

        public virtual ICollection<TbCntContrato> TbCntContratos { get; set; }
    }
}
