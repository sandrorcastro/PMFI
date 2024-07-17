using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGConsultaPreviaDB
{
    public partial class TabConsultaDocumentoPergunta
    {
        public int Idtabela { get; set; }
        public int ConsId { get; set; }
        public int DocuId { get; set; }
        public string? Dspergunta { get; set; }
        public string? Dsresposta { get; set; }
    }
}
