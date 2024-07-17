using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class TabMensagemRespostum
    {
        public TabMensagemRespostum()
        {
            Anes = new HashSet<TabAnexo1>();
        }

        public int RespId { get; set; }
        public string? RespDescricao { get; set; }
        public long? MensId { get; set; }
        public short? FuncId { get; set; }
        public DateTime? RespData { get; set; }

        public virtual TabMensagemDestino? TabMensagemDestino { get; set; }

        public virtual ICollection<TabAnexo1> Anes { get; set; }
    }
}
