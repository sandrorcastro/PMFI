using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPpaPublicosAlvo
    {
        public TbPpaPublicosAlvo()
        {
            TbPpaIndicadores = new HashSet<TbPpaIndicadore>();
        }

        public int IdPublicoAlvo { get; set; }
        public string? DsPublicoAlvo { get; set; }

        public virtual ICollection<TbPpaIndicadore> TbPpaIndicadores { get; set; }
    }
}
