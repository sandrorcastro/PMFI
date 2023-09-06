using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class TabAnexo1
    {
        public TabAnexo1()
        {
            Mens = new HashSet<TabMensagem>();
            Resps = new HashSet<TabMensagemRespostum>();
        }

        public int AneId { get; set; }
        public byte[]? AneObjeto { get; set; }
        public string? AneContentType { get; set; }
        public string? AneExtensao { get; set; }

        public virtual ICollection<TabMensagem> Mens { get; set; }
        public virtual ICollection<TabMensagemRespostum> Resps { get; set; }
    }
}
