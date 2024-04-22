using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class FissTomadorPrestador
    {
        public long ToPrId { get; set; }
        public long? DocFisId { get; set; }
        public int? TipoOpId { get; set; }
        public long? ConId { get; set; }
        public long? EmprCmc { get; set; }

        public virtual Contribuinte? Con { get; set; }
        public virtual FissDocFiscai? DocFis { get; set; }
        public virtual TribEmpresa? EmprCmcNavigation { get; set; }
        public virtual FissTipoOperacao? TipoOp { get; set; }
    }
}
