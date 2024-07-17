using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribComposicaoDivContribuinte
    {
        public long ConIddivida { get; set; }
        public int TipoTribId { get; set; }
        public decimal? CompDivConValor { get; set; }

        public virtual TribDividasContribuinte ConIddividaNavigation { get; set; } = null!;
        public virtual TribTipoTributo TipoTrib { get; set; } = null!;
    }
}
