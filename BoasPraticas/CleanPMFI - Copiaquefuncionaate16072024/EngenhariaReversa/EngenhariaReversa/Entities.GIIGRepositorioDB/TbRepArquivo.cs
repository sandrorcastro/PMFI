using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGRepositorioDB
{
    public partial class TbRepArquivo
    {
        public long IdArquivo { get; set; }
        public byte[]? BnArquivo { get; set; }
        public string? NmArquivo { get; set; }
        public string? DsExtensao { get; set; }
    }
}
