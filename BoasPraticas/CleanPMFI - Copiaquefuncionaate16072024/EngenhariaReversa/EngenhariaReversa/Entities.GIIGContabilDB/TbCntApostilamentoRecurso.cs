using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbCntApostilamentoRecurso
    {
        public int IdAtoContratual { get; set; }
        public int IdRecurso { get; set; }
        public decimal? VlRecurso { get; set; }

        public virtual TbCntAtosContratuai IdAtoContratualNavigation { get; set; } = null!;
        public virtual TbCapRecurso IdRecursoNavigation { get; set; } = null!;
    }
}
