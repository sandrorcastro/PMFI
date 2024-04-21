using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribEdifInstSanitarium
    {
        public long EdificacaoId { get; set; }
        public int InstSanitId { get; set; }
        public int? EdifInstSanQtde { get; set; }

        public virtual TribEdificaco Edificacao { get; set; } = null!;
        public virtual TribInstalacaoSanitarium InstSanit { get; set; } = null!;
    }
}
