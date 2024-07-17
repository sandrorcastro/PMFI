using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribFiscAutoInfracoesItensVistorium
    {
        public int AutoId { get; set; }
        public int ItemVistId { get; set; }
        public string? AutoItemVistObs { get; set; }
        public long? ImoIddivida { get; set; }
        public long? DivEmpId { get; set; }
        public long? ConIddivida { get; set; }

        public virtual TribFiscAutoInfraco Auto { get; set; } = null!;
        public virtual TribFiscItensVistorium ItemVist { get; set; } = null!;
    }
}
