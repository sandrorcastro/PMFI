using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbCntTiposOrigemContrato
    {
        public TbCntTiposOrigemContrato()
        {
            TbCntContratos = new HashSet<TbCntContrato>();
        }

        public short IdTipoOrigemContrato { get; set; }
        public string? DsTipoOrigemContrato { get; set; }

        public virtual ICollection<TbCntContrato> TbCntContratos { get; set; }
    }
}
