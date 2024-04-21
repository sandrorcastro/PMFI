using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class ProSigaConsultaProcesso
    {
        public long ProcId { get; set; }
        public string? ProcSituacao { get; set; }
        public int? ProcDivTramitacao { get; set; }
        public long CargaId { get; set; }
        public DateTime? CargaData { get; set; }
        public int? CargaDivisaoIdorigem { get; set; }
        public int? CargaDivisaoId { get; set; }
        public long RecId { get; set; }
        public string RecSituacao { get; set; } = null!;
        public long? CargaServDestino { get; set; }
        public DateTime? RecData { get; set; }
    }
}
