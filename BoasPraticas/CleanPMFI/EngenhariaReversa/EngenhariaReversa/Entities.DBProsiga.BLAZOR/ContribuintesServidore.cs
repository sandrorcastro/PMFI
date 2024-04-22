using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class ContribuintesServidore
    {
        public int CoSeId { get; set; }
        public long ConId { get; set; }
        public string? CoSeMatricula { get; set; }
        public string? CoSeCargo { get; set; }
        public string? CoSeEscolaridade { get; set; }
        public string? CoSeFormacao { get; set; }
        public string? CoSeComportamento { get; set; }
        public string? CoSeTipoSanguineo { get; set; }
        public string? CoSeCursos { get; set; }
        public DateTime? CoSeDataAdmissao { get; set; }

        public virtual Contribuinte Con { get; set; } = null!;
    }
}
