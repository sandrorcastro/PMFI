using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribComposicaoDivImo
    {
        public long ImoIddivida { get; set; }
        public int TipoTribId { get; set; }
        public decimal? CompDivImoValor { get; set; }

        public virtual TribDividasImo ImoIddividaNavigation { get; set; } = null!;
        public virtual TribTipoTributo TipoTrib { get; set; } = null!;
    }
}
