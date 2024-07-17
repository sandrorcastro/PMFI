using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbDspDocumento
    {
        public TbDspDocumento()
        {
            TbDspDocumentosTransacos = new HashSet<TbDspDocumentosTransaco>();
        }

        public int IdDocumento { get; set; }
        public string? DsDocumento { get; set; }
        public byte[]? BnDocumento { get; set; }
        public string? DsExtensao { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }

        public virtual ICollection<TbDspDocumentosTransaco> TbDspDocumentosTransacos { get; set; }
    }
}
