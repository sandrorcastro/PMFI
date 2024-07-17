using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbSbsTipoEntidade
    {
        public TbSbsTipoEntidade()
        {
            TbSbsSubvencaoSocials = new HashSet<TbSbsSubvencaoSocial>();
        }

        public byte IdTpEntidade { get; set; }
        public string? DsTpEntidade { get; set; }

        public virtual ICollection<TbSbsSubvencaoSocial> TbSbsSubvencaoSocials { get; set; }
    }
}
