using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class AgeAgendaTipoAgendamento
    {
        public long AgendaId { get; set; }
        public long TipoAgeId { get; set; }
        public string? Cor { get; set; }

        public virtual AgeAgendum Agenda { get; set; } = null!;
        public virtual AgeTipoAgendamento TipoAge { get; set; } = null!;
    }
}
