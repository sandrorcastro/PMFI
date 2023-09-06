using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbsbsSaldoBancario
    {
        public int IdSaldoBancario { get; set; }
        public int? IdSubvencaoSocial { get; set; }
        public DateTime? DtSaldoBancario { get; set; }
        public decimal? VlSaldoContaCorrente { get; set; }
        public decimal? VlSaldoContaApliccao { get; set; }

        public virtual TbSbsSubvencaoSocial? IdSubvencaoSocialNavigation { get; set; }
    }
}
