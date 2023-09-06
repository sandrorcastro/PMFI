using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbPubAgendaCompromisso
    {
        public TbPubAgendaCompromisso()
        {
            TbPubAgendaCompromissosDocumentos = new HashSet<TbPubAgendaCompromissosDocumento>();
        }

        public int IdAgendaCompromisso { get; set; }
        public int IdAutoridade { get; set; }
        public DateTime? DtCompromisso { get; set; }
        public TimeSpan? HrInicial { get; set; }
        public string? DsLocal { get; set; }
        public string? DsAssuntos { get; set; }
        public string? DsTipoPessoa { get; set; }
        public string? NmPessoa { get; set; }
        public string? DsParticipantes { get; set; }
        public string? DsObjetivo { get; set; }
        public string? DsResultados { get; set; }

        public virtual TbPubAgendaAutoridade IdAutoridadeNavigation { get; set; } = null!;
        public virtual ICollection<TbPubAgendaCompromissosDocumento> TbPubAgendaCompromissosDocumentos { get; set; }
    }
}
