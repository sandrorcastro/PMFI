using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGConsultaPreviaDB
{
    public partial class TabDocumentoCnae
    {
        public string SubCid { get; set; } = null!;
        public int DocuId { get; set; }
        public string? DosuObs { get; set; }
        public string? DosuTipo { get; set; }

        public virtual TabDocumento Docu { get; set; } = null!;
    }
}
