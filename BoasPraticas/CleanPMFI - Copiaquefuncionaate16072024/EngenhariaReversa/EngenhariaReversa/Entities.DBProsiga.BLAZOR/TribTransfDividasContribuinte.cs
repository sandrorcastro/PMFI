using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribTransfDividasContribuinte
    {
        public int IdTransfDividasContribuintes { get; set; }
        public int TransfId { get; set; }
        public long ConId { get; set; }
        public string? NrCnpj { get; set; }
        public string? NmContribuinte { get; set; }

        public virtual Contribuinte Con { get; set; } = null!;
        public virtual TribTransfDivida Transf { get; set; } = null!;
    }
}
