using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbLdoDemExpansaoDespContinuada
    {
        public int IdExpContinuada { get; set; }
        public int? IdVersao { get; set; }
        public short? NrAnoLdo { get; set; }
        public decimal? VlTransfFundeb { get; set; }
        public decimal? VlRedPermDespesa { get; set; }
        public decimal? VlNovasDocc { get; set; }
        public decimal? VlNovasDocGeradasPpp { get; set; }
        public decimal? VlAumentoReceita { get; set; }
        public decimal? VlTransfConstitucionais { get; set; }
    }
}
