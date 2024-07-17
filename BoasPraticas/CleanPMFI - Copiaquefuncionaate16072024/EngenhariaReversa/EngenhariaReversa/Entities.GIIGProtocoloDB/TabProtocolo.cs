using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class TabProtocolo
    {
        public long ProtId { get; set; }
        public short? ProtAno { get; set; }
        public int? ProtSequencia { get; set; }
        public int? TipoDocId { get; set; }
        public string? ProtTipoDocumento { get; set; }
        public short? ProtNumeroFolhas { get; set; }
        public string? ProtComentario { get; set; }
        public byte[]? ProtDocumento { get; set; }
        public string? ProtContentType { get; set; }
        public DateTime? ProtData { get; set; }
        public int? PessId { get; set; }
        public long? MoviId { get; set; }
        public long? BarrId { get; set; }

        public virtual TabMovimento? Movi { get; set; }
        public virtual TabPessoa? Pess { get; set; }
        public virtual TabDocumentoTipo? TipoDoc { get; set; }
    }
}
