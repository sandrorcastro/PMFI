using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGConsultaPreviaDB
{
    public partial class TabConsultaDocumento
    {
        public int ConsId { get; set; }
        public int DocuId { get; set; }
        public string? CodoStatus { get; set; }
        public string? CodoObs { get; set; }
        public DateTime? CodoDataEntrega { get; set; }

        public virtual TabConsultum Cons { get; set; } = null!;
        public virtual TabDocumento Docu { get; set; } = null!;
    }
}
