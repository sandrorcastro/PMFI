using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblDeclaracaoAuto
    {
        public int Idlogdecauto { get; set; }
        public int? Iddeclaracao { get; set; }
        public int? Idencerramento { get; set; }
        public int Idempresa { get; set; }

        public virtual NfseTblContum? IddeclaracaoNavigation { get; set; }
        public virtual NfseTblEmpresa IdempresaNavigation { get; set; } = null!;
        public virtual NfseTblEncerramento? IdencerramentoNavigation { get; set; }
        public virtual NfseTblLogDeclaracaoAuto IdlogdecautoNavigation { get; set; } = null!;
    }
}
