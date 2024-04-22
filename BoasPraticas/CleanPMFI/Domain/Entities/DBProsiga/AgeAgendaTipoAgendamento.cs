using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
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
