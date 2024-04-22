using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class AgeTipoAgendamento
    {
        public AgeTipoAgendamento()
        {
            AgeAgendaTipoAgendamentos = new HashSet<AgeAgendaTipoAgendamento>();
            AgeAgendamentos = new HashSet<AgeAgendamento>();
        }

        public long TipoAgeId { get; set; }
        public string? TipoAgeNome { get; set; }

        public virtual ICollection<AgeAgendaTipoAgendamento> AgeAgendaTipoAgendamentos { get; set; }
        public virtual ICollection<AgeAgendamento> AgeAgendamentos { get; set; }
    }
}
