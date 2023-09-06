using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbPubAgendaAutoridade
    {
        public TbPubAgendaAutoridade()
        {
            TbPubAgendaCompromissos = new HashSet<TbPubAgendaCompromisso>();
        }

        public int IdAutoridade { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public string? NmAutoridade { get; set; }
        public string? FlAtivo { get; set; }

        public virtual ICollection<TbPubAgendaCompromisso> TbPubAgendaCompromissos { get; set; }
    }
}
