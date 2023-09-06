using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbSbsCronogramaDesembolso
    {
        public int IdCronogDesenbolso { get; set; }
        public int? IdEmpresa { get; set; }
        public int? IdSubvencaoSocial { get; set; }
        public int? IdNatDespesa { get; set; }
        public DateTime? DtDesembolso { get; set; }
        public decimal? VlDesembolso { get; set; }
        public decimal? VlAporte { get; set; }
        public short? NrMesReferencia { get; set; }
        public short? NrAnoReferencia { get; set; }

        public virtual TbSbsSubvencaoSocial? IdSubvencaoSocialNavigation { get; set; }
    }
}
