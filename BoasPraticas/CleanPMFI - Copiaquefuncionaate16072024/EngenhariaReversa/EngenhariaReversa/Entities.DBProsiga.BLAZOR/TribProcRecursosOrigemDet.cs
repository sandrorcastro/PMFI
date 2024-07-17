using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribProcRecursosOrigemDet
    {
        public long ProcRecOrId { get; set; }
        public long? ProcRecId { get; set; }
        public int? ProcRecOrigemId { get; set; }
        public string? ProcRecOrTribunal { get; set; }
        public string? ProcRecOrCamara { get; set; }
        public DateTime? ProcRecOrDtIntimacao { get; set; }
        public string? ProcRecOrObs { get; set; }

        public virtual TribProcRecurso? ProcRec { get; set; }
        public virtual TribProcRecursosOrigem? ProcRecOrigem { get; set; }
    }
}
