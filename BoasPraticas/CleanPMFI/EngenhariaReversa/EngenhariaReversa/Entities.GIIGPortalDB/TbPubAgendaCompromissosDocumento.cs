using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbPubAgendaCompromissosDocumento
    {
        public int IdAgendaCompromissoDocumento { get; set; }
        public int IdAgendaCompromisso { get; set; }
        public string? NmDocumento { get; set; }
        public string? NmArquivo { get; set; }
        public string? ExtArquivo { get; set; }
        public byte[]? BnArquivo { get; set; }
        public DateTime? DtInclusao { get; set; }

        public virtual TbPubAgendaCompromisso IdAgendaCompromissoNavigation { get; set; } = null!;
    }
}
