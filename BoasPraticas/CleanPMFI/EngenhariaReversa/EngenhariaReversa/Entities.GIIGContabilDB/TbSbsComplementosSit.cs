using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbSbsComplementosSit
    {
        public TbSbsComplementosSit()
        {
            IdSubVencaoSocials = new HashSet<TbSbsSubvencaoSocialCompl>();
        }

        public int CdTabelaSit { get; set; }
        public string CdCampoSit { get; set; } = null!;
        public string? DsTabelaSit { get; set; }
        public string? DsCampoSit { get; set; }

        public virtual ICollection<TbSbsSubvencaoSocialCompl> IdSubVencaoSocials { get; set; }
    }
}
