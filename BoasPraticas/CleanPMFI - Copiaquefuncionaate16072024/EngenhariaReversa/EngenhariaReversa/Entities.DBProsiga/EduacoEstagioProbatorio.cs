using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class EduacoEstagioProbatorio
    {
        public long AcoEstagId { get; set; }
        public DateTime? AcoEstagData { get; set; }
        public string? AcoEstagAvaliacao { get; set; }
        public string? AcoEstagNumProc { get; set; }
        public long? DadFid { get; set; }

        public virtual RhdadosFuncionai? DadF { get; set; }
    }
}
