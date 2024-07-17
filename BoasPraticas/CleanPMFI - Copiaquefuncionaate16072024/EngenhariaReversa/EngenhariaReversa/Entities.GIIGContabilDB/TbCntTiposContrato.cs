using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbCntTiposContrato
    {
        public TbCntTiposContrato()
        {
            TbCntContratos = new HashSet<TbCntContrato>();
        }

        public short IdTipoContrato { get; set; }
        public string? DsTipoContrato { get; set; }
        public short? IdModelo { get; set; }
        public bool? FlUsaAta { get; set; }

        public virtual TbLicModelosDocto? IdModeloNavigation { get; set; }
        public virtual ICollection<TbCntContrato> TbCntContratos { get; set; }
    }
}
