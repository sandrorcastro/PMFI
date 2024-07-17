using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class TabMensagemDestino
    {
        public TabMensagemDestino()
        {
            TabMensagemResposta = new HashSet<TabMensagemRespostum>();
        }

        public long MensId { get; set; }
        public short FuncId { get; set; }
        public string? MedeStatus { get; set; }
        public DateTime? MedeData { get; set; }

        public virtual TabFuncionario Func { get; set; } = null!;
        public virtual TabMensagem Mens { get; set; } = null!;
        public virtual ICollection<TabMensagemRespostum> TabMensagemResposta { get; set; }
    }
}
