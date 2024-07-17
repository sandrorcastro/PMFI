using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbCntTiposMotivoRescisaoContrato
    {
        public TbCntTiposMotivoRescisaoContrato()
        {
            TbCntAtosContratuais = new HashSet<TbCntAtosContratuai>();
        }

        public short IdTipoMotivoRescisao { get; set; }
        public string? DsTipoMotivoRescisao { get; set; }

        public virtual ICollection<TbCntAtosContratuai> TbCntAtosContratuais { get; set; }
    }
}
