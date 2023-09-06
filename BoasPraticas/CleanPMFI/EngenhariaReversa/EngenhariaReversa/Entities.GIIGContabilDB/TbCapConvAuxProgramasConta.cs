using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbCapConvAuxProgramasConta
    {
        public int IdCapContas { get; set; }
        public int? IdRecurso { get; set; }
        public string? CdReceitaCorrente { get; set; }
        public string? CdReceitaCapital { get; set; }
        public string? CdContabilDivFlutuante { get; set; }
        public DateTime? DtPeriodoIni { get; set; }
        public DateTime? DtPeriodoFim { get; set; }

        public virtual TbCapConvAuxPrograma? IdRecursoNavigation { get; set; }
    }
}
