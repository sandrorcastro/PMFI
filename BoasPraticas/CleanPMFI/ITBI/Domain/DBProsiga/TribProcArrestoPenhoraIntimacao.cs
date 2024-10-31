using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribProcArrestoPenhoraIntimacao
    {
        public long ProcIntArrId { get; set; }
        public long? ProcArrId { get; set; }
        public string? ProcIntPenhoraArresto { get; set; }
        public string? ProcIntForma { get; set; }
        public DateTime? ProcIntDataCitacao { get; set; }
        public string? ProcIntMotivo { get; set; }
        public string? ProcIntPeticao { get; set; }
        public DateTime? ProcIntData { get; set; }
        public string? ProcIntTermo { get; set; }
        public string? ProcIntDeposito { get; set; }
        public decimal? ProcIntVlrAvaliacao { get; set; }
        public DateTime? ProcIntDtAvaliacao { get; set; }
        public decimal? ProcIntVlrImpugnacao { get; set; }
        public DateTime? ProcIntDtImpugnacao { get; set; }
        public decimal? ProcIntVlrLaudo { get; set; }
        public DateTime? ProcIntDtLaudo { get; set; }
        public decimal? ProcIntVlrDefinitiva { get; set; }
        public DateTime? ProcIntDtDefinitiva { get; set; }

        public virtual TribProcArrestoPenhora? ProcArr { get; set; }
    }
}
