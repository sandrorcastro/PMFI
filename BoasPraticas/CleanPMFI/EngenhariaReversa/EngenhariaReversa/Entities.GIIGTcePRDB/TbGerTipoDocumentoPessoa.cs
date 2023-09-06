using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGTcePRDB
{
    public partial class TbGerTipoDocumentoPessoa
    {
        public short IdTipoDocumento { get; set; }
        public string? SgTipoDocumento { get; set; }
        public string? DsTipoDocumento { get; set; }
        public string? FlExigeUf { get; set; }
        public string? FlExigeValidade { get; set; }
    }
}
