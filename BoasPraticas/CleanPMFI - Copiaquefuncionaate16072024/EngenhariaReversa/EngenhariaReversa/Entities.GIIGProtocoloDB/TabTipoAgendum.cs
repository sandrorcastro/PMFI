using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class TabTipoAgendum
    {
        public TabTipoAgendum()
        {
            TabAgenda = new HashSet<TabAgendum>();
        }

        public int TpAgId { get; set; }
        public string? TpAgNome { get; set; }
        public string? TpAgTexto { get; set; }
        public DateTime? TpAgDtInicial { get; set; }
        public string? TpAgHrInicioManha { get; set; }
        public string? TpAghrFimManha { get; set; }
        public string? TpAgHrFimTarde { get; set; }
        public string? TpAgMinIntervalo { get; set; }
        public int? TpAgQtdeGuiches { get; set; }
        public int? TpAgQtdeManha { get; set; }
        public int? TpAgQtdeTarde { get; set; }
        public DateTime? TpAgDtFinal { get; set; }
        public string? TpAgHrInicioTarde { get; set; }
        public DateTime? TpAgDtInicialAgendamento { get; set; }
        public DateTime? TpAgDtFinalAgendamento { get; set; }

        public virtual ICollection<TabAgendum> TabAgenda { get; set; }
    }
}
