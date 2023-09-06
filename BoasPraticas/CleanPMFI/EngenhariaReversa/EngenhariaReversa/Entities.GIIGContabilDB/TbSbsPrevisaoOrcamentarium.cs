using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbSbsPrevisaoOrcamentarium
    {
        public int IdPrevisao { get; set; }
        public int? IdSubVencaoSocial { get; set; }
        public int? IdDotacao { get; set; }

        public virtual TbSbsSubvencaoSocial? IdSubVencaoSocialNavigation { get; set; }
    }
}
