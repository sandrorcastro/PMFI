using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblMotivoCancelamento
    {
        public NfseTblMotivoCancelamento()
        {
            NfseTblPedCancelamentos = new HashSet<NfseTblPedCancelamento>();
        }

        public int Idmotcan { get; set; }
        public string Stdescricao { get; set; } = null!;
        public string Stinformanfse { get; set; } = null!;

        public virtual ICollection<NfseTblPedCancelamento> NfseTblPedCancelamentos { get; set; }
    }
}
