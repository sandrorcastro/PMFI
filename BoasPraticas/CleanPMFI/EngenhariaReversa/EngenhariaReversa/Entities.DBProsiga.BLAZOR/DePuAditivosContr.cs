using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class DePuAditivosContr
    {
        public long AditIdaditivo { get; set; }
        public string? AditNumero { get; set; }
        public DateTime? AditData { get; set; }
        public DateTime? AditVencimento { get; set; }
        public decimal? AditValor { get; set; }
        public string? AditHistDescr { get; set; }
        public long? AditIdContrato { get; set; }

        public virtual DepuContrato? AditIdContratoNavigation { get; set; }
    }
}
