using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbCapRecursosSaldosAnteriore
    {
        public int IdRecurso { get; set; }
        public short NrAno { get; set; }
        public decimal? VlSaldoAnterior { get; set; }

        public virtual TbCapRecurso IdRecursoNavigation { get; set; } = null!;
    }
}
