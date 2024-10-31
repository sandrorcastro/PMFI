using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class AgeAgendaIntervalo
    {
        public long AgendaId { get; set; }
        public string IntAgdiaSemana { get; set; } = null!;
        public long? InterId { get; set; }

        public virtual AgeAgendum Agenda { get; set; } = null!;
        public virtual AgeIntervalo? Inter { get; set; }
    }
}
