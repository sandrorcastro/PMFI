using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribEditalComprasContribuinte
    {
        public long ConId { get; set; }
        public long EdiId { get; set; }
        public long? ConIddivida { get; set; }

        public virtual Contribuinte Con { get; set; } = null!;
        public virtual TribDividasContribuinte? ConIddividaNavigation { get; set; }
        public virtual TribEditalCompra Edi { get; set; } = null!;
    }
}
