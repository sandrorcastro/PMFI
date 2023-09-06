using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TempTbFinLancamentosPartidaDobrada
    {
        public int IdLancamento { get; set; }
        public string TpLancamento { get; set; } = null!;
        public int IdContaContabil { get; set; }
        public short? IdTipoMovimento { get; set; }
        public short? IdTipoFinanceiroPatrimonial { get; set; }
        public short? IdTipoVariacao { get; set; }
        public int? NrSequenciaAnual { get; set; }
    }
}
