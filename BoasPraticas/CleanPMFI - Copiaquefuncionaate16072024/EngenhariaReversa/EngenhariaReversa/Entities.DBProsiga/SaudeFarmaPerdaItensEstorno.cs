using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class SaudeFarmaPerdaItensEstorno
    {
        public long IdPerdaItemEst { get; set; }
        public long? IdPerda { get; set; }
        public long? IdEstoque { get; set; }
        public string? IdentLote { get; set; }
        public long? IdMedicamento { get; set; }
        public long? IdFabricante { get; set; }
        public long? Qtd { get; set; }
        public long? SaldoLote { get; set; }
        public long? SaldoMedicamento { get; set; }
        public DateTime? DtMovimento { get; set; }
        public string? Hrmovimento { get; set; }
        public string? Usuario { get; set; }

        public virtual SaudeFarmaPerda? IdPerdaNavigation { get; set; }
    }
}
