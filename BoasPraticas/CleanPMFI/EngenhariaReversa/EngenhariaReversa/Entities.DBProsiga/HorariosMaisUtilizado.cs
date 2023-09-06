using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class HorariosMaisUtilizado
    {
        public int LocId { get; set; }
        public string? LocNome { get; set; }
        public int SubLocalId { get; set; }
        public string? SubLocNome { get; set; }
        public long LocacaoId { get; set; }
        public string? LcHorarioIni { get; set; }
        public string? LcHorarioFim { get; set; }
        public decimal? LcValorLocacao { get; set; }
        public DateTime? LcDataIni { get; set; }
    }
}
