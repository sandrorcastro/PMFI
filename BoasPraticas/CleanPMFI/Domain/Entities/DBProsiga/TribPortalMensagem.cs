using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribPortalMensagem
    {
        public TribPortalMensagem()
        {
            TribPortalCaixaEntrada = new HashSet<TribPortalCaixaEntradum>();
        }

        public int Msgid { get; set; }
        public string? MsgCorpo { get; set; }
        public string? MsgAssunto { get; set; }
        public string? MsgDe { get; set; }
        public long? Servid { get; set; }
        public string? MsgTipo { get; set; }
        public DateTime? MsgData { get; set; }
        public DateTime? MsgVigenteAte { get; set; }

        public virtual Servidore? Serv { get; set; }
        public virtual ICollection<TribPortalCaixaEntradum> TribPortalCaixaEntrada { get; set; }
    }
}
