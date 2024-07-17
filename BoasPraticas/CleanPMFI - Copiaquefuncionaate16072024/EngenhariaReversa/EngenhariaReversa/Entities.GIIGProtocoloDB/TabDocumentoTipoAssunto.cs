using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class TabDocumentoTipoAssunto
    {
        public int TipoDocId { get; set; }
        public short AssuId { get; set; }
        public string? DtasTipoDocumento { get; set; }
        public string? DtasDescricao { get; set; }
        public string IsDocObrigatorio { get; set; } = null!;

        public virtual TabAssunto Assu { get; set; } = null!;
        public virtual TabDocumentoTipo TipoDoc { get; set; } = null!;
    }
}
