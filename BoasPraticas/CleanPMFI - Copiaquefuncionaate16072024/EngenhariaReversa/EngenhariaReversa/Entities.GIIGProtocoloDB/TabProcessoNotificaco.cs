using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class TabProcessoNotificaco
    {
        public int ProcNotificacaoId { get; set; }
        public long ProcId { get; set; }
        public string Email { get; set; } = null!;
        public DateTime Data { get; set; }
        public string Ativo { get; set; } = null!;

        public virtual TabProcesso Proc { get; set; } = null!;
    }
}
