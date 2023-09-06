using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbOrcTipoCreditoInicial
    {
        public TbOrcTipoCreditoInicial()
        {
            TbOrcDotacos = new HashSet<TbOrcDotaco>();
        }

        public short IdTipoCreditoInicial { get; set; }
        public string? DsTipoCreditoInicial { get; set; }

        public virtual ICollection<TbOrcDotaco> TbOrcDotacos { get; set; }
    }
}
