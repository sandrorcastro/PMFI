using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class GccMovtoOcor
    {
        public string MovtoCnpjmembro { get; set; } = null!;
        public long MovtoId { get; set; }
        public int? MovtoCreId { get; set; }
        public long? MovtoCriId { get; set; }
        public int? MovtoTocorId { get; set; }
        public DateTime? MovtoData { get; set; }
        public string? MovtoDescr { get; set; }

        public virtual GccTipoOcor? Movto { get; set; }
        public virtual GccCriCreche? MovtoC { get; set; }
    }
}
