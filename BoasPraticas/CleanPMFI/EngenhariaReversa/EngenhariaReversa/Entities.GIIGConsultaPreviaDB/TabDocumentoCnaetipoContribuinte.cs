using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGConsultaPreviaDB
{
    public partial class TabDocumentoCnaetipoContribuinte
    {
        public int IdDocCnaeTipoContrib { get; set; }
        public short? IdTipoContribuinte { get; set; }
        public string? SubCid { get; set; }
        public int? DocuId { get; set; }

        public virtual TabDocumento? Docu { get; set; }
    }
}
