using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblDasContum
    {
        public int Iddas { get; set; }
        public int Idconta { get; set; }

        public virtual NfseTblContum IdcontaNavigation { get; set; } = null!;
        public virtual NfseTblDa IddasNavigation { get; set; } = null!;
    }
}
