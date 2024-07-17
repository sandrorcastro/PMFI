using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class TabAnexo
    {
        public int AnexId { get; set; }
        public long? MoviId { get; set; }
        public byte[]? AnexObjeto { get; set; }
        public string? AnexDescricao { get; set; }
        public string? AnexContentType { get; set; }
        public short? AnexNumeroFolhas { get; set; }
        public int? TipoDocId { get; set; }
        public string? AnexArquivo { get; set; }
        public DateTime? AnexData { get; set; }
        public string? AnexPublico { get; set; }
        public string? DsLogin { get; set; }
        public string AnexFlAtivo { get; set; } = null!;

        public virtual TabMovimento? Movi { get; set; }
        public virtual TabDocumentoTipo? TipoDoc { get; set; }
    }
}
