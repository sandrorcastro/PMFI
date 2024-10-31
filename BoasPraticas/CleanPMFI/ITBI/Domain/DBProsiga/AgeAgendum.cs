using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class AgeAgendum
    {
        public AgeAgendum()
        {
            AgeAgendaIntervalos = new HashSet<AgeAgendaIntervalo>();
            AgeAgendaTipoAgendamentos = new HashSet<AgeAgendaTipoAgendamento>();
            AgeAgendamentos = new HashSet<AgeAgendamento>();
            AgePermissaos = new HashSet<AgePermissao>();
        }

        public long AgendaId { get; set; }
        public long? ServId { get; set; }
        public string? AgendaSituacao { get; set; }
        public DateTime? AgendaDataCad { get; set; }
        public string? AgendaMensagem { get; set; }

        public virtual Servidore? Serv { get; set; }
        public virtual ICollection<AgeAgendaIntervalo> AgeAgendaIntervalos { get; set; }
        public virtual ICollection<AgeAgendaTipoAgendamento> AgeAgendaTipoAgendamentos { get; set; }
        public virtual ICollection<AgeAgendamento> AgeAgendamentos { get; set; }
        public virtual ICollection<AgePermissao> AgePermissaos { get; set; }
    }
}
