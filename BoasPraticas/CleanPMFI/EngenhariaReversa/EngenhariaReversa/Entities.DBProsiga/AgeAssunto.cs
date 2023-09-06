using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class AgeAssunto
    {
        public AgeAssunto()
        {
            AgeAgendamentos = new HashSet<AgeAgendamento>();
        }

        public int AssunId { get; set; }
        public string? AssunDescricao { get; set; }

        public virtual ICollection<AgeAgendamento> AgeAgendamentos { get; set; }
    }
}
