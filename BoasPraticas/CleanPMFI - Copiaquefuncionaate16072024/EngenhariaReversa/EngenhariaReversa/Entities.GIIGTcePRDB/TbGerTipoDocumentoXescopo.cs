using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGTcePRDB
{
    public partial class TbGerTipoDocumentoXescopo
    {
        public short IdTipoDocumento { get; set; }
        public short IdEscopo { get; set; }
        public string? DsEscopo { get; set; }

        public virtual TbGerEscopo IdEscopoNavigation { get; set; } = null!;
        public virtual TbGerTipoDocumentoLeiAto IdTipoDocumentoNavigation { get; set; } = null!;
    }
}
