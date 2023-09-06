using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbCapRecursosContasCorrente
    {
        public int IdRecurso { get; set; }
        public int IdCc { get; set; }
        public short? IdTipoInvestimento { get; set; }
        public string? CdContaContabil { get; set; }
        public string? FlPadraoPagamento { get; set; }
        public string? FlDesdobraReceita { get; set; }

        public virtual TbGerContasCorrente IdCcNavigation { get; set; } = null!;
        public virtual TbCapRecurso IdRecursoNavigation { get; set; } = null!;
        public virtual TbGerTipoInvestimento? IdTipoInvestimentoNavigation { get; set; }
    }
}
