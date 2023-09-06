using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribAlvaraConstrucaoDividasImovei
    {
        public long Numero { get; set; }
        public long ImolDdivida { get; set; }

        public virtual TribDividasImo ImolDdividaNavigation { get; set; } = null!;
    }
}
