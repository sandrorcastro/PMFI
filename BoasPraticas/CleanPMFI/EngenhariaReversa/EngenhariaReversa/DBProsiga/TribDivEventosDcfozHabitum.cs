using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribDivEventosDcfozHabitum
    {
        public int? ConIddivida { get; set; }
        public int? DivEmpId { get; set; }
        public long ImoidDivida { get; set; }
        public DateTime DtEvento { get; set; }
        public int IdLeiAto { get; set; }
        public string TpEvento { get; set; } = null!;
        public string DsAcao { get; set; } = null!;
        public int VlEvento { get; set; }
        public string DsLogin { get; set; } = null!;
        public DateTime DtInclusao { get; set; }
        public int FlProcessado { get; set; }
        public int? DtProcessamento { get; set; }
        public string DsErro { get; set; } = null!;
        public string NrGuid { get; set; } = null!;
        public int? NmObjeto { get; set; }
        public int? IdObjeto { get; set; }
    }
}
