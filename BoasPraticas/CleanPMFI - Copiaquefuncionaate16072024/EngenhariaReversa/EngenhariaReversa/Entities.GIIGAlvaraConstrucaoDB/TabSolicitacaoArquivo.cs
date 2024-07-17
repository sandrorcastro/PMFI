using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGAlvaraConstrucaoDB
{
    public partial class TabSolicitacaoArquivo
    {
        public int SoliId { get; set; }
        public byte[] SoarArquivo { get; set; } = null!;

        public virtual TabSolicitaco Soli { get; set; } = null!;
    }
}
