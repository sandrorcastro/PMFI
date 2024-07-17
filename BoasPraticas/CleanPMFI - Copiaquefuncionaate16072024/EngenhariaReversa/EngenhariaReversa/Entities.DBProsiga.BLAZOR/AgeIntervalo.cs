using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class AgeIntervalo
    {
        public AgeIntervalo()
        {
            AgeAgendaIntervalos = new HashSet<AgeAgendaIntervalo>();
        }

        public long InterId { get; set; }
        public DateTime? InterHoraIni { get; set; }
        public DateTime? InterHoraFin { get; set; }
        public DateTime? InterHoraDesc { get; set; }
        public int? InterDuracaoDesc { get; set; }
        public int? InterHorario { get; set; }

        public virtual ICollection<AgeAgendaIntervalo> AgeAgendaIntervalos { get; set; }
    }
}
