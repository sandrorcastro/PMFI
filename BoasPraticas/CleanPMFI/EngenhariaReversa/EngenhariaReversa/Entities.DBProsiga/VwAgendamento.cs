using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class VwAgendamento
    {
        public int Idagendamento { get; set; }
        public DateTime? Dtagendamento { get; set; }
        public TimeSpan? Horainicial { get; set; }
        public TimeSpan? Horafinal { get; set; }
        public string? Flstatus { get; set; }
        public string Nmservico { get; set; } = null!;
        public string? Nmlocal { get; set; }
        public DateTime? Dtnascimento { get; set; }
    }
}
