using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbCntTiposMultasContrato
    {
        public TbCntTiposMultasContrato()
        {
            TbCntContratos = new HashSet<TbCntContrato>();
        }

        public short IdTipoMultaContrato { get; set; }
        public string? DsTipoMultaContrato { get; set; }
        public bool? FlUsaDetalhes { get; set; }

        public virtual ICollection<TbCntContrato> TbCntContratos { get; set; }
    }
}
