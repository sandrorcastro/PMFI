using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribAlvDividum
    {
        public int IdDocumento { get; set; }
        public long ConIdDivida { get; set; }
        public string? DsTipoDivida { get; set; }

        public virtual TribDividasContribuinte ConIdDividaNavigation { get; set; } = null!;
        public virtual TribAlvDocumento IdDocumentoNavigation { get; set; } = null!;
    }
}
